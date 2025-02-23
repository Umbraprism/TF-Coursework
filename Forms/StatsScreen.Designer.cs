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
            panel1 = new Panel();
            btnLeaderboard = new Button();
            lblStats = new Label();
            btnBack = new Button();
            pbPortrait = new PictureBox();
            pnlStats.SuspendLayout();
            pnlQuizStats.SuspendLayout();
            tlpQuizSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortrait).BeginInit();
            SuspendLayout();
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlQuizStats);
            pnlStats.Controls.Add(tlpQuizSelect);
            pnlStats.Controls.Add(lblOnlineRank);
            pnlStats.Controls.Add(lblTFClass);
            pnlStats.Controls.Add(lblUsername);
            pnlStats.Controls.Add(pbAvatar);
            pnlStats.Controls.Add(panel1);
            pnlStats.Dock = DockStyle.Left;
            pnlStats.Location = new Point(0, 0);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(893, 900);
            pnlStats.TabIndex = 0;
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
            lblQuizRank.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblLatestScore.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblHighestScore.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblQuizType.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizType.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizType.Location = new Point(19, 12);
            lblQuizType.Name = "lblQuizType";
            lblQuizType.Size = new Size(259, 65);
            lblQuizType.TabIndex = 3;
            lblQuizType.Text = "QUIZ QUIZ";
            // 
            // tlpQuizSelect
            // 
            tlpQuizSelect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            btnGuessingGame.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnHistoryQuiz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            bntTFClassQuiz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnWeaponsQuiz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblOnlineRank.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblTFClass.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblUsername.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 39);
            panel1.Controls.Add(btnLeaderboard);
            panel1.Controls.Add(lblStats);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 156);
            panel1.TabIndex = 0;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.FromArgb(115, 103, 91);
            btnLeaderboard.Dock = DockStyle.Right;
            btnLeaderboard.FlatAppearance.BorderSize = 0;
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblStats.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnBack.Font = new Font("Segoe UI", 95F, FontStyle.Regular, GraphicsUnit.Point);
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
            // StatsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(pbPortrait);
            Controls.Add(pnlStats);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsScreen";
            Text = "StatsScreen";
            WindowState = FormWindowState.Maximized;
            Load += StatsScreen_Load;
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
            pnlQuizStats.ResumeLayout(false);
            pnlQuizStats.PerformLayout();
            tlpQuizSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortrait).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStats;
        private Panel panel1;
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
    }
}