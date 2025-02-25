namespace Coursework.Forms
{
    partial class GuessingGameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessingGameScreen));
            pnlHeader = new Panel();
            lblTimeRemaining = new Label();
            lblScore = new Label();
            lblScorePrefix = new Label();
            lblTimeRemainingPrefix = new Label();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblQuizName = new Label();
            rpnlImageBox = new UserControls.RoundedPanel();
            pbImage = new PictureBox();
            rpnlGuessInput = new UserControls.RoundedPanel();
            tbGuess = new TextBox();
            lblGuessesUntilImage = new Label();
            tlpGuesses = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            rpnlImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            rpnlGuessInput.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(lblTimeRemaining);
            pnlHeader.Controls.Add(lblScore);
            pnlHeader.Controls.Add(lblScorePrefix);
            pnlHeader.Controls.Add(lblTimeRemainingPrefix);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblQuizName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 2;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.Font = new Font("Segoe UI", 24F);
            lblTimeRemaining.ForeColor = Color.FromArgb(246, 231, 222);
            lblTimeRemaining.Location = new Point(2889, 23);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(84, 45);
            lblTimeRemaining.TabIndex = 6;
            lblTimeRemaining.Text = "time";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 24F);
            lblScore.ForeColor = Color.FromArgb(246, 231, 222);
            lblScore.Location = new Point(2889, 98);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(96, 45);
            lblScore.TabIndex = 5;
            lblScore.Text = "score";
            // 
            // lblScorePrefix
            // 
            lblScorePrefix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScorePrefix.AutoSize = true;
            lblScorePrefix.Font = new Font("Segoe UI", 24F);
            lblScorePrefix.ForeColor = Color.FromArgb(246, 231, 222);
            lblScorePrefix.Location = new Point(2403, 98);
            lblScorePrefix.Name = "lblScorePrefix";
            lblScorePrefix.Size = new Size(99, 45);
            lblScorePrefix.TabIndex = 4;
            lblScorePrefix.Text = "Score";
            // 
            // lblTimeRemainingPrefix
            // 
            lblTimeRemainingPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimeRemainingPrefix.AutoSize = true;
            lblTimeRemainingPrefix.Font = new Font("Segoe UI", 24F);
            lblTimeRemainingPrefix.ForeColor = Color.FromArgb(246, 231, 222);
            lblTimeRemainingPrefix.Location = new Point(2403, 23);
            lblTimeRemainingPrefix.Name = "lblTimeRemainingPrefix";
            lblTimeRemainingPrefix.Size = new Size(249, 45);
            lblTimeRemainingPrefix.TabIndex = 3;
            lblTimeRemainingPrefix.Text = "Time Remaining";
            // 
            // ppbAchievementProgress
            // 
            ppbAchievementProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ppbAchievementProgress.BackColor = Color.FromArgb(26, 26, 26);
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F);
            ppbAchievementProgress.Location = new Point(3767, 34);
            ppbAchievementProgress.Name = "ppbAchievementProgress";
            ppbAchievementProgress.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.Size = new Size(621, 86);
            ppbAchievementProgress.Style = ProgressBarStyle.Continuous;
            ppbAchievementProgress.TabIndex = 2;
            ppbAchievementProgress.Text = "PERCENTAGE";
            ppbAchievementProgress.TextColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.UsePercentage = true;
            // 
            // lblQuizName
            // 
            lblQuizName.Anchor = AnchorStyles.Left;
            lblQuizName.AutoSize = true;
            lblQuizName.Font = new Font("Segoe UI", 48F);
            lblQuizName.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizName.Location = new Point(12, 40);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(526, 86);
            lblQuizName.TabIndex = 1;
            lblQuizName.Text = "GUESSING GAME";
            // 
            // rpnlImageBox
            // 
            rpnlImageBox.Anchor = AnchorStyles.Top;
            rpnlImageBox.BorderColour = Color.FromArgb(45, 41, 39);
            rpnlImageBox.BorderSize = 0;
            rpnlImageBox.Controls.Add(pbImage);
            rpnlImageBox.Location = new Point(587, 210);
            rpnlImageBox.Name = "rpnlImageBox";
            rpnlImageBox.PanelColour = Color.FromArgb(45, 41, 39);
            rpnlImageBox.Radius = 50;
            rpnlImageBox.Size = new Size(462, 304);
            rpnlImageBox.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlImageBox.TabIndex = 6;
            // 
            // pbImage
            // 
            pbImage.Anchor = AnchorStyles.None;
            pbImage.BackColor = Color.FromArgb(45, 41, 39);
            pbImage.Image = Properties.Resources.questionMark;
            pbImage.Location = new Point(7, 14);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(448, 278);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // rpnlGuessInput
            // 
            rpnlGuessInput.BorderColour = Color.White;
            rpnlGuessInput.BorderSize = 0;
            rpnlGuessInput.Controls.Add(tbGuess);
            rpnlGuessInput.Location = new Point(587, 566);
            rpnlGuessInput.Name = "rpnlGuessInput";
            rpnlGuessInput.PanelColour = Color.White;
            rpnlGuessInput.Radius = 30;
            rpnlGuessInput.Size = new Size(462, 59);
            rpnlGuessInput.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlGuessInput.TabIndex = 7;
            // 
            // tbGuess
            // 
            tbGuess.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGuess.Location = new Point(7, 3);
            tbGuess.Name = "tbGuess";
            tbGuess.PlaceholderText = "Guess...";
            tbGuess.Size = new Size(448, 54);
            tbGuess.TabIndex = 10;
            tbGuess.KeyDown += tbGuess_KeyDown;
            // 
            // lblGuessesUntilImage
            // 
            lblGuessesUntilImage.AutoSize = true;
            lblGuessesUntilImage.ForeColor = Color.FromArgb(246, 231, 222);
            lblGuessesUntilImage.Location = new Point(587, 517);
            lblGuessesUntilImage.Name = "lblGuessesUntilImage";
            lblGuessesUntilImage.Size = new Size(298, 15);
            lblGuessesUntilImage.TabIndex = 9;
            lblGuessesUntilImage.Text = "Weapon image will be fully revealed in n more guesses.";
            // 
            // tlpGuesses
            // 
            tlpGuesses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpGuesses.AutoScroll = true;
            tlpGuesses.ColumnCount = 1;
            tlpGuesses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGuesses.Location = new Point(0, 631);
            tlpGuesses.Name = "tlpGuesses";
            tlpGuesses.RowCount = 1;
            tlpGuesses.RowStyles.Add(new RowStyle());
            tlpGuesses.Size = new Size(1600, 297);
            tlpGuesses.TabIndex = 10;
            // 
            // GuessingGameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(tlpGuesses);
            Controls.Add(lblGuessesUntilImage);
            Controls.Add(rpnlGuessInput);
            Controls.Add(rpnlImageBox);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GuessingGameScreen";
            Text = "GuessingGameScreen";
            WindowState = FormWindowState.Maximized;
            Load += GuessingGameScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            rpnlImageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            rpnlGuessInput.ResumeLayout(false);
            rpnlGuessInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTimeRemaining;
        private Label lblScore;
        private Label lblScorePrefix;
        private Label lblTimeRemainingPrefix;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblQuizName;
        private UserControls.RoundedPanel rpnlImageBox;
        private PictureBox pbImage;
        private UserControls.RoundedPanel rpnlGuessInput;
        private Label lblGuessesUntilImage;
        private TextBox tbGuess;
        private TableLayoutPanel tlpGuesses;
    }
}