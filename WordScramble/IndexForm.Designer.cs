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
        labelScrambledCaption = new Label();
        labelScrambledWord = new Label();
        labelInput = new Label();
        textBoxInput = new TextBox();
        buttonCheck = new Button();
        buttonSkip = new Button();
        buttonHint = new Button();
        labelAttempts = new Label();
        labelAttemptsCount = new Label();
        labelGuessed = new Label();
        labelGuessedCount = new Label();
        labelScore = new Label();
        labelScoreCount = new Label();
        labelFailedAttempts = new Label();
        textBoxFailedAttempts = new TextBox();
        labelStatus = new Label();
        labelTimer = new Label();
        labelTimerCount = new Label();
        countdownTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Anchor = AnchorStyles.Top;
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(31, 78, 121);
        labelTitle.Location = new Point(617, 28);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(312, 54);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Word Scramble";
        // 
        // labelScrambledCaption
        // 
        labelScrambledCaption.AutoSize = true;
        labelScrambledCaption.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelScrambledCaption.Location = new Point(62, 111);
        labelScrambledCaption.Name = "labelScrambledCaption";
        labelScrambledCaption.Size = new Size(158, 25);
        labelScrambledCaption.TabIndex = 1;
        labelScrambledCaption.Text = "Scrambled word";
        // 
        // labelScrambledWord
        // 
        labelScrambledWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelScrambledWord.BackColor = Color.White;
        labelScrambledWord.BorderStyle = BorderStyle.FixedSingle;
        labelScrambledWord.Font = new Font("Consolas", 28F, FontStyle.Bold);
        labelScrambledWord.ForeColor = Color.FromArgb(40, 40, 40);
        labelScrambledWord.Location = new Point(62, 139);
        labelScrambledWord.Name = "labelScrambledWord";
        labelScrambledWord.Size = new Size(1380, 70);
        labelScrambledWord.TabIndex = 2;
        labelScrambledWord.Text = "loading";
        labelScrambledWord.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelInput
        // 
        labelInput.AutoSize = true;
        labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelInput.Location = new Point(62, 237);
        labelInput.Name = "labelInput";
        labelInput.Size = new Size(94, 23);
        labelInput.TabIndex = 3;
        labelInput.Text = "Your guess";
        // 
        // textBoxInput
        // 
        textBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBoxInput.Font = new Font("Segoe UI", 14F);
        textBoxInput.Location = new Point(62, 262);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(1143, 39);
        textBoxInput.TabIndex = 1;
        textBoxInput.KeyDown += TextBoxInputKeyDown;
        // 
        // buttonCheck
        // 
        buttonCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCheck.BackColor = Color.FromArgb(31, 78, 121);
        buttonCheck.FlatStyle = FlatStyle.Flat;
        buttonCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonCheck.ForeColor = Color.White;
        buttonCheck.Location = new Point(1225, 260);
        buttonCheck.Name = "buttonCheck";
        buttonCheck.Size = new Size(88, 36);
        buttonCheck.TabIndex = 2;
        buttonCheck.Text = "Check";
        buttonCheck.UseVisualStyleBackColor = false;
        buttonCheck.Click += ButtonCheckClick;
        // 
        // buttonSkip
        // 
        buttonSkip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonSkip.Location = new Point(1323, 260);
        buttonSkip.Name = "buttonSkip";
        buttonSkip.Size = new Size(56, 36);
        buttonSkip.TabIndex = 3;
        buttonSkip.Text = "Skip";
        buttonSkip.UseVisualStyleBackColor = true;
        buttonSkip.Click += ButtonSkipClick;
        // 
        // buttonHint
        // 
        buttonHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonHint.Location = new Point(1386, 260);
        buttonHint.Name = "buttonHint";
        buttonHint.Size = new Size(56, 36);
        buttonHint.TabIndex = 4;
        buttonHint.Text = "Hint";
        buttonHint.UseVisualStyleBackColor = true;
        buttonHint.Click += ButtonHintClick;
        // 
        // labelAttempts
        // 
        labelAttempts.AutoSize = true;
        labelAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelAttempts.Location = new Point(62, 328);
        labelAttempts.Name = "labelAttempts";
        labelAttempts.Size = new Size(86, 23);
        labelAttempts.TabIndex = 8;
        labelAttempts.Text = "Attempts";
        // 
        // labelAttemptsCount
        // 
        labelAttemptsCount.AutoSize = true;
        labelAttemptsCount.Font = new Font("Segoe UI", 11F);
        labelAttemptsCount.Location = new Point(152, 328);
        labelAttemptsCount.Name = "labelAttemptsCount";
        labelAttemptsCount.Size = new Size(22, 25);
        labelAttemptsCount.TabIndex = 9;
        labelAttemptsCount.Text = "0";
        // 
        // labelGuessed
        // 
        labelGuessed.AutoSize = true;
        labelGuessed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelGuessed.Location = new Point(62, 362);
        labelGuessed.Name = "labelGuessed";
        labelGuessed.Size = new Size(129, 23);
        labelGuessed.TabIndex = 10;
        labelGuessed.Text = "Guessed words";
        // 
        // labelGuessedCount
        // 
        labelGuessedCount.AutoSize = true;
        labelGuessedCount.Font = new Font("Segoe UI", 11F);
        labelGuessedCount.Location = new Point(184, 362);
        labelGuessedCount.Name = "labelGuessedCount";
        labelGuessedCount.Size = new Size(22, 25);
        labelGuessedCount.TabIndex = 11;
        labelGuessedCount.Text = "0";
        // 
        // labelScore
        // 
        labelScore.AutoSize = true;
        labelScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelScore.Location = new Point(62, 396);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(54, 23);
        labelScore.TabIndex = 12;
        labelScore.Text = "Score";
        // 
        // labelScoreCount
        // 
        labelScoreCount.AutoSize = true;
        labelScoreCount.Font = new Font("Segoe UI", 11F);
        labelScoreCount.Location = new Point(152, 396);
        labelScoreCount.Name = "labelScoreCount";
        labelScoreCount.Size = new Size(22, 25);
        labelScoreCount.TabIndex = 13;
        labelScoreCount.Text = "0";
        // 
        // labelFailedAttempts
        // 
        labelFailedAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        labelFailedAttempts.AutoSize = true;
        labelFailedAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelFailedAttempts.Location = new Point(1225, 328);
        labelFailedAttempts.Name = "labelFailedAttempts";
        labelFailedAttempts.Size = new Size(135, 23);
        labelFailedAttempts.TabIndex = 14;
        labelFailedAttempts.Text = "Failed attempts";
        // 
        // textBoxFailedAttempts
        // 
        textBoxFailedAttempts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        textBoxFailedAttempts.BackColor = Color.White;
        textBoxFailedAttempts.Font = new Font("Segoe UI", 10F);
        textBoxFailedAttempts.Location = new Point(1225, 354);
        textBoxFailedAttempts.Multiline = true;
        textBoxFailedAttempts.Name = "textBoxFailedAttempts";
        textBoxFailedAttempts.ReadOnly = true;
        textBoxFailedAttempts.ScrollBars = ScrollBars.Vertical;
        textBoxFailedAttempts.Size = new Size(217, 320);
        textBoxFailedAttempts.TabIndex = 5;
        // 
        // labelStatus
        // 
        labelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelStatus.Font = new Font("Segoe UI", 10F);
        labelStatus.ForeColor = Color.FromArgb(80, 80, 80);
        labelStatus.Location = new Point(62, 687);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(1380, 25);
        labelStatus.TabIndex = 16;
        labelStatus.Text = "Unscramble the word and press Check.";
        labelStatus.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelTimer
        // 
        labelTimer.AutoSize = true;
        labelTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelTimer.Location = new Point(62, 430);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new Size(54, 23);
        labelTimer.TabIndex = 17;
        labelTimer.Text = "Timer";
        // 
        // labelTimerCount
        // 
        labelTimerCount.AutoSize = true;
        labelTimerCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelTimerCount.ForeColor = Color.FromArgb(31, 78, 121);
        labelTimerCount.Location = new Point(152, 430);
        labelTimerCount.Name = "labelTimerCount";
        labelTimerCount.Size = new Size(36, 25);
        labelTimerCount.TabIndex = 18;
        labelTimerCount.Text = "30s";
        // 
        // countdownTimer
        // 
        countdownTimer.Interval = 1000;
        countdownTimer.Tick += CountdownTimerTick;
        // 
        // IndexForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(247, 249, 252);
        ClientSize = new Size(1504, 739);
        Controls.Add(labelTimerCount);
        Controls.Add(labelTimer);
        Controls.Add(labelStatus);
        Controls.Add(textBoxFailedAttempts);
        Controls.Add(labelFailedAttempts);
        Controls.Add(labelScoreCount);
        Controls.Add(labelScore);
        Controls.Add(labelGuessedCount);
        Controls.Add(labelGuessed);
        Controls.Add(labelAttemptsCount);
        Controls.Add(labelAttempts);
        Controls.Add(buttonHint);
        Controls.Add(buttonSkip);
        Controls.Add(buttonCheck);
        Controls.Add(textBoxInput);
        Controls.Add(labelInput);
        Controls.Add(labelScrambledWord);
        Controls.Add(labelScrambledCaption);
        Controls.Add(labelTitle);
        MinimumSize = new Size(760, 560);
        Name = "IndexForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Word Scramble";
        Load += IndexFormLoad;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Label labelScrambledCaption;
    private Label labelScrambledWord;
    private Label labelInput;
    private TextBox textBoxInput;
    private Button buttonCheck;
    private Button buttonSkip;
    private Button buttonHint;
    private Label labelAttempts;
    private Label labelAttemptsCount;
    private Label labelGuessed;
    private Label labelGuessedCount;
    private Label labelScore;
    private Label labelScoreCount;
    private Label labelFailedAttempts;
    private TextBox textBoxFailedAttempts;
    private Label labelStatus;
    private Label labelTimer;
    private Label labelTimerCount;
    private System.Windows.Forms.Timer countdownTimer;
}
