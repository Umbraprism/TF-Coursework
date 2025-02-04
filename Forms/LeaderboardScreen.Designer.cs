namespace Coursework.Forms
{
    partial class LeaderboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardScreen));
            pnlHeader = new Panel();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblLeaderboardHeader = new Label();
            btnBack = new Button();
            tlpLeaderboardSelect = new TableLayoutPanel();
            btnGuessingLeaderboard = new Button();
            btnHistoryLeaderboard = new Button();
            btnTFClassLeaderboard = new Button();
            btnWeaponsLeaderboard = new Button();
            lblQuizSelected = new Label();
            chPlacement = new ColumnHeader();
            chUsername = new ColumnHeader();
            chScore = new ColumnHeader();
            chHighestRank = new ColumnHeader();
            lvLeaderboard = new ListView();
            pnlHeader.SuspendLayout();
            tlpLeaderboardSelect.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblLeaderboardHeader);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 1;
            // 
            // ppbAchievementProgress
            // 
            ppbAchievementProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ppbAchievementProgress.BackColor = Color.FromArgb(26, 26, 26);
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            ppbAchievementProgress.Location = new Point(2367, 34);
            ppbAchievementProgress.Name = "ppbAchievementProgress";
            ppbAchievementProgress.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.Size = new Size(621, 86);
            ppbAchievementProgress.Style = ProgressBarStyle.Continuous;
            ppbAchievementProgress.TabIndex = 2;
            ppbAchievementProgress.TextColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.UsePercentage = true;
            // 
            // lblLeaderboardHeader
            // 
            lblLeaderboardHeader.Anchor = AnchorStyles.Left;
            lblLeaderboardHeader.AutoSize = true;
            lblLeaderboardHeader.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeaderboardHeader.ForeColor = Color.FromArgb(246, 231, 222);
            lblLeaderboardHeader.Location = new Point(296, 43);
            lblLeaderboardHeader.Name = "lblLeaderboardHeader";
            lblLeaderboardHeader.Size = new Size(462, 86);
            lblLeaderboardHeader.TabIndex = 1;
            lblLeaderboardHeader.Text = "LEADERBOARD";
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
            btnBack.Size = new Size(290, 156);
            btnBack.TabIndex = 0;
            btnBack.Text = "❰";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // tlpLeaderboardSelect
            // 
            tlpLeaderboardSelect.ColumnCount = 1;
            tlpLeaderboardSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeaderboardSelect.Controls.Add(btnGuessingLeaderboard, 0, 3);
            tlpLeaderboardSelect.Controls.Add(btnHistoryLeaderboard, 0, 2);
            tlpLeaderboardSelect.Controls.Add(btnTFClassLeaderboard, 0, 1);
            tlpLeaderboardSelect.Controls.Add(btnWeaponsLeaderboard, 0, 0);
            tlpLeaderboardSelect.Dock = DockStyle.Left;
            tlpLeaderboardSelect.Location = new Point(0, 156);
            tlpLeaderboardSelect.Name = "tlpLeaderboardSelect";
            tlpLeaderboardSelect.RowCount = 4;
            tlpLeaderboardSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLeaderboardSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLeaderboardSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLeaderboardSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLeaderboardSelect.Size = new Size(658, 744);
            tlpLeaderboardSelect.TabIndex = 2;
            // 
            // btnGuessingLeaderboard
            // 
            btnGuessingLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGuessingLeaderboard.BackColor = Color.FromArgb(189, 59, 59);
            btnGuessingLeaderboard.FlatAppearance.BorderSize = 0;
            btnGuessingLeaderboard.FlatStyle = FlatStyle.Flat;
            btnGuessingLeaderboard.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuessingLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            btnGuessingLeaderboard.Location = new Point(76, 561);
            btnGuessingLeaderboard.Name = "btnGuessingLeaderboard";
            btnGuessingLeaderboard.Size = new Size(506, 180);
            btnGuessingLeaderboard.TabIndex = 10;
            btnGuessingLeaderboard.Text = "GUESSING";
            btnGuessingLeaderboard.UseVisualStyleBackColor = false;
            // 
            // btnHistoryLeaderboard
            // 
            btnHistoryLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnHistoryLeaderboard.BackColor = Color.FromArgb(189, 59, 59);
            btnHistoryLeaderboard.FlatAppearance.BorderSize = 0;
            btnHistoryLeaderboard.FlatStyle = FlatStyle.Flat;
            btnHistoryLeaderboard.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistoryLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            btnHistoryLeaderboard.Location = new Point(76, 375);
            btnHistoryLeaderboard.Name = "btnHistoryLeaderboard";
            btnHistoryLeaderboard.Size = new Size(506, 180);
            btnHistoryLeaderboard.TabIndex = 9;
            btnHistoryLeaderboard.Text = "HISTORY";
            btnHistoryLeaderboard.UseVisualStyleBackColor = false;
            // 
            // btnTFClassLeaderboard
            // 
            btnTFClassLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTFClassLeaderboard.BackColor = Color.FromArgb(189, 59, 59);
            btnTFClassLeaderboard.FlatAppearance.BorderSize = 0;
            btnTFClassLeaderboard.FlatStyle = FlatStyle.Flat;
            btnTFClassLeaderboard.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnTFClassLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            btnTFClassLeaderboard.Location = new Point(76, 189);
            btnTFClassLeaderboard.Name = "btnTFClassLeaderboard";
            btnTFClassLeaderboard.Size = new Size(506, 180);
            btnTFClassLeaderboard.TabIndex = 8;
            btnTFClassLeaderboard.Text = "CLASSES";
            btnTFClassLeaderboard.UseVisualStyleBackColor = false;
            // 
            // btnWeaponsLeaderboard
            // 
            btnWeaponsLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnWeaponsLeaderboard.BackColor = Color.FromArgb(189, 59, 59);
            btnWeaponsLeaderboard.FlatAppearance.BorderSize = 0;
            btnWeaponsLeaderboard.FlatStyle = FlatStyle.Flat;
            btnWeaponsLeaderboard.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnWeaponsLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            btnWeaponsLeaderboard.Location = new Point(76, 3);
            btnWeaponsLeaderboard.Name = "btnWeaponsLeaderboard";
            btnWeaponsLeaderboard.Size = new Size(506, 180);
            btnWeaponsLeaderboard.TabIndex = 7;
            btnWeaponsLeaderboard.Text = "WEAPONS";
            btnWeaponsLeaderboard.UseVisualStyleBackColor = false;
            btnWeaponsLeaderboard.Click += btnWeaponsLeaderboard_Click;
            // 
            // lblQuizSelected
            // 
            lblQuizSelected.Anchor = AnchorStyles.Top;
            lblQuizSelected.AutoSize = true;
            lblQuizSelected.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizSelected.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizSelected.Location = new Point(874, 159);
            lblQuizSelected.Name = "lblQuizSelected";
            lblQuizSelected.Size = new Size(518, 128);
            lblQuizSelected.TabIndex = 3;
            lblQuizSelected.Text = "QUIZ QUIZ";
            // 
            // chUsername
            // 
            chUsername.Width = 500;
            // 
            // chScore
            // 
            chScore.Width = 200;
            // 
            // chHighestRank
            // 
            chHighestRank.TextAlign = HorizontalAlignment.Center;
            chHighestRank.Width = 152;
            // 
            // lvLeaderboard
            // 
            lvLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvLeaderboard.BackColor = Color.FromArgb(41, 39, 39);
            lvLeaderboard.BorderStyle = BorderStyle.None;
            lvLeaderboard.Columns.AddRange(new ColumnHeader[] { chPlacement, chUsername, chScore, chHighestRank });
            lvLeaderboard.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lvLeaderboard.ForeColor = Color.FromArgb(246, 231, 222);
            lvLeaderboard.HeaderStyle = ColumnHeaderStyle.None;
            lvLeaderboard.Location = new Point(675, 290);
            lvLeaderboard.Name = "lvLeaderboard";
            lvLeaderboard.Size = new Size(913, 626);
            lvLeaderboard.TabIndex = 4;
            lvLeaderboard.UseCompatibleStateImageBehavior = false;
            lvLeaderboard.View = View.Details;
            // 
            // LeaderboardScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(lvLeaderboard);
            Controls.Add(lblQuizSelected);
            Controls.Add(tlpLeaderboardSelect);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LeaderboardScreen";
            Text = "Leaderboard";
            WindowState = FormWindowState.Maximized;
            Load += LeaderboardScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpLeaderboardSelect.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblLeaderboardHeader;
        private Button btnBack;
        private TableLayoutPanel tlpLeaderboardSelect;
        private Label lblQuizSelected;
        private Button btnGuessingLeaderboard;
        private Button btnHistoryLeaderboard;
        private Button btnTFClassLeaderboard;
        private Button btnWeaponsLeaderboard;
        private ColumnHeader chPlacement;
        private ColumnHeader chUsername;
        private ColumnHeader chScore;
        private ColumnHeader chHighestRank;
        private ListView lvLeaderboard;
    }
}