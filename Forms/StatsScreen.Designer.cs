namespace Coursework.Forms
{
    partial class StatsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsScreen));
            pnlStats = new Panel();
            pnlGuessingGame = new Panel();
            lblCurrentStreak = new Label();
            lblHighestStreak = new Label();
            lblLatestGuesses = new Label();
            lblLowestGuesses = new Label();
            lblGuessingGame = new Label();
            pnlQuizStats = new Panel();
            lblQuizRank = new Label();
            lblLatestScore = new Label();
            lblHighestScore = new Label();
            lblQuizType = new Label();
            tlpQuizSelect = new TableLayoutPanel();
            btnGuessingGame = new Button();
            btnHistoryQuiz = new Button();
            bntTFClassQuiz = new Button();
            btnWeaponsQuiz = new Button();
            lblOnlineRank = new Label();
            lblTFClass = new Label();
            lblUsername = new Label();
            pbAvatar = new PictureBox();
            pnlHeader = new Panel();
            btnLeaderboard = new Button();
            lblStats = new Label();
            btnBack = new Button();
            pbPortrait = new PictureBox();
            btnAbilityInfo = new Button();
            pnlStats.SuspendLayout();
            pnlGuessingGame.SuspendLayout();
            pnlQuizStats.SuspendLayout();
            tlpQuizSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortrait).BeginInit();
            SuspendLayout();
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlGuessingGame);
            pnlStats.Controls.Add(pnlQuizStats);
            pnlStats.Controls.Add(tlpQuizSelect);
            pnlStats.Controls.Add(lblOnlineRank);
            pnlStats.Controls.Add(lblTFClass);
            pnlStats.Controls.Add(lblUsername);
            pnlStats.Controls.Add(pbAvatar);
            pnlStats.Controls.Add(pnlHeader);
            pnlStats.Dock = DockStyle.Left;
            pnlStats.Location = new Point(0, 0);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(893, 900);
            pnlStats.TabIndex = 0;
            // 
            // pnlGuessingGame
            // 
            pnlGuessingGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGuessingGame.Controls.Add(lblCurrentStreak);
            pnlGuessingGame.Controls.Add(lblHighestStreak);
            pnlGuessingGame.Controls.Add(lblLatestGuesses);
            pnlGuessingGame.Controls.Add(lblLowestGuesses);
            pnlGuessingGame.Controls.Add(lblGuessingGame);
            pnlGuessingGame.Location = new Point(0, 592);
            pnlGuessingGame.Name = "pnlGuessingGame";
            pnlGuessingGame.Size = new Size(893, 306);
            pnlGuessingGame.TabIndex = 7;
            pnlGuessingGame.Visible = false;
            // 
            // lblCurrentStreak
            // 
            lblCurrentStreak.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCurrentStreak.AutoSize = true;
            lblCurrentStreak.Font = new Font("Segoe UI", 26.25F);
            lblCurrentStreak.ForeColor = Color.FromArgb(246, 231, 222);
            lblCurrentStreak.Location = new Point(19, 250);
            lblCurrentStreak.Name = "lblCurrentStreak";
            lblCurrentStreak.Size = new Size(295, 47);
            lblCurrentStreak.TabIndex = 7;
            lblCurrentStreak.Text = "Current Streak - n";
            // 
            // lblHighestStreak
            // 
            lblHighestStreak.Anchor = AnchorStyles.Left;
            lblHighestStreak.AutoSize = true;
            lblHighestStreak.Font = new Font("Segoe UI", 26.25F);
            lblHighestStreak.ForeColor = Color.FromArgb(246, 231, 222);
            lblHighestStreak.Location = new Point(19, 196);
            lblHighestStreak.Name = "lblHighestStreak";
            lblHighestStreak.Size = new Size(298, 47);
            lblHighestStreak.TabIndex = 6;
            lblHighestStreak.Text = "Highest Streak - n";
            // 
            // lblLatestGuesses
            // 
            lblLatestGuesses.Anchor = AnchorStyles.Left;
            lblLatestGuesses.AutoSize = true;
            lblLatestGuesses.Font = new Font("Segoe UI", 26.25F);
            lblLatestGuesses.ForeColor = Color.FromArgb(246, 231, 222);
            lblLatestGuesses.Location = new Point(19, 138);
            lblLatestGuesses.Name = "lblLatestGuesses";
            lblLatestGuesses.Size = new Size(300, 47);
            lblLatestGuesses.TabIndex = 5;
            lblLatestGuesses.Text = "Latest Guesses - n";
            // 
            // lblLowestGuesses
            // 
            lblLowestGuesses.AutoSize = true;
            lblLowestGuesses.Font = new Font("Segoe UI", 26.25F);
            lblLowestGuesses.ForeColor = Color.FromArgb(246, 231, 222);
            lblLowestGuesses.Location = new Point(19, 80);
            lblLowestGuesses.Name = "lblLowestGuesses";
            lblLowestGuesses.Size = new Size(316, 47);
            lblLowestGuesses.TabIndex = 4;
            lblLowestGuesses.Text = "Lowest Guesses - n";
            // 
            // lblGuessingGame
            // 
            lblGuessingGame.AutoSize = true;
            lblGuessingGame.Font = new Font("Segoe UI", 36F);
            lblGuessingGame.ForeColor = Color.FromArgb(246, 231, 222);
            lblGuessingGame.Location = new Point(19, 12);
            lblGuessingGame.Name = "lblGuessingGame";
            lblGuessingGame.Size = new Size(396, 65);
            lblGuessingGame.TabIndex = 3;
            lblGuessingGame.Text = "GUESSING GAME";
            // 
            // pnlQuizStats
            // 
            pnlQuizStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlQuizStats.Controls.Add(lblQuizRank);
            pnlQuizStats.Controls.Add(lblLatestScore);
            pnlQuizStats.Controls.Add(lblHighestScore);
            pnlQuizStats.Controls.Add(lblQuizType);
            pnlQuizStats.Location = new Point(0, 594);
            pnlQuizStats.Name = "pnlQuizStats";
            pnlQuizStats.Size = new Size(893, 306);
            pnlQuizStats.TabIndex = 6;
            pnlQuizStats.Visible = false;
            // 
            // lblQuizRank
            // 
            lblQuizRank.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQuizRank.AutoSize = true;
            lblQuizRank.Font = new Font("Segoe UI", 26.25F);
            lblQuizRank.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizRank.Location = new Point(19, 237);
            lblQuizRank.Name = "lblQuizRank";
            lblQuizRank.Size = new Size(176, 47);
            lblQuizRank.TabIndex = 6;
            lblQuizRank.Text = "Quiz Rank";
            // 
            // lblLatestScore
            // 
            lblLatestScore.Anchor = AnchorStyles.Left;
            lblLatestScore.AutoSize = true;
            lblLatestScore.Font = new Font("Segoe UI", 26.25F);
            lblLatestScore.ForeColor = Color.FromArgb(246, 231, 222);
            lblLatestScore.Location = new Point(19, 167);
            lblLatestScore.Name = "lblLatestScore";
            lblLatestScore.Size = new Size(261, 47);
            lblLatestScore.TabIndex = 5;
            lblLatestScore.Text = "Latest Score - n";
            // 
            // lblHighestScore
            // 
            lblHighestScore.AutoSize = true;
            lblHighestScore.Font = new Font("Segoe UI", 26.25F);
            lblHighestScore.ForeColor = Color.FromArgb(246, 231, 222);
            lblHighestScore.Location = new Point(19, 98);
            lblHighestScore.Name = "lblHighestScore";
            lblHighestScore.Size = new Size(289, 47);
            lblHighestScore.TabIndex = 4;
            lblHighestScore.Text = "Highest Score - n";
            // 
            // lblQuizType
            // 
            lblQuizType.AutoSize = true;
            lblQuizType.Font = new Font("Segoe UI", 36F);
            lblQuizType.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizType.Location = new Point(19, 12);
            lblQuizType.Name = "lblQuizType";
            lblQuizType.Size = new Size(259, 65);
            lblQuizType.TabIndex = 3;
            lblQuizType.Text = "QUIZ QUIZ";
            // 
            // tlpQuizSelect
            // 
            tlpQuizSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpQuizSelect.ColumnCount = 4;
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpQuizSelect.Controls.Add(btnGuessingGame, 3, 0);
            tlpQuizSelect.Controls.Add(btnHistoryQuiz, 2, 0);
            tlpQuizSelect.Controls.Add(bntTFClassQuiz, 1, 0);
            tlpQuizSelect.Controls.Add(btnWeaponsQuiz, 0, 0);
            tlpQuizSelect.Location = new Point(0, 455);
            tlpQuizSelect.Name = "tlpQuizSelect";
            tlpQuizSelect.RowCount = 1;
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuizSelect.Size = new Size(890, 133);
            tlpQuizSelect.TabIndex = 5;
            // 
            // btnGuessingGame
            // 
            btnGuessingGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGuessingGame.BackColor = Color.FromArgb(189, 59, 59);
            btnGuessingGame.FlatAppearance.BorderSize = 0;
            btnGuessingGame.FlatStyle = FlatStyle.Flat;
            btnGuessingGame.Font = new Font("Segoe UI", 24F);
            btnGuessingGame.ForeColor = Color.FromArgb(246, 231, 222);
            btnGuessingGame.Location = new Point(686, 3);
            btnGuessingGame.Name = "btnGuessingGame";
            btnGuessingGame.Size = new Size(183, 127);
            btnGuessingGame.TabIndex = 10;
            btnGuessingGame.Tag = "GuessingGame";
            btnGuessingGame.Text = "GUESSING";
            btnGuessingGame.UseVisualStyleBackColor = false;
            btnGuessingGame.Click += btnQuiz_Click;
            // 
            // btnHistoryQuiz
            // 
            btnHistoryQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnHistoryQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnHistoryQuiz.FlatAppearance.BorderSize = 0;
            btnHistoryQuiz.FlatStyle = FlatStyle.Flat;
            btnHistoryQuiz.Font = new Font("Segoe UI", 24F);
            btnHistoryQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnHistoryQuiz.Location = new Point(463, 3);
            btnHistoryQuiz.Name = "btnHistoryQuiz";
            btnHistoryQuiz.Size = new Size(183, 127);
            btnHistoryQuiz.TabIndex = 9;
            btnHistoryQuiz.Tag = "History";
            btnHistoryQuiz.Text = "HISTORY";
            btnHistoryQuiz.UseVisualStyleBackColor = false;
            btnHistoryQuiz.Click += btnQuiz_Click;
            // 
            // bntTFClassQuiz
            // 
            bntTFClassQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bntTFClassQuiz.BackColor = Color.FromArgb(189, 59, 59);
            bntTFClassQuiz.FlatAppearance.BorderSize = 0;
            bntTFClassQuiz.FlatStyle = FlatStyle.Flat;
            bntTFClassQuiz.Font = new Font("Segoe UI", 24F);
            bntTFClassQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            bntTFClassQuiz.Location = new Point(241, 3);
            bntTFClassQuiz.Name = "bntTFClassQuiz";
            bntTFClassQuiz.Size = new Size(183, 127);
            bntTFClassQuiz.TabIndex = 8;
            bntTFClassQuiz.Tag = "TFClass";
            bntTFClassQuiz.Text = "CLASSES";
            bntTFClassQuiz.UseVisualStyleBackColor = false;
            bntTFClassQuiz.Click += btnQuiz_Click;
            // 
            // btnWeaponsQuiz
            // 
            btnWeaponsQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnWeaponsQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnWeaponsQuiz.FlatAppearance.BorderSize = 0;
            btnWeaponsQuiz.FlatStyle = FlatStyle.Flat;
            btnWeaponsQuiz.Font = new Font("Segoe UI", 24F);
            btnWeaponsQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnWeaponsQuiz.Location = new Point(19, 3);
            btnWeaponsQuiz.Name = "btnWeaponsQuiz";
            btnWeaponsQuiz.Size = new Size(183, 127);
            btnWeaponsQuiz.TabIndex = 7;
            btnWeaponsQuiz.Tag = "Weapons";
            btnWeaponsQuiz.Text = "WEAPONS";
            btnWeaponsQuiz.UseVisualStyleBackColor = false;
            btnWeaponsQuiz.Click += btnQuiz_Click;
            // 
            // lblOnlineRank
            // 
            lblOnlineRank.AutoSize = true;
            lblOnlineRank.Font = new Font("Segoe UI", 36F);
            lblOnlineRank.ForeColor = Color.FromArgb(246, 231, 222);
            lblOnlineRank.Location = new Point(272, 349);
            lblOnlineRank.Name = "lblOnlineRank";
            lblOnlineRank.Size = new Size(152, 65);
            lblOnlineRank.TabIndex = 4;
            lblOnlineRank.Text = "RANK";
            // 
            // lblTFClass
            // 
            lblTFClass.AutoSize = true;
            lblTFClass.Font = new Font("Segoe UI", 36F);
            lblTFClass.ForeColor = Color.FromArgb(246, 231, 222);
            lblTFClass.Location = new Point(272, 271);
            lblTFClass.Name = "lblTFClass";
            lblTFClass.Size = new Size(302, 65);
            lblTFClass.TabIndex = 3;
            lblTFClass.Text = "The %Class%";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 36F);
            lblUsername.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsername.Location = new Point(272, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(352, 65);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "%USERNAME%";
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.FromArgb(19, 17, 11);
            pbAvatar.Location = new Point(40, 189);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(226, 226);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 1;
            pbAvatar.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(btnLeaderboard);
            pnlHeader.Controls.Add(lblStats);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(893, 156);
            pnlHeader.TabIndex = 0;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.FromArgb(115, 103, 91);
            btnLeaderboard.Dock = DockStyle.Right;
            btnLeaderboard.FlatAppearance.BorderSize = 0;
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.Font = new Font("Segoe UI", 24F);
            btnLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            btnLeaderboard.Location = new Point(618, 0);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(275, 156);
            btnLeaderboard.TabIndex = 3;
            btnLeaderboard.Text = "LEADERBOARD";
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // lblStats
            // 
            lblStats.Anchor = AnchorStyles.Left;
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 48F);
            lblStats.ForeColor = Color.FromArgb(246, 231, 222);
            lblStats.Location = new Point(198, 43);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(204, 86);
            lblStats.TabIndex = 2;
            lblStats.Text = "STATS";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(189, 59, 59);
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 95F);
            btnBack.ForeColor = Color.FromArgb(246, 231, 222);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 156);
            btnBack.TabIndex = 1;
            btnBack.Text = "❰";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pbPortrait
            // 
            pbPortrait.BackColor = Color.Transparent;
            pbPortrait.Dock = DockStyle.Fill;
            pbPortrait.Location = new Point(893, 0);
            pbPortrait.Name = "pbPortrait";
            pbPortrait.Size = new Size(707, 900);
            pbPortrait.TabIndex = 1;
            pbPortrait.TabStop = false;
            // 
            // btnAbilityInfo
            // 
            btnAbilityInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbilityInfo.BackColor = Color.FromArgb(189, 59, 59);
            btnAbilityInfo.FlatAppearance.BorderSize = 0;
            btnAbilityInfo.FlatStyle = FlatStyle.Flat;
            btnAbilityInfo.Font = new Font("Segoe UI", 42F);
            btnAbilityInfo.ForeColor = Color.FromArgb(246, 231, 222);
            btnAbilityInfo.Location = new Point(1488, 788);
            btnAbilityInfo.Name = "btnAbilityInfo";
            btnAbilityInfo.Size = new Size(100, 100);
            btnAbilityInfo.TabIndex = 2;
            btnAbilityInfo.Text = "i";
            btnAbilityInfo.UseVisualStyleBackColor = false;
            btnAbilityInfo.Click += btnAbilityInfo_Click;
            // 
            // StatsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(btnAbilityInfo);
            Controls.Add(pbPortrait);
            Controls.Add(pnlStats);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsScreen";
            Text = "Stats";
            WindowState = FormWindowState.Maximized;
            Load += StatsScreen_Load;
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
            pnlGuessingGame.ResumeLayout(false);
            pnlGuessingGame.PerformLayout();
            pnlQuizStats.ResumeLayout(false);
            pnlQuizStats.PerformLayout();
            tlpQuizSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortrait).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStats;
        private Panel pnlHeader;
        private Button btnBack;
        private Button btnLeaderboard;
        private Label lblStats;
        private PictureBox pbAvatar;
        private Label lblUsername;
        private Label lblTFClass;
        private Label lblOnlineRank;
        private Panel pnlQuizStats;
        private TableLayoutPanel tlpQuizSelect;
        private Button btnGuessingGame;
        private Button btnHistoryQuiz;
        private Button bntTFClassQuiz;
        private Button btnWeaponsQuiz;
        private Label lblQuizType;
        private Label lblQuizRank;
        private Label lblLatestScore;
        private Label lblHighestScore;
        private PictureBox pbPortrait;
        private Panel pnlGuessingGame;
        //private Label label1;
        private Label lblLatestGuesses;
        private Label lblLowestGuesses;
        private Label lblGuessingGame;
        private Label lblCurrentStreak;
        private Label lblHighestStreak;
        private Button btnAbilityInfo;
    }
}