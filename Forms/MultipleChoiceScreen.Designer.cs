namespace Coursework.Forms
{
    partial class MultipleChoiceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleChoiceScreen));
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
            btnAnsThree = new Button();
            btnAnsFour = new Button();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            lblQuestionNumber = new Label();
            ppbCharge = new UserControls.PercentageProgressBar();
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
            tlpAnswers.Controls.Add(btnAnsThree, 0, 1);
            tlpAnswers.Controls.Add(btnAnsFour, 1, 1);
            tlpAnswers.Location = new Point(285, 416);
            tlpAnswers.Name = "tlpAnswers";
            tlpAnswers.RowCount = 2;
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAnswers.Size = new Size(1072, 463);
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
            btnAnsOne.Size = new Size(506, 225);
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
            btnAnsTwo.Size = new Size(506, 225);
            btnAnsTwo.TabIndex = 8;
            btnAnsTwo.Tag = "1";
            btnAnsTwo.Text = "AnsTwo";
            btnAnsTwo.UseVisualStyleBackColor = false;
            btnAnsTwo.Click += btnAnswer_Click;
            // 
            // btnAnsThree
            // 
            btnAnsThree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAnsThree.BackColor = Color.FromArgb(189, 59, 59);
            btnAnsThree.FlatAppearance.BorderSize = 0;
            btnAnsThree.FlatStyle = FlatStyle.Flat;
            btnAnsThree.Font = new Font("Segoe UI", 36F);
            btnAnsThree.ForeColor = Color.FromArgb(246, 231, 222);
            btnAnsThree.Location = new Point(15, 234);
            btnAnsThree.Name = "btnAnsThree";
            btnAnsThree.Size = new Size(506, 226);
            btnAnsThree.TabIndex = 10;
            btnAnsThree.Tag = "2";
            btnAnsThree.Text = "AnsThree";
            btnAnsThree.UseVisualStyleBackColor = false;
            btnAnsThree.Click += btnAnswer_Click;
            // 
            // btnAnsFour
            // 
            btnAnsFour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAnsFour.BackColor = Color.FromArgb(189, 59, 59);
            btnAnsFour.FlatAppearance.BorderSize = 0;
            btnAnsFour.FlatStyle = FlatStyle.Flat;
            btnAnsFour.Font = new Font("Segoe UI", 36F);
            btnAnsFour.ForeColor = Color.FromArgb(246, 231, 222);
            btnAnsFour.Location = new Point(551, 234);
            btnAnsFour.Name = "btnAnsFour";
            btnAnsFour.Size = new Size(506, 226);
            btnAnsFour.TabIndex = 7;
            btnAnsFour.Tag = "3";
            btnAnsFour.Text = "AnsFour";
            btnAnsFour.UseVisualStyleBackColor = false;
            btnAnsFour.Click += btnAnswer_Click;
            // 
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestionNumber.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuestionNumber.Location = new Point(1530, 854);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(58, 37);
            lblQuestionNumber.TabIndex = 5;
            lblQuestionNumber.Text = "n/n";
            // 
            // ppbCharge
            // 
            ppbCharge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ppbCharge.Font = new Font("Segoe UI", 12F);
            ppbCharge.ForeColor = Color.GreenYellow;
            ppbCharge.Location = new Point(0, 876);
            ppbCharge.Name = "ppbCharge";
            ppbCharge.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbCharge.Size = new Size(205, 23);
            ppbCharge.Style = ProgressBarStyle.Continuous;
            ppbCharge.TabIndex = 6;
            ppbCharge.Text = "PERCENTAGE";
            ppbCharge.TextColour = Color.FromArgb(246, 231, 222);
            ppbCharge.UsePercentage = true;
            // 
            // MultipleChoiceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(ppbCharge);
            Controls.Add(lblQuestionNumber);
            Controls.Add(tlpAnswers);
            Controls.Add(pbAbility);
            Controls.Add(lblQuestionText);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MultipleChoiceScreen";
            Text = "Multiple Choice";
            WindowState = FormWindowState.Maximized;
            Load += MultipleChoiceScreen_Load;
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
        private Button btnAnsFour;
        private Button btnAnsThree;
        private System.Windows.Forms.Timer tmrQuiz;
        private Label lblQuestionNumber;
        private UserControls.PercentageProgressBar ppbCharge;
    }
}