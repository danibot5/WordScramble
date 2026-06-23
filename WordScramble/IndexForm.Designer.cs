namespace WordScramble;

partial class IndexForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        labelTitle = new Label();
        labelSubtitle = new Label();
        labelDifficulty = new Label();
        comboBoxDifficulty = new ComboBox();
        buttonNewGame = new Button();
        labelScrambledCaption = new Label();
        labelScrambledWord = new Label();
        progressBarTimer = new ProgressBar();
        labelTimer = new Label();
        labelTimerCount = new Label();
        labelInput = new Label();
        textBoxInput = new TextBox();
        buttonCheck = new Button();
        buttonHint = new Button();
        buttonReshuffle = new Button();
        buttonSkip = new Button();
        labelAttempts = new Label();
        labelAttemptsCount = new Label();
        labelGuessed = new Label();
        labelGuessedCount = new Label();
        labelScore = new Label();
        labelScoreCount = new Label();
        labelStreak = new Label();
        labelStreakCount = new Label();
        labelLives = new Label();
        labelLivesCount = new Label();
        labelHighScore = new Label();
        labelHighScoreCount = new Label();
        labelWordsLeft = new Label();
        labelWordsLeftCount = new Label();
        labelFailedAttempts = new Label();
        textBoxFailedAttempts = new TextBox();
        labelStatus = new Label();
        countdownTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(28, 28, 30);
        labelTitle.Location = new Point(48, 28);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(328, 51);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Word Scramble X";
        // 
        // labelSubtitle
        // 
        labelSubtitle.AutoSize = true;
        labelSubtitle.Font = new Font("Segoe UI", 10F);
        labelSubtitle.ForeColor = Color.FromArgb(90, 90, 96);
        labelSubtitle.Location = new Point(53, 82);
        labelSubtitle.Name = "labelSubtitle";
        labelSubtitle.Size = new Size(313, 19);
        labelSubtitle.TabIndex = 1;
        labelSubtitle.Text = "Arcade mode with lives, streaks, hints, and high scores";
        // 
        // labelDifficulty
        // 
        labelDifficulty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelDifficulty.AutoSize = true;
        labelDifficulty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelDifficulty.Location = new Point(827, 40);
        labelDifficulty.Name = "labelDifficulty";
        labelDifficulty.Size = new Size(70, 19);
        labelDifficulty.TabIndex = 2;
        labelDifficulty.Text = "Difficulty";
        // 
        // comboBoxDifficulty
        // 
        comboBoxDifficulty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        comboBoxDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDifficulty.Font = new Font("Segoe UI", 10F);
        comboBoxDifficulty.FormattingEnabled = true;
        comboBoxDifficulty.Items.AddRange(new object[] { "Chill", "Classic", "Blitz" });
        comboBoxDifficulty.Location = new Point(903, 37);
        comboBoxDifficulty.Name = "comboBoxDifficulty";
        comboBoxDifficulty.Size = new Size(121, 25);
        comboBoxDifficulty.TabIndex = 1;
        // 
        // buttonNewGame
        // 
        buttonNewGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonNewGame.BackColor = Color.FromArgb(28, 28, 30);
        buttonNewGame.FlatAppearance.BorderSize = 0;
        buttonNewGame.FlatStyle = FlatStyle.Flat;
        buttonNewGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonNewGame.ForeColor = Color.White;
        buttonNewGame.Location = new Point(1042, 36);
        buttonNewGame.Name = "buttonNewGame";
        buttonNewGame.Size = new Size(110, 30);
        buttonNewGame.TabIndex = 2;
        buttonNewGame.Text = "New Game";
        buttonNewGame.UseVisualStyleBackColor = false;
        buttonNewGame.Click += ButtonNewGameClick;
        // 
        // labelScrambledCaption
        // 
        labelScrambledCaption.AutoSize = true;
        labelScrambledCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelScrambledCaption.Location = new Point(53, 132);
        labelScrambledCaption.Name = "labelScrambledCaption";
        labelScrambledCaption.Size = new Size(127, 20);
        labelScrambledCaption.TabIndex = 4;
        labelScrambledCaption.Text = "Scrambled word";
        // 
        // labelScrambledWord
        // 
        labelScrambledWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelScrambledWord.BackColor = Color.White;
        labelScrambledWord.BorderStyle = BorderStyle.FixedSingle;
        labelScrambledWord.Font = new Font("Consolas", 32F, FontStyle.Bold);
        labelScrambledWord.ForeColor = Color.FromArgb(28, 28, 30);
        labelScrambledWord.Location = new Point(53, 160);
        labelScrambledWord.Name = "labelScrambledWord";
        labelScrambledWord.Size = new Size(791, 82);
        labelScrambledWord.TabIndex = 5;
        labelScrambledWord.Text = "loading";
        labelScrambledWord.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // progressBarTimer
        // 
        progressBarTimer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        progressBarTimer.Location = new Point(53, 262);
        progressBarTimer.Name = "progressBarTimer";
        progressBarTimer.Size = new Size(716, 15);
        progressBarTimer.Step = 1;
        progressBarTimer.TabIndex = 6;
        // 
        // labelTimer
        // 
        labelTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelTimer.AutoSize = true;
        labelTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelTimer.Location = new Point(785, 259);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new Size(49, 19);
        labelTimer.TabIndex = 7;
        labelTimer.Text = "Timer:";
        // 
        // labelTimerCount
        // 
        labelTimerCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelTimerCount.AutoSize = true;
        labelTimerCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelTimerCount.ForeColor = Color.FromArgb(0, 122, 255);
        labelTimerCount.Location = new Point(835, 258);
        labelTimerCount.Name = "labelTimerCount";
        labelTimerCount.Size = new Size(35, 20);
        labelTimerCount.TabIndex = 8;
        labelTimerCount.Text = "30s";
        // 
        // labelInput
        // 
        labelInput.AutoSize = true;
        labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelInput.Location = new Point(53, 309);
        labelInput.Name = "labelInput";
        labelInput.Size = new Size(82, 19);
        labelInput.TabIndex = 9;
        labelInput.Text = "Your guess";
        // 
        // textBoxInput
        // 
        textBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxInput.Font = new Font("Segoe UI", 16F);
        textBoxInput.Location = new Point(53, 334);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(486, 36);
        textBoxInput.TabIndex = 3;
        textBoxInput.KeyDown += TextBoxInputKeyDown;
        // 
        // buttonCheck
        // 
        buttonCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCheck.BackColor = Color.FromArgb(0, 122, 255);
        buttonCheck.FlatAppearance.BorderSize = 0;
        buttonCheck.FlatStyle = FlatStyle.Flat;
        buttonCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonCheck.ForeColor = Color.White;
        buttonCheck.Location = new Point(555, 335);
        buttonCheck.Name = "buttonCheck";
        buttonCheck.Size = new Size(86, 35);
        buttonCheck.TabIndex = 4;
        buttonCheck.Text = "Check";
        buttonCheck.UseVisualStyleBackColor = false;
        buttonCheck.Click += ButtonCheckClick;
        // 
        // buttonHint
        // 
        buttonHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonHint.Location = new Point(650, 335);
        buttonHint.Name = "buttonHint";
        buttonHint.Size = new Size(62, 35);
        buttonHint.TabIndex = 5;
        buttonHint.Text = "Hint";
        buttonHint.UseVisualStyleBackColor = true;
        buttonHint.Click += ButtonHintClick;
        // 
        // buttonReshuffle
        // 
        buttonReshuffle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonReshuffle.Location = new Point(721, 335);
        buttonReshuffle.Name = "buttonReshuffle";
        buttonReshuffle.Size = new Size(81, 35);
        buttonReshuffle.TabIndex = 6;
        buttonReshuffle.Text = "Reshuffle";
        buttonReshuffle.UseVisualStyleBackColor = true;
        buttonReshuffle.Click += ButtonReshuffleClick;
        // 
        // buttonSkip
        // 
        buttonSkip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonSkip.Location = new Point(811, 335);
        buttonSkip.Name = "buttonSkip";
        buttonSkip.Size = new Size(60, 35);
        buttonSkip.TabIndex = 7;
        buttonSkip.Text = "Skip";
        buttonSkip.UseVisualStyleBackColor = true;
        buttonSkip.Click += ButtonSkipClick;
        // 
        // labelAttempts
        // 
        labelAttempts.AutoSize = true;
        labelAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelAttempts.Location = new Point(53, 412);
        labelAttempts.Name = "labelAttempts";
        labelAttempts.Size = new Size(71, 19);
        labelAttempts.TabIndex = 14;
        labelAttempts.Text = "Attempts";
        // 
        // labelAttemptsCount
        // 
        labelAttemptsCount.AutoSize = true;
        labelAttemptsCount.Font = new Font("Segoe UI", 11F);
        labelAttemptsCount.Location = new Point(142, 412);
        labelAttemptsCount.Name = "labelAttemptsCount";
        labelAttemptsCount.Size = new Size(17, 20);
        labelAttemptsCount.TabIndex = 15;
        labelAttemptsCount.Text = "0";
        // 
        // labelGuessed
        // 
        labelGuessed.AutoSize = true;
        labelGuessed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelGuessed.Location = new Point(53, 448);
        labelGuessed.Name = "labelGuessed";
        labelGuessed.Size = new Size(106, 19);
        labelGuessed.TabIndex = 16;
        labelGuessed.Text = "Words solved";
        // 
        // labelGuessedCount
        // 
        labelGuessedCount.AutoSize = true;
        labelGuessedCount.Font = new Font("Segoe UI", 11F);
        labelGuessedCount.Location = new Point(178, 448);
        labelGuessedCount.Name = "labelGuessedCount";
        labelGuessedCount.Size = new Size(17, 20);
        labelGuessedCount.TabIndex = 17;
        labelGuessedCount.Text = "0";
        // 
        // labelScore
        // 
        labelScore.AutoSize = true;
        labelScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelScore.Location = new Point(263, 412);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(48, 19);
        labelScore.TabIndex = 18;
        labelScore.Text = "Score";
        // 
        // labelScoreCount
        // 
        labelScoreCount.AutoSize = true;
        labelScoreCount.Font = new Font("Segoe UI", 11F);
        labelScoreCount.Location = new Point(335, 412);
        labelScoreCount.Name = "labelScoreCount";
        labelScoreCount.Size = new Size(17, 20);
        labelScoreCount.TabIndex = 19;
        labelScoreCount.Text = "0";
        // 
        // labelStreak
        // 
        labelStreak.AutoSize = true;
        labelStreak.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelStreak.Location = new Point(263, 448);
        labelStreak.Name = "labelStreak";
        labelStreak.Size = new Size(50, 19);
        labelStreak.TabIndex = 20;
        labelStreak.Text = "Streak";
        // 
        // labelStreakCount
        // 
        labelStreakCount.AutoSize = true;
        labelStreakCount.Font = new Font("Segoe UI", 11F);
        labelStreakCount.Location = new Point(335, 448);
        labelStreakCount.Name = "labelStreakCount";
        labelStreakCount.Size = new Size(17, 20);
        labelStreakCount.TabIndex = 21;
        labelStreakCount.Text = "0";
        // 
        // labelLives
        // 
        labelLives.AutoSize = true;
        labelLives.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelLives.Location = new Point(470, 412);
        labelLives.Name = "labelLives";
        labelLives.Size = new Size(43, 19);
        labelLives.TabIndex = 22;
        labelLives.Text = "Lives";
        // 
        // labelLivesCount
        // 
        labelLivesCount.AutoSize = true;
        labelLivesCount.Font = new Font("Segoe UI", 11F);
        labelLivesCount.Location = new Point(565, 412);
        labelLivesCount.Name = "labelLivesCount";
        labelLivesCount.Size = new Size(17, 20);
        labelLivesCount.TabIndex = 23;
        labelLivesCount.Text = "0";
        // 
        // labelHighScore
        // 
        labelHighScore.AutoSize = true;
        labelHighScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelHighScore.Location = new Point(470, 448);
        labelHighScore.Name = "labelHighScore";
        labelHighScore.Size = new Size(80, 19);
        labelHighScore.TabIndex = 24;
        labelHighScore.Text = "High score";
        // 
        // labelHighScoreCount
        // 
        labelHighScoreCount.AutoSize = true;
        labelHighScoreCount.Font = new Font("Segoe UI", 11F);
        labelHighScoreCount.Location = new Point(565, 448);
        labelHighScoreCount.Name = "labelHighScoreCount";
        labelHighScoreCount.Size = new Size(17, 20);
        labelHighScoreCount.TabIndex = 25;
        labelHighScoreCount.Text = "0";
        // 
        // labelWordsLeft
        // 
        labelWordsLeft.AutoSize = true;
        labelWordsLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelWordsLeft.Location = new Point(680, 412);
        labelWordsLeft.Name = "labelWordsLeft";
        labelWordsLeft.Size = new Size(78, 19);
        labelWordsLeft.TabIndex = 26;
        labelWordsLeft.Text = "Words left";
        // 
        // labelWordsLeftCount
        // 
        labelWordsLeftCount.AutoSize = true;
        labelWordsLeftCount.Font = new Font("Segoe UI", 11F);
        labelWordsLeftCount.Location = new Point(780, 412);
        labelWordsLeftCount.Name = "labelWordsLeftCount";
        labelWordsLeftCount.Size = new Size(17, 20);
        labelWordsLeftCount.TabIndex = 27;
        labelWordsLeftCount.Text = "0";
        // 
        // labelFailedAttempts
        // 
        labelFailedAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelFailedAttempts.AutoSize = true;
        labelFailedAttempts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelFailedAttempts.Location = new Point(907, 132);
        labelFailedAttempts.Name = "labelFailedAttempts";
        labelFailedAttempts.Size = new Size(118, 20);
        labelFailedAttempts.TabIndex = 28;
        labelFailedAttempts.Text = "Failed attempts";
        // 
        // textBoxFailedAttempts
        // 
        textBoxFailedAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        textBoxFailedAttempts.BackColor = Color.White;
        textBoxFailedAttempts.Font = new Font("Segoe UI", 10F);
        textBoxFailedAttempts.Location = new Point(907, 160);
        textBoxFailedAttempts.Multiline = true;
        textBoxFailedAttempts.Name = "textBoxFailedAttempts";
        textBoxFailedAttempts.ReadOnly = true;
        textBoxFailedAttempts.ScrollBars = ScrollBars.Vertical;
        textBoxFailedAttempts.Size = new Size(245, 346);
        textBoxFailedAttempts.TabIndex = 8;
        // 
        // labelStatus
        // 
        labelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelStatus.BackColor = Color.White;
        labelStatus.BorderStyle = BorderStyle.FixedSingle;
        labelStatus.Font = new Font("Segoe UI", 11F);
        labelStatus.ForeColor = Color.FromArgb(70, 70, 76);
        labelStatus.Location = new Point(53, 547);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(1099, 50);
        labelStatus.TabIndex = 30;
        labelStatus.Text = "Choose a difficulty and start playing.";
        labelStatus.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // countdownTimer
        // 
        countdownTimer.Interval = 1000;
        countdownTimer.Tick += CountdownTimerTick;
        // 
        // IndexForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 245, 247);
        ClientSize = new Size(1204, 626);
        Controls.Add(labelStatus);
        Controls.Add(textBoxFailedAttempts);
        Controls.Add(labelFailedAttempts);
        Controls.Add(labelWordsLeftCount);
        Controls.Add(labelWordsLeft);
        Controls.Add(labelHighScoreCount);
        Controls.Add(labelHighScore);
        Controls.Add(labelLivesCount);
        Controls.Add(labelLives);
        Controls.Add(labelStreakCount);
        Controls.Add(labelStreak);
        Controls.Add(labelScoreCount);
        Controls.Add(labelScore);
        Controls.Add(labelGuessedCount);
        Controls.Add(labelGuessed);
        Controls.Add(labelAttemptsCount);
        Controls.Add(labelAttempts);
        Controls.Add(buttonSkip);
        Controls.Add(buttonReshuffle);
        Controls.Add(buttonHint);
        Controls.Add(buttonCheck);
        Controls.Add(textBoxInput);
        Controls.Add(labelInput);
        Controls.Add(labelTimerCount);
        Controls.Add(labelTimer);
        Controls.Add(progressBarTimer);
        Controls.Add(labelScrambledWord);
        Controls.Add(labelScrambledCaption);
        Controls.Add(buttonNewGame);
        Controls.Add(comboBoxDifficulty);
        Controls.Add(labelDifficulty);
        Controls.Add(labelSubtitle);
        Controls.Add(labelTitle);
        MinimumSize = new Size(920, 620);
        Name = "IndexForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Word Scramble X";
        Load += IndexFormLoad;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Label labelSubtitle;
    private Label labelDifficulty;
    private ComboBox comboBoxDifficulty;
    private Button buttonNewGame;
    private Label labelScrambledCaption;
    private Label labelScrambledWord;
    private ProgressBar progressBarTimer;
    private Label labelTimer;
    private Label labelTimerCount;
    private Label labelInput;
    private TextBox textBoxInput;
    private Button buttonCheck;
    private Button buttonHint;
    private Button buttonReshuffle;
    private Button buttonSkip;
    private Label labelAttempts;
    private Label labelAttemptsCount;
    private Label labelGuessed;
    private Label labelGuessedCount;
    private Label labelScore;
    private Label labelScoreCount;
    private Label labelStreak;
    private Label labelStreakCount;
    private Label labelLives;
    private Label labelLivesCount;
    private Label labelHighScore;
    private Label labelHighScoreCount;
    private Label labelWordsLeft;
    private Label labelWordsLeftCount;
    private Label labelFailedAttempts;
    private TextBox textBoxFailedAttempts;
    private Label labelStatus;
    private System.Windows.Forms.Timer countdownTimer;
}
