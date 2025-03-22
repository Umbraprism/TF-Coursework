namespace Coursework.Forms
{
    partial class TrueFalseScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrueFalseScreen));
            pnlHeader = new Panel();
            lblTimeRemaining = new Label();
            lblScore = new Label();
            lblScorePrefix = new Label();
            lblTimeRemainingPrefix = new Label();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblQuizName = new Label();
            lblQuestionText = new Label();
            pbAbility = new PictureBox();
            tlpAnswers = new TableLayoutPanel();
            btnAnsOne = new Button();
            btnAnsTwo = new Button();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            ppbCharge = new UserControls.PercentageProgressBar();
            lblQuestionNumber = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).BeginInit();
            tlpAnswers.SuspendLayout();
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
            pnlHeader.TabIndex = 1;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.Font = new Font("Segoe UI", 24F);
            lblTimeRemaining.ForeColor = Color.FromArgb(246, 231, 222);
            lblTimeRemaining.Location = new Point(1489, 23);
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
            lblScore.Location = new Point(1489, 98);
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
            lblScorePrefix.Location = new Point(1003, 98);
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
            lblTimeRemainingPrefix.Location = new Point(1003, 23);
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
            // lblQuizName
            // 
            lblQuizName.Anchor = AnchorStyles.Left;
            lblQuizName.AutoSize = true;
            lblQuizName.Font = new Font("Segoe UI", 48F);
            lblQuizName.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuizName.Location = new Point(12, 44);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(347, 86);
            lblQuizName.TabIndex = 1;
            lblQuizName.Text = "QUIZ QUIZ";
            // 
            // lblQuestionText
            // 
            lblQuestionText.Anchor = AnchorStyles.Top;
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Segoe UI", 36F);
            lblQuestionText.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuestionText.Location = new Point(50, 225);
            lblQuestionText.MaximumSize = new Size(1500, 0);
            lblQuestionText.MinimumSize = new Size(1500, 0);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(1500, 65);
            lblQuestionText.TabIndex = 2;
            lblQuestionText.Text = "questionText";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbAbility
            // 
            pbAbility.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbAbility.Location = new Point(0, 694);
            pbAbility.Name = "pbAbility";
            pbAbility.Size = new Size(205, 205);
            pbAbility.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbility.TabIndex = 3;
            pbAbility.TabStop = false;
            pbAbility.Tag = "AbilityIndicator";
            pbAbility.Click += pbAbility_Click;
            // 
            // tlpAnswers
            // 
            tlpAnswers.Anchor = AnchorStyles.Bottom;
            tlpAnswers.ColumnCount = 2;
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAnswers.Controls.Add(btnAnsOne, 0, 0);
            tlpAnswers.Controls.Add(btnAnsTwo, 1, 0);
            tlpAnswers.Location = new Point(291, 528);
            tlpAnswers.Name = "tlpAnswers";
            tlpAnswers.RowCount = 1;
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAnswers.Size = new Size(1072, 242);
            tlpAnswers.TabIndex = 4;
            // 
            // btnAnsOne
            // 
            btnAnsOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAnsOne.BackColor = Color.FromArgb(189, 59, 59);
            btnAnsOne.FlatAppearance.BorderSize = 0;
            btnAnsOne.FlatStyle = FlatStyle.Flat;
            btnAnsOne.Font = new Font("Segoe UI", 36F);
            btnAnsOne.ForeColor = Color.FromArgb(246, 231, 222);
            btnAnsOne.Location = new Point(15, 3);
            btnAnsOne.Name = "btnAnsOne";
            btnAnsOne.Size = new Size(506, 236);
            btnAnsOne.TabIndex = 9;
            btnAnsOne.Tag = "0";
            btnAnsOne.Text = "AnsOne";
            btnAnsOne.UseVisualStyleBackColor = false;
            btnAnsOne.Click += btnAnswer_Click;
            // 
            // btnAnsTwo
            // 
            btnAnsTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAnsTwo.BackColor = Color.FromArgb(189, 59, 59);
            btnAnsTwo.FlatAppearance.BorderSize = 0;
            btnAnsTwo.FlatStyle = FlatStyle.Flat;
            btnAnsTwo.Font = new Font("Segoe UI", 36F);
            btnAnsTwo.ForeColor = Color.FromArgb(246, 231, 222);
            btnAnsTwo.Location = new Point(551, 3);
            btnAnsTwo.Name = "btnAnsTwo";
            btnAnsTwo.Size = new Size(506, 236);
            btnAnsTwo.TabIndex = 8;
            btnAnsTwo.Tag = "1";
            btnAnsTwo.Text = "AnsTwo";
            btnAnsTwo.UseVisualStyleBackColor = false;
            btnAnsTwo.Click += btnAnswer_Click;
            // 
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // ppbCharge
            // 
            ppbCharge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ppbCharge.Font = new Font("Segoe UI", 12F);
            ppbCharge.Location = new Point(0, 876);
            ppbCharge.Name = "ppbCharge";
            ppbCharge.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbCharge.Size = new Size(205, 23);
            ppbCharge.Style = ProgressBarStyle.Continuous;
            ppbCharge.TabIndex = 5;
            ppbCharge.Text = "PERCENTAGE";
            ppbCharge.TextColour = Color.FromArgb(246, 231, 222);
            ppbCharge.UsePercentage = true;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Font = new Font("Segoe UI", 20F);
            lblQuestionNumber.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuestionNumber.Location = new Point(1530, 854);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(58, 37);
            lblQuestionNumber.TabIndex = 6;
            lblQuestionNumber.Text = "n/n";
            // 
            // TrueFalseScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(lblQuestionNumber);
            Controls.Add(ppbCharge);
            Controls.Add(tlpAnswers);
            Controls.Add(pbAbility);
            Controls.Add(lblQuestionText);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TrueFalseScreen";
            Text = "TrueFalseScreen";
            WindowState = FormWindowState.Maximized;
            Load += TrueFalseScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).EndInit();
            tlpAnswers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblQuizName;
        private Label lblTimeRemainingPrefix;
        private Label lblTimeRemaining;
        private Label lblScore;
        private Label lblScorePrefix;
        private Label lblQuestionText;
        private PictureBox pbAbility;
        private TableLayoutPanel tlpAnswers;
        private Button btnAnsOne;
        private Button btnAnsTwo;
        private System.Windows.Forms.Timer tmrQuiz;
        private UserControls.PercentageProgressBar ppbCharge;
        private Label lblQuestionNumber;
    }
}