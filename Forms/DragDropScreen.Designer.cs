namespace Coursework.Forms
{
    partial class DragDropScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragDropScreen));
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
            lblAnsFour = new Label();
            lblAnsThree = new Label();
            lblAnsTwo = new Label();
            lblAnsOne = new Label();
            tmrQuiz = new System.Windows.Forms.Timer(components);
            rpnlImageBox = new UserControls.RoundedPanel();
            pbImage = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).BeginInit();
            tlpAnswers.SuspendLayout();
            rpnlImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
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
            lblTimeRemaining.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblScore.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblScorePrefix.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblTimeRemainingPrefix.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
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
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblQuizName.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
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
            lblQuestionText.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.FromArgb(246, 231, 222);
            lblQuestionText.Location = new Point(72, 174);
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
            tlpAnswers.Controls.Add(lblAnsFour, 0, 0);
            tlpAnswers.Controls.Add(lblAnsThree, 1, 0);
            tlpAnswers.Controls.Add(lblAnsTwo, 0, 1);
            tlpAnswers.Controls.Add(lblAnsOne, 1, 1);
            tlpAnswers.Location = new Point(285, 597);
            tlpAnswers.Name = "tlpAnswers";
            tlpAnswers.RowCount = 2;
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAnswers.Size = new Size(1072, 282);
            tlpAnswers.TabIndex = 4;
            // 
            // lblAnsFour
            // 
            lblAnsFour.Anchor = AnchorStyles.None;
            lblAnsFour.AutoSize = true;
            lblAnsFour.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnsFour.ForeColor = Color.FromArgb(246, 231, 222);
            lblAnsFour.Location = new Point(171, 38);
            lblAnsFour.Name = "lblAnsFour";
            lblAnsFour.Size = new Size(194, 65);
            lblAnsFour.TabIndex = 3;
            lblAnsFour.Tag = "3";
            lblAnsFour.Text = "AnsOne";
            lblAnsFour.MouseDown += label_MouseDown;
            // 
            // lblAnsThree
            // 
            lblAnsThree.Anchor = AnchorStyles.None;
            lblAnsThree.AutoSize = true;
            lblAnsThree.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnsThree.ForeColor = Color.FromArgb(246, 231, 222);
            lblAnsThree.Location = new Point(708, 38);
            lblAnsThree.Name = "lblAnsThree";
            lblAnsThree.Size = new Size(191, 65);
            lblAnsThree.TabIndex = 2;
            lblAnsThree.Tag = "2";
            lblAnsThree.Text = "AnsTwo";
            lblAnsThree.MouseDown += label_MouseDown;
            // 
            // lblAnsTwo
            // 
            lblAnsTwo.Anchor = AnchorStyles.None;
            lblAnsTwo.AutoSize = true;
            lblAnsTwo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnsTwo.ForeColor = Color.FromArgb(246, 231, 222);
            lblAnsTwo.Location = new Point(155, 179);
            lblAnsTwo.Name = "lblAnsTwo";
            lblAnsTwo.Size = new Size(225, 65);
            lblAnsTwo.TabIndex = 1;
            lblAnsTwo.Tag = "1";
            lblAnsTwo.Text = "AnsThree";
            lblAnsTwo.MouseDown += label_MouseDown;
            // 
            // lblAnsOne
            // 
            lblAnsOne.Anchor = AnchorStyles.None;
            lblAnsOne.AutoSize = true;
            lblAnsOne.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnsOne.ForeColor = Color.FromArgb(246, 231, 222);
            lblAnsOne.Location = new Point(703, 179);
            lblAnsOne.Name = "lblAnsOne";
            lblAnsOne.Size = new Size(201, 65);
            lblAnsOne.TabIndex = 0;
            lblAnsOne.Tag = "0";
            lblAnsOne.Text = "AnsFour";
            lblAnsOne.MouseDown += label_MouseDown;
            // 
            // tmrQuiz
            // 
            tmrQuiz.Interval = 1000;
            tmrQuiz.Tick += tmrQuiz_Tick;
            // 
            // rpnlImageBox
            // 
            rpnlImageBox.Anchor = AnchorStyles.Top;
            rpnlImageBox.BorderColour = Color.FromArgb(45, 41, 39);
            rpnlImageBox.BorderSize = 0;
            rpnlImageBox.Controls.Add(pbImage);
            rpnlImageBox.Location = new Point(587, 287);
            rpnlImageBox.Name = "rpnlImageBox";
            rpnlImageBox.PanelColour = Color.FromArgb(45, 41, 39);
            rpnlImageBox.Radius = 50;
            rpnlImageBox.Size = new Size(462, 304);
            rpnlImageBox.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlImageBox.TabIndex = 5;
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
            pbImage.DragDrop += image_DragDrop;
            pbImage.DragEnter += image_DragEnter;
            // 
            // DragDropScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(rpnlImageBox);
            Controls.Add(tlpAnswers);
            Controls.Add(pbAbility);
            Controls.Add(lblQuestionText);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DragDropScreen";
            Text = "DragDropScreen";
            WindowState = FormWindowState.Maximized;
            Load += MultipleChoiceScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbility).EndInit();
            tlpAnswers.ResumeLayout(false);
            tlpAnswers.PerformLayout();
            rpnlImageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
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
        private System.Windows.Forms.Timer tmrQuiz;
        private Label lblAnsOne;
        private Label lblAnsFour;
        private Label lblAnsThree;
        private Label lblAnsTwo;
        private UserControls.RoundedPanel rpnlImageBox;
        private PictureBox pbImage;
    }
}