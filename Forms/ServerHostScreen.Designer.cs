namespace Coursework.Forms
{
    partial class ServerHostScreen
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
            pnlHeader = new Panel();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblHost = new Label();
            btnBack = new Button();
            tlpPlayers = new TableLayoutPanel();
            tlpQuizSelect = new TableLayoutPanel();
            btnTFClassQuiz = new Button();
            btnWeaponsQuiz = new Button();
            btnHistoryQuiz = new Button();
            pnlHeader.SuspendLayout();
            tlpQuizSelect.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblHost);
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
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F);
            ppbAchievementProgress.Location = new Point(2367, 34);
            ppbAchievementProgress.Name = "ppbAchievementProgress";
            ppbAchievementProgress.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.Size = new Size(621, 86);
            ppbAchievementProgress.Style = ProgressBarStyle.Continuous;
            ppbAchievementProgress.TabIndex = 2;
            ppbAchievementProgress.Text = "PERCENTAGE";
            ppbAchievementProgress.TextColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.UsePercentage = true;
            // 
            // lblHost
            // 
            lblHost.Anchor = AnchorStyles.Left;
            lblHost.AutoSize = true;
            lblHost.Font = new Font("Segoe UI", 48F);
            lblHost.ForeColor = Color.FromArgb(246, 231, 222);
            lblHost.Location = new Point(296, 46);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(198, 86);
            lblHost.TabIndex = 1;
            lblHost.Text = "HOST";
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
            btnBack.Size = new Size(290, 156);
            btnBack.TabIndex = 0;
            btnBack.Text = "❰";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tlpPlayers
            // 
            tlpPlayers.ColumnCount = 2;
            tlpPlayers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayers.Dock = DockStyle.Right;
            tlpPlayers.Location = new Point(717, 156);
            tlpPlayers.Name = "tlpPlayers";
            tlpPlayers.RowCount = 2;
            tlpPlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPlayers.Size = new Size(883, 744);
            tlpPlayers.TabIndex = 2;
            // 
            // tlpQuizSelect
            // 
            tlpQuizSelect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tlpQuizSelect.ColumnCount = 1;
            tlpQuizSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQuizSelect.Controls.Add(btnTFClassQuiz, 0, 1);
            tlpQuizSelect.Controls.Add(btnWeaponsQuiz, 0, 0);
            tlpQuizSelect.Controls.Add(btnHistoryQuiz, 0, 2);
            tlpQuizSelect.Location = new Point(0, 187);
            tlpQuizSelect.Name = "tlpQuizSelect";
            tlpQuizSelect.RowCount = 3;
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpQuizSelect.Size = new Size(658, 694);
            tlpQuizSelect.TabIndex = 3;
            // 
            // btnTFClassQuiz
            // 
            btnTFClassQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTFClassQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnTFClassQuiz.FlatAppearance.BorderSize = 0;
            btnTFClassQuiz.FlatStyle = FlatStyle.Flat;
            btnTFClassQuiz.Font = new Font("Segoe UI", 48F);
            btnTFClassQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnTFClassQuiz.Location = new Point(76, 234);
            btnTFClassQuiz.Name = "btnTFClassQuiz";
            btnTFClassQuiz.Size = new Size(506, 225);
            btnTFClassQuiz.TabIndex = 8;
            btnTFClassQuiz.Tag = "TFClass";
            btnTFClassQuiz.Text = "CLASSES";
            btnTFClassQuiz.UseVisualStyleBackColor = false;
            // 
            // btnWeaponsQuiz
            // 
            btnWeaponsQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnWeaponsQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnWeaponsQuiz.FlatAppearance.BorderSize = 0;
            btnWeaponsQuiz.FlatStyle = FlatStyle.Flat;
            btnWeaponsQuiz.Font = new Font("Segoe UI", 48F);
            btnWeaponsQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnWeaponsQuiz.Location = new Point(76, 3);
            btnWeaponsQuiz.Name = "btnWeaponsQuiz";
            btnWeaponsQuiz.Size = new Size(506, 225);
            btnWeaponsQuiz.TabIndex = 7;
            btnWeaponsQuiz.Tag = "Weapons";
            btnWeaponsQuiz.Text = "WEAPONS";
            btnWeaponsQuiz.UseVisualStyleBackColor = false;
            // 
            // btnHistoryQuiz
            // 
            btnHistoryQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnHistoryQuiz.BackColor = Color.FromArgb(189, 59, 59);
            btnHistoryQuiz.FlatAppearance.BorderSize = 0;
            btnHistoryQuiz.FlatStyle = FlatStyle.Flat;
            btnHistoryQuiz.Font = new Font("Segoe UI", 48F);
            btnHistoryQuiz.ForeColor = Color.FromArgb(246, 231, 222);
            btnHistoryQuiz.Location = new Point(76, 465);
            btnHistoryQuiz.Name = "btnHistoryQuiz";
            btnHistoryQuiz.Size = new Size(506, 226);
            btnHistoryQuiz.TabIndex = 9;
            btnHistoryQuiz.Tag = "History";
            btnHistoryQuiz.Text = "HISTORY";
            btnHistoryQuiz.UseVisualStyleBackColor = false;
            // 
            // ServerHostScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(tlpQuizSelect);
            Controls.Add(tlpPlayers);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServerHostScreen";
            Text = "Online Match";
            WindowState = FormWindowState.Maximized;
            Load += ServerHostScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpQuizSelect.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblHost;
        private Button btnBack;
        private TableLayoutPanel tlpPlayers;
        private TableLayoutPanel tlpQuizSelect;
        private Button btnTFClassQuiz;
        private Button btnWeaponsQuiz;
        private Button btnHistoryQuiz;
    }
}