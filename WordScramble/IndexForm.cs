namespace WordScramble;

public partial class IndexForm : Form
{
    private const string WordsTextFile = "words.txt";
    private const int MaxAttemptsPerWord = 10;

    private readonly List<string> failedAttempts = [];
    private readonly List<string> wordList = [];
    private readonly Random random = new();

    private int attempts;
    private int guessedWords;
    private int score;
    private bool hintUsed;
    private string currentWord = string.Empty;

    public IndexForm()
    {
        InitializeComponent();
    }

    private void IndexFormLoad(object sender, EventArgs e)
    {
        GetAllWords();
        GenerateNewWord();
        UpdateLabels();
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

        using StreamReader reader = new(wordsFilePath);

        while (!reader.EndOfStream)
        {
            string? word = reader.ReadLine();

            if (!string.IsNullOrWhiteSpace(word))
            {
                wordList.Add(word.Trim().ToLower());
            }
        }
    }

    private void GenerateNewWord()
    {
        if (wordList.Count == 0)
        {
            currentWord = string.Empty;
            labelScrambledWord.Text = "No words left";
            labelStatus.Text = "Game complete! You guessed every available word.";
            textBoxInput.Enabled = false;
            buttonCheck.Enabled = false;
            buttonSkip.Enabled = false;
            buttonHint.Enabled = false;
            return;
        }

        int randomIndex = random.Next(wordList.Count);
        currentWord = wordList[randomIndex];
        ResetGameInfo();
    }

    private void ResetGameInfo()
    {
        attempts = 0;
        hintUsed = false;
        failedAttempts.Clear();
        labelScrambledWord.Text = ScrambleWord(currentWord);
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
        int earnedPoints = Math.Max(1, MaxAttemptsPerWord - attempts) + guessedWord.Length;

        guessedWords++;
        score += earnedPoints;
        wordList.Remove(guessedWord);

        if (wordList.Count == 0)
        {
            currentWord = string.Empty;
            labelScrambledWord.Text = "Finished";
            labelStatus.Text = $"Correct! The last word was '{guessedWord}'. Final score: {score}.";
            textBoxInput.Enabled = false;
            buttonCheck.Enabled = false;
            buttonSkip.Enabled = false;
            buttonHint.Enabled = false;
            return;
        }

        GenerateNewWord();
        labelStatus.Text = $"Correct! The word was '{guessedWord}'. You earned {earnedPoints} points.";
    }

    private void UnsuccessfulAttempt(string input)
    {
        attempts++;
        failedAttempts.Add(input);
        score = Math.Max(0, score - 1);

        if (attempts >= MaxAttemptsPerWord)
        {
            string missedWord = currentWord;
            wordList.Remove(missedWord);
            GenerateNewWord();
            labelStatus.Text = $"New word generated. The missed word was '{missedWord}'.";
            return;
        }

        labelStatus.Text = $"Try again. You have {MaxAttemptsPerWord - attempts} attempts left for this word.";
    }

    private void UpdateLabels()
    {
        labelAttemptsCount.Text = attempts.ToString();
        labelGuessedCount.Text = guessedWords.ToString();
        labelScoreCount.Text = score.ToString();
        textBoxFailedAttempts.Text = string.Join(Environment.NewLine, failedAttempts);
        textBoxInput.Clear();
        textBoxInput.Focus();
    }

    private void ButtonSkipClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        string skippedWord = currentWord;
        score = Math.Max(0, score - 2);
        wordList.Remove(skippedWord);
        GenerateNewWord();
        labelStatus.Text = $"Skipped. The word was '{skippedWord}'.";
        UpdateLabels();
    }

    private void ButtonHintClick(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentWord))
        {
            return;
        }

        if (hintUsed)
        {
            labelStatus.Text = "Hint already used for this word.";
            textBoxInput.Focus();
            return;
        }

        hintUsed = true;
        score = Math.Max(0, score - 3);
        labelScoreCount.Text = score.ToString();

        if (currentWord.Length <= 2)
        {
            labelStatus.Text = $"Hint: the word is '{currentWord}'.";
            return;
        }

        string middle = new('_', currentWord.Length - 2);
        labelStatus.Text = $"Hint: {currentWord[0]}{middle}{currentWord[^1]}";
        textBoxInput.Focus();
    }

    private void TextBoxInputKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            ButtonCheckClick(sender, e);
            e.SuppressKeyPress = true;
        }
    }
}
