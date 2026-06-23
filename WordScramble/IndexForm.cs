namespace WordScramble;

public partial class IndexForm : Form
{
    private const string WordsTextFile = "words.txt";
    private const int MaxAttemptsPerWord = 6;

    private readonly Dictionary<string, DifficultySettings> difficultySettings = new()
    {
        ["Chill"] = new DifficultySettings(45, 5, 1.0),
        ["Classic"] = new DifficultySettings(30, 4, 1.25),
        ["Blitz"] = new DifficultySettings(18, 3, 1.75)
    };

    private readonly List<string> allWords = [];
    private readonly List<string> remainingWords = [];
    private readonly List<string> failedAttempts = [];
    private readonly HashSet<int> revealedIndexes = [];
    private readonly Random random = new();

    private int attempts;
    private int guessedWords;
    private int score;
    private int secondsLeft;
    private int streak;
    private int lives;
    private int highScore;
    private int hintsUsedForWord;
    private string currentWord = string.Empty;

    public IndexForm()
    {
        InitializeComponent();
    }

    private void IndexFormLoad(object sender, EventArgs e)
    {
        comboBoxDifficulty.SelectedIndex = 1;
        GetAllWords();
        LoadHighScore();
        StartNewGame();
    }

    private DifficultySettings CurrentDifficulty
    {
        get
        {
            string difficultyName = comboBoxDifficulty.SelectedItem?.ToString() ?? "Classic";
            return difficultySettings[difficultyName];
        }
    }

    private string HighScoreFilePath
    {
        get
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "WordScramble");

