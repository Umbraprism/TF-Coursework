namespace Coursework.Forms
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            pnlMain = new Panel();
            tlpStatistics = new TableLayoutPanel();
            btnStats = new Button();
            btnAchievements = new Button();
            tlpQuizSelect = new TableLayoutPanel();
            btnWeaponsQuiz = new Button();
            btnTFClassQuiz = new Button();
            btnGuessingGame = new Button();
            btnHistoryQuiz = new Button();
            pbLogo = new PictureBox();
            pnlDetail = new Panel();
            pnlUser = new Panel();
            lblClass = new Label();
            lblHighestScore = new Label();
            lblAchievementCount = new Label();
            lblUsername = new Label();
            pbPfp = new PictureBox();
            btnQuit = new Button();
            pnlTip = new Panel();
            btnNextTip = new Button();
            lblTipText = new Label();
            lblTip = new Label();
            pnlOnline = new Panel();
            ppbToNextOnlineRank = new UserControls.PercentageProgressBar();
            btnHostOrJoin = new Button();
            lblOnlineRank = new Label();
            pnlMain.SuspendLayout();
            tlpStatistics.SuspendLayout();
            tlpQuizSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlDetail.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPfp).BeginInit();
            pnlTip.SuspendLayout();
            pnlOnline.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(53, 48, 46);
            pnlMain.Controls.Add(tlpStatistics);
            pnlMain.Controls.Add(tlpQuizSelect);
            pnlMain.Controls.Add(pbLogo);
            pnlMain.Dock = DockStyle.Left;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(535, 900);
            pnlMain.TabIndex = 0;
            // 
            // tlpStatistics
            // 
            tlpStatistics.Anchor = AnchorStyles.Bottom;
            tlpStatistics.ColumnCount = 2;
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStatistics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStatistics.Controls.Add(btnStats, 1, 0);
            tlpStatistics.Controls.Add(btnAchievements, 0, 0);
            tlpStatistics.Location = new Point(12, 777);
            tlpStatistics.Name = "tlpStatistics";
            tlpStatistics.RowCount = 1;
            tlpStatistics.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStatistics.Size = new Size(512, 111);
            tlpStatistics.TabIndex = 13;
            // 
            // btnStats
            // 
            btnStats.BackColor = Color.FromArgb(189, 59, 59);
            btnStats.Dock = DockStyle.Fill;
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Segoe UI", 24F);
            btnStats.ForeColor = Color.FromArgb(246, 231, 222);
            btnStats.Location = new Point(259, 3);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(250, 105);
            btnStats.TabIndex = 11;
            btnStats.Text = "STATS";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // btnAchievements
            // 
            btnAchievements.BackColor = Color.FromArgb(189, 59, 59);
            btnAchievements.Dock = DockStyle.Fill;
            btnAchievements.FlatAppearance.BorderSize = 0;
            btnAchievements.FlatStyle = FlatStyle.Flat;
            btnAchievements.Font = new Font("Segoe UI", 20.25F);
            btnAchievements.ForeColor = Color.FromArgb(246, 231, 222);
            btnAchievements.Location = new Point(3, 3);
            btnAchievements.Name = "btnAchievements";
            btnAchievements.Size = new Size(250, 105);
            btnAchievements.TabIndex = 10;
            btnAchievements.Text = "ACHIEVEMENTS";
            btnAchievements.UseVisualStyleBackColor = false;
            btnAchievements.Click += btnAchievements_Click;
            // 
            // tlpQuizSelect
            // 
            tlpQuizSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tlpQuizSelect.ColumnCount = 1;
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuizSelect.Controls.Add(btnWeaponsQuiz, 0, 0);
            tlpQuizSelect.Controls.Add(btnTFClassQuiz, 0, 1);
            tlpQuizSelect.Controls.Add(btnGuessingGame, 0, 3);
            tlpQuizSelect.Controls.Add(btnHistoryQuiz, 0, 2);
            tlpQuizSelect.Location = new Point(12, 150);
            tlpQuizSelect.Name = "tlpQuizSelect";
            tlpQuizSelect.RowCount = 4;
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.Size = new Size(512, 621);
            tlpQuizSelect.TabIndex = 12;
            // 
            // btnWeaponsQuiz
            // 
            btnWeaponsQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnWeaponsQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnWeaponsQuiz.FlatAppearance.BorderSize = 0;
            btnWeaponsQuiz.FlatStyle = FlatStyle.Flat;
            btnWeaponsQuiz.Font = new Font("Segoe UI", 36F);
            btnWeaponsQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnWeaponsQuiz.Location = new Point(3, 3);
            btnWeaponsQuiz.Name = "btnWeaponsQuiz";
            btnWeaponsQuiz.Size = new Size(506, 149);
            btnWeaponsQuiz.TabIndex = 6;
            btnWeaponsQuiz.Tag = "Weapons";
            btnWeaponsQuiz.Text = "WEAPONS";
            btnWeaponsQuiz.UseVisualStyleBackColor = false;
            btnWeaponsQuiz.Click += btnQuiz_Click;
            // 
            // btnTFClassQuiz
            // 
            btnTFClassQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTFClassQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnTFClassQuiz.FlatAppearance.BorderSize = 0;
            btnTFClassQuiz.FlatStyle = FlatStyle.Flat;
            btnTFClassQuiz.Font = new Font("Segoe UI", 36F);
            btnTFClassQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnTFClassQuiz.Location = new Point(3, 158);
            btnTFClassQuiz.Name = "btnTFClassQuiz";
            btnTFClassQuiz.Size = new Size(506, 149);
            btnTFClassQuiz.TabIndex = 7;
            btnTFClassQuiz.Tag = "TFClass";
            btnTFClassQuiz.Text = "CLASSES";
            btnTFClassQuiz.UseVisualStyleBackColor = false;
            btnTFClassQuiz.Click += btnQuiz_Click;
            // 
            // btnGuessingGame
            // 
            btnGuessingGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGuessingGame.BackColor = Color.FromArgb(189, 59, 59);
            btnGuessingGame.FlatAppearance.BorderSize = 0;
            btnGuessingGame.FlatStyle = FlatStyle.Flat;
            btnGuessingGame.Font = new Font("Segoe UI", 36F);
            btnGuessingGame.ForeColor = Color.FromArgb(246, 231, 222);
            btnGuessingGame.Location = new Point(3, 468);
            btnGuessingGame.Name = "btnGuessingGame";
            btnGuessingGame.Size = new Size(506, 150);
            btnGuessingGame.TabIndex = 9;
            btnGuessingGame.Text = "GUESSING GAME";
            btnGuessingGame.UseVisualStyleBackColor = false;
            btnGuessingGame.Click += btnGuessingGame_Click;
            // 
            // btnHistoryQuiz
            // 
            btnHistoryQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnHistoryQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnHistoryQuiz.FlatAppearance.BorderSize = 0;
            btnHistoryQuiz.FlatStyle = FlatStyle.Flat;
            btnHistoryQuiz.Font = new Font("Segoe UI", 36F);
            btnHistoryQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnHistoryQuiz.Location = new Point(3, 313);
            btnHistoryQuiz.Name = "btnHistoryQuiz";
            btnHistoryQuiz.Size = new Size(506, 149);
            btnHistoryQuiz.TabIndex = 8;
            btnHistoryQuiz.Tag = "History";
            btnHistoryQuiz.Text = "HISTORY";
            btnHistoryQuiz.UseVisualStyleBackColor = false;
            btnHistoryQuiz.Click += btnQuiz_Click;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.Image = Properties.Resources.tfLogo;
            pbLogo.Location = new Point(4, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(526, 144);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.FromArgb(45, 41, 39);
            pnlDetail.Controls.Add(pnlUser);
            pnlDetail.Controls.Add(btnQuit);
            pnlDetail.Controls.Add(pnlTip);
            pnlDetail.Dock = DockStyle.Top;
            pnlDetail.Location = new Point(535, 0);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(1065, 144);
            pnlDetail.TabIndex = 1;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.FromArgb(41, 39, 39);
            pnlUser.Controls.Add(lblClass);
            pnlUser.Controls.Add(lblHighestScore);
            pnlUser.Controls.Add(lblAchievementCount);
            pnlUser.Controls.Add(lblUsername);
            pnlUser.Controls.Add(pbPfp);
            pnlUser.Dock = DockStyle.Right;
            pnlUser.Location = new Point(472, 0);
            pnlUser.MaximumSize = new Size(549, 144);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(449, 144);
            pnlUser.TabIndex = 1;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 12F);
            lblClass.ForeColor = Color.FromArgb(246, 231, 222);
            lblClass.Location = new Point(133, 104);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(63, 21);
            lblClass.TabIndex = 4;
            lblClass.Text = "lblClass";
            // 
            // lblHighestScore
            // 
            lblHighestScore.AutoSize = true;
            lblHighestScore.Font = new Font("Segoe UI", 12F);
            lblHighestScore.ForeColor = Color.FromArgb(246, 231, 222);
            lblHighestScore.Location = new Point(133, 76);
            lblHighestScore.Name = "lblHighestScore";
            lblHighestScore.Size = new Size(119, 21);
            lblHighestScore.TabIndex = 3;
            lblHighestScore.Text = "lblHighestScore";
            // 
            // lblAchievementCount
            // 
            lblAchievementCount.AutoSize = true;
            lblAchievementCount.Font = new Font("Segoe UI", 12F);
            lblAchievementCount.ForeColor = Color.FromArgb(246, 231, 222);
            lblAchievementCount.Location = new Point(133, 48);
            lblAchievementCount.Name = "lblAchievementCount";
            lblAchievementCount.Size = new Size(159, 21);
            lblAchievementCount.TabIndex = 2;
            lblAchievementCount.Text = "lblAchievementCount";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsername.Location = new Point(133, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "lblUsername";
            // 
            // pbPfp
            // 
            pbPfp.BackColor = Color.FromArgb(19, 17, 11);
            pbPfp.Location = new Point(18, 21);
            pbPfp.Name = "pbPfp";
            pbPfp.Size = new Size(100, 100);
            pbPfp.SizeMode = PictureBoxSizeMode.Zoom;
            pbPfp.TabIndex = 0;
            pbPfp.TabStop = false;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(189, 59, 59);
            btnQuit.BackgroundImage = Properties.Resources.powerSymbol;
            btnQuit.BackgroundImageLayout = ImageLayout.Center;
            btnQuit.Dock = DockStyle.Right;
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 69.75F);
            btnQuit.Location = new Point(921, 0);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(144, 144);
            btnQuit.TabIndex = 1;
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // pnlTip
            // 
            pnlTip.BackColor = Color.FromArgb(41, 39, 39);
            pnlTip.Controls.Add(btnNextTip);
            pnlTip.Controls.Add(lblTipText);
            pnlTip.Controls.Add(lblTip);
            pnlTip.Dock = DockStyle.Left;
            pnlTip.Location = new Point(0, 0);
            pnlTip.Margin = new Padding(3, 3, 30, 3);
            pnlTip.MaximumSize = new Size(749, 144);
            pnlTip.Name = "pnlTip";
            pnlTip.Size = new Size(449, 144);
            pnlTip.TabIndex = 0;
            // 
            // btnNextTip
            // 
            btnNextTip.FlatAppearance.BorderSize = 0;
            btnNextTip.FlatStyle = FlatStyle.Flat;
            btnNextTip.ForeColor = Color.FromArgb(246, 231, 222);
            btnNextTip.Location = new Point(406, 121);
            btnNextTip.Name = "btnNextTip";
            btnNextTip.Size = new Size(43, 23);
            btnNextTip.TabIndex = 2;
            btnNextTip.Text = "▶";
            btnNextTip.UseVisualStyleBackColor = true;
            btnNextTip.Click += btnNextTip_Click;
            // 
            // lblTipText
            // 
            lblTipText.AutoSize = true;
            lblTipText.Font = new Font("Segoe UI", 12F);
            lblTipText.ForeColor = Color.FromArgb(246, 231, 222);
            lblTipText.Location = new Point(6, 41);
            lblTipText.MaximumSize = new Size(440, 0);
            lblTipText.MinimumSize = new Size(440, 0);
            lblTipText.Name = "lblTipText";
            lblTipText.Size = new Size(440, 21);
            lblTipText.TabIndex = 1;
            lblTipText.Text = "tipText";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 18F);
            lblTip.ForeColor = Color.FromArgb(246, 231, 222);
            lblTip.Location = new Point(6, 9);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(46, 32);
            lblTip.TabIndex = 0;
            lblTip.Text = "TIP";
            // 
            // pnlOnline
            // 
            pnlOnline.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlOnline.BackColor = Color.FromArgb(45, 41, 39);
            pnlOnline.Controls.Add(ppbToNextOnlineRank);
            pnlOnline.Controls.Add(btnHostOrJoin);
            pnlOnline.Controls.Add(lblOnlineRank);
            pnlOnline.Location = new Point(535, 768);
            pnlOnline.Name = "pnlOnline";
            pnlOnline.Size = new Size(1065, 132);
            pnlOnline.TabIndex = 2;
            // 
            // ppbToNextOnlineRank
            // 
            ppbToNextOnlineRank.Anchor = AnchorStyles.Right;
            ppbToNextOnlineRank.BackColor = Color.FromArgb(41, 39, 39);
            ppbToNextOnlineRank.Font = new Font("Segoe UI", 48F);
            ppbToNextOnlineRank.Location = new Point(296, 24);
            ppbToNextOnlineRank.Name = "ppbToNextOnlineRank";
            ppbToNextOnlineRank.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbToNextOnlineRank.Size = new Size(619, 88);
            ppbToNextOnlineRank.Style = ProgressBarStyle.Continuous;
            ppbToNextOnlineRank.TabIndex = 3;
            ppbToNextOnlineRank.Text = "PERCENTAGE";
            ppbToNextOnlineRank.TextColour = Color.FromArgb(246, 231, 222);
            ppbToNextOnlineRank.UsePercentage = true;
            // 
            // btnHostOrJoin
            // 
            btnHostOrJoin.BackColor = Color.FromArgb(114, 158, 66);
            btnHostOrJoin.BackgroundImageLayout = ImageLayout.Center;
            btnHostOrJoin.Dock = DockStyle.Right;
            btnHostOrJoin.FlatAppearance.BorderSize = 0;
            btnHostOrJoin.FlatStyle = FlatStyle.Flat;
            btnHostOrJoin.Font = new Font("Segoe UI", 69.75F);
            btnHostOrJoin.ForeColor = Color.FromArgb(246, 231, 222);
            btnHostOrJoin.Location = new Point(921, 0);
            btnHostOrJoin.Name = "btnHostOrJoin";
            btnHostOrJoin.Size = new Size(144, 132);
            btnHostOrJoin.TabIndex = 2;
            btnHostOrJoin.Text = "👥";
            btnHostOrJoin.TextAlign = ContentAlignment.TopCenter;
            btnHostOrJoin.UseVisualStyleBackColor = false;
            btnHostOrJoin.Click += btnHostOrJoin_Click;
            // 
            // lblOnlineRank
            // 
            lblOnlineRank.Anchor = AnchorStyles.Left;
            lblOnlineRank.AutoSize = true;
            lblOnlineRank.Font = new Font("Segoe UI", 36F);
            lblOnlineRank.ForeColor = Color.FromArgb(246, 231, 222);
            lblOnlineRank.Location = new Point(6, 47);
            lblOnlineRank.Name = "lblOnlineRank";
            lblOnlineRank.Size = new Size(152, 65);
            lblOnlineRank.TabIndex = 0;
            lblOnlineRank.Text = "RANK";
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(pnlOnline);
            Controls.Add(pnlDetail);
            Controls.Add(pnlMain);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuScreen";
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            Load += MainMenuScreen_Load;
            pnlMain.ResumeLayout(false);
            tlpStatistics.ResumeLayout(false);
            tlpQuizSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPfp).EndInit();
            pnlTip.ResumeLayout(false);
            pnlTip.PerformLayout();
            pnlOnline.ResumeLayout(false);
            pnlOnline.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlDetail;
        private Button btnQuit;
        private Panel pnlTip;
        private Panel pnlUser;
        private Label lblTip;
        private Label lblClass;
        private Label lblHighestScore;
        private Label lblAchievementCount;
        private Label lblUsername;
        private PictureBox pbPfp;
        private Label lblTipText;
        private PictureBox pbLogo;
        private Button btnStats;
        private Button btnAchievements;
        private Button btnGuessingGame;
        private Button btnHistoryQuiz;
        private Button btnTFClassQuiz;
        private Button btnWeaponsQuiz;
        private TableLayoutPanel tlpQuizSelect;
        private TableLayoutPanel tlpStatistics;
        private Button btnNextTip;
        private Panel pnlOnline;
        private Label lblOnlineRank;
        private Button btnHostOrJoin;
        private UserControls.PercentageProgressBar ppbToNextOnlineRank;
    }
}