namespace Coursework.Forms
{
    partial class GapFillScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GapFillScreen));
            pnlHeader = new Panel();
            lblTimeRemaining = new Label();
            lblScore = new Label();
            lblScorePrefix = new Label();
            lblTimeRemainingPrefix = new Label();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblQuizName = new Label();
            lblQuestionText = new Label();
            pbAbility = new PictureBox();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            rpnlAnswer = new UserControls.RoundedPanel();
            tbAnswer = new TextBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).BeginInit();
            rpnlAnswer.SuspendLayout();
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
            lblQuestionText.Location = new Point(482, 225);
            lblQuestionText.MaximumSize = new Size(637, 0);
            lblQuestionText.MinimumSize = new Size(637, 0);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(637, 65);
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
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // rpnlAnswer
            // 
            rpnlAnswer.Anchor = AnchorStyles.Bottom;
            rpnlAnswer.BorderColour = Color.Transparent;
            rpnlAnswer.BorderSize = 0;
            rpnlAnswer.Controls.Add(tbAnswer);
            rpnlAnswer.Location = new Point(519, 555);
            rpnlAnswer.Name = "rpnlAnswer";
            rpnlAnswer.PanelColour = Color.White;
            rpnlAnswer.Radius = 30;
            rpnlAnswer.Size = new Size(563, 68);
            rpnlAnswer.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlAnswer.TabIndex = 4;
            // 
            // tbAnswer
            // 
            tbAnswer.BorderStyle = BorderStyle.None;
            tbAnswer.Font = new Font("Segoe UI", 30F);
            tbAnswer.Location = new Point(3, 11);
            tbAnswer.MaxLength = 20;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.PlaceholderText = "Username";
            tbAnswer.Size = new Size(557, 54);
            tbAnswer.TabIndex = 0;
            tbAnswer.KeyDown += tbAnswer_KeyDown;
            // 
            // GapFillScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(rpnlAnswer);
            Controls.Add(pbAbility);
            Controls.Add(lblQuestionText);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GapFillScreen";
            Text = "questionblank1";
            WindowState = FormWindowState.Maximized;
            Load += MultipleChoiceScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).EndInit();
            rpnlAnswer.ResumeLayout(false);
            rpnlAnswer.PerformLayout();
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
        private System.Windows.Forms.Timer tmrQuiz;
        private UserControls.RoundedPanel rpnlAnswer;
        private TextBox tbAnswer;
    }
}