            Directory.CreateDirectory(folder);
            return Path.Combine(folder, "high-score.txt");
        }
    }

    private void GetAllWords()
    {
        string wordsFilePath = Path.Combine(AppContext.BaseDirectory, WordsTextFile);

        if (!File.Exists(wordsFilePath))
        {
            MessageBox.Show(
                $"The file '{WordsTextFile}' was not found next to the application.",
                "Missing word list",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            Close();
            return;
        }

        allWords.Clear();

        using StreamReader reader = new(wordsFilePath);

        while (!reader.EndOfStream)
        {
            string? word = reader.ReadLine();

            if (!string.IsNullOrWhiteSpace(word))
            {
                allWords.Add(word.Trim().ToLower());
            }
        }
    }

    private void StartNewGame()
    {
        countdownTimer.Stop();

        if (allWords.Count == 0)
        {
            labelStatus.Text = "No words were loaded. Check words.txt.";
            SetGameControlsEnabled(false);
            return;
        }

        DifficultySettings settings = CurrentDifficulty;
        remainingWords.Clear();
        remainingWords.AddRange(allWords);

        attempts = 0;
        guessedWords = 0;
        score = 0;
        streak = 0;
        lives = settings.StartingLives;

        SetGameControlsEnabled(true);
        labelStatus.Text = $"New {comboBoxDifficulty.Text} game started. Clear as many words as you can.";
        GenerateNewWord();
        UpdateLabels();
    }

    private void GenerateNewWord()
    {
        if (remainingWords.Count == 0)
        {
            EndGame("You cleared every word in the list. Absolute word wizard behavior.", true);
            return;
        }

        int randomIndex = random.Next(remainingWords.Count);
        currentWord = remainingWords[randomIndex];
        ResetRoundInfo();
    }

    private void ResetRoundInfo()
    {
        DifficultySettings settings = CurrentDifficulty;

        attempts = 0;
        secondsLeft = settings.SecondsPerRound;
        hintsUsedForWord = 0;
        failedAttempts.Clear();
        revealedIndexes.Clear();

        progressBarTimer.Maximum = settings.SecondsPerRound;
        progressBarTimer.Value = secondsLeft;
        labelScrambledWord.Text = ScrambleWord(currentWord);
        UpdateTimerLabel();
        countdownTimer.Start();
    }

    private string ScrambleWord(string word)
    {
        char[] characters = word.ToCharArray();

        for (int n = characters.Length - 1; n > 0; n--)
        {
            int k = random.Next(n + 1);
            (characters[n], characters[k]) = (characters[k], characters[n]);
        }

        string scrambledWord = new(characters);

        if (scrambledWord == word && word.Length > 1)
        {
            return ScrambleWord(word);
        }

        return scrambledWord;
    }

    private void ButtonCheckClick(object sender, EventArgs e)
    {
        CheckTheWord();
        UpdateLabels();
    }

    private void CheckTheWord()
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        string input = textBoxInput.Text.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(input))
        {
            labelStatus.Text = "Type your guess first.";
            return;
        }

        if (input == currentWord)
        {
            SuccessfulAttempt();
        }
        else
        {
            UnsuccessfulAttempt(input);
        }
    }

    private void SuccessfulAttempt()
    {
        string guessedWord = currentWord;
        int earnedPoints = CalculatePoints();

        countdownTimer.Stop();
        guessedWords++;
        streak++;
        score += earnedPoints;
        remainingWords.Remove(guessedWord);
        UpdateHighScore();

        if (remainingWords.Count == 0)
        {
            EndGame($"Final answer locked in: '{guessedWord}'. You cleared the deck.", true);
            return;
        }

        GenerateNewWord();
        labelStatus.Text = $"Correct: '{guessedWord}'. +{earnedPoints} points. Streak: {streak}.";
    }

    private int CalculatePoints()
    {
        DifficultySettings settings = CurrentDifficulty;
        int timeBonus = secondsLeft;
        int attemptBonus = Math.Max(0, MaxAttemptsPerWord - attempts) * 3;
        int streakBonus = Math.Min(streak + 1, 10) * 5;
        int wordValue = currentWord.Length * 4;
        int rawPoints = wordValue + timeBonus + attemptBonus + streakBonus;

        return Math.Max(1, (int)Math.Round(rawPoints * settings.ScoreMultiplier));
    }

    private void UnsuccessfulAttempt(string input)
    {
        attempts++;
        failedAttempts.Add(input);
        score = Math.Max(0, score - 2);

        if (attempts >= MaxAttemptsPerWord)
        {
            LoseLife($"Too many attempts. The word was '{currentWord}'.");
            return;
        }

        labelStatus.Text = $"Not it. {MaxAttemptsPerWord - attempts} attempts left for this word.";
    }

    private void LoseLife(string reason)
    {
        countdownTimer.Stop();

        string missedWord = currentWord;
        lives--;
        streak = 0;
        remainingWords.Remove(missedWord);
        UpdateHighScore();

        if (lives <= 0)
        {
            EndGame($"{reason} No lives left. Final score: {score}.", false);
            return;
        }

        GenerateNewWord();
        labelStatus.Text = $"{reason} Lives left: {lives}.";
    }

    private void EndGame(string message, bool won)
    {
        countdownTimer.Stop();
        currentWord = string.Empty;
        secondsLeft = 0;
        UpdateHighScore();
        SetGameControlsEnabled(false);
        labelScrambledWord.Text = won ? "CLEARED" : "GAME OVER";
        labelStatus.Text = message;
        UpdateLabels();
    }

    private void UpdateLabels()
    {
        labelAttemptsCount.Text = attempts.ToString();
        labelGuessedCount.Text = guessedWords.ToString();
        labelScoreCount.Text = score.ToString();
        labelStreakCount.Text = streak.ToString();
        labelLivesCount.Text = lives.ToString();
        labelHighScoreCount.Text = highScore.ToString();
        labelWordsLeftCount.Text = remainingWords.Count.ToString();
        UpdateTimerLabel();
        textBoxFailedAttempts.Text = string.Join(Environment.NewLine, failedAttempts);
        textBoxInput.Clear();

        if (textBoxInput.Enabled)
        {
            textBoxInput.Focus();
        }
    }

    private void ButtonSkipClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        string skippedWord = currentWord;
        countdownTimer.Stop();
        score = Math.Max(0, score - 8);
        streak = 0;
        remainingWords.Remove(skippedWord);
        UpdateHighScore();
        GenerateNewWord();
        labelStatus.Text = $"Skipped '{skippedWord}'. -8 points and streak reset.";
        UpdateLabels();
    }

    private void ButtonHintClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        if (revealedIndexes.Count >= currentWord.Length)
        {
            labelStatus.Text = $"Full reveal: {currentWord}";
            textBoxInput.Focus();
            return;
        }

        int indexToReveal = GetNextHintIndex();
        revealedIndexes.Add(indexToReveal);
        hintsUsedForWord++;

        int penalty = 5 + hintsUsedForWord * 2;
        score = Math.Max(0, score - penalty);
        streak = 0;
        labelStatus.Text = $"Hint: {BuildHintPattern()} (-{penalty} points)";
        UpdateLabels();
    }

    private int GetNextHintIndex()
    {
        if (!revealedIndexes.Contains(0))
        {
            return 0;
        }

        if (!revealedIndexes.Contains(currentWord.Length - 1))
        {
            return currentWord.Length - 1;
        }

        List<int> hiddenIndexes = [];

        for (int i = 0; i < currentWord.Length; i++)
        {
            if (!revealedIndexes.Contains(i))
            {
                hiddenIndexes.Add(i);
            }
        }

        return hiddenIndexes[random.Next(hiddenIndexes.Count)];
    }

    private string BuildHintPattern()
    {
        char[] pattern = new char[currentWord.Length];

        for (int i = 0; i < currentWord.Length; i++)
        {
            pattern[i] = revealedIndexes.Contains(i) ? currentWord[i] : '_';
        }

        return string.Join(" ", pattern);
    }

    private void ButtonReshuffleClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        labelScrambledWord.Text = ScrambleWord(currentWord);
        score = Math.Max(0, score - 1);
        labelStatus.Text = "Fresh scramble generated. -1 point.";
        UpdateLabels();
    }

    private void ButtonNewGameClick(object sender, EventArgs e)
    {
        StartNewGame();
    }

    private void TextBoxInputKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            ButtonCheckClick(sender, e);
            e.SuppressKeyPress = true;
        }
    }

    private void CountdownTimerTick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            countdownTimer.Stop();
            return;
        }

        secondsLeft--;
        UpdateTimerLabel();

        if (secondsLeft <= 0)
        {
            TimeExpired();
        }
    }

    private void TimeExpired()
    {
        failedAttempts.Add("time expired");
        LoseLife($"Time's up. The word was '{currentWord}'.");
        UpdateLabels();
    }

    private void UpdateTimerLabel()
    {
        labelTimerCount.Text = $"{secondsLeft}s";
        labelTimerCount.ForeColor = secondsLeft <= 5 ? Color.Firebrick : Color.FromArgb(0, 122, 255);

        if (secondsLeft >= 0 && secondsLeft <= progressBarTimer.Maximum)
        {
            progressBarTimer.Value = secondsLeft;
        }
    }

    private void SetGameControlsEnabled(bool enabled)
    {
        textBoxInput.Enabled = enabled;
        buttonCheck.Enabled = enabled;
        buttonSkip.Enabled = enabled;
        buttonHint.Enabled = enabled;
        buttonReshuffle.Enabled = enabled;
    }

    private void LoadHighScore()
    {
        highScore = 0;

        try
        {
            if (File.Exists(HighScoreFilePath)
                && int.TryParse(File.ReadAllText(HighScoreFilePath), out int savedHighScore))
            {
                highScore = savedHighScore;
            }
        }
        catch
        {
            highScore = 0;
        }
    }

    private void UpdateHighScore()
    {
        if (score <= highScore)
        {
            return;
        }

        highScore = score;
        labelHighScoreCount.Text = highScore.ToString();

        try
        {
            File.WriteAllText(HighScoreFilePath, highScore.ToString());
        }
        catch
        {
            labelStatus.Text = "High score updated, but it could not be saved to disk.";
        }
    }

    private sealed record DifficultySettings(int SecondsPerRound, int StartingLives, double ScoreMultiplier);
}
