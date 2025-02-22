namespace Coursework.Forms
{
    partial class EndScreen
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
            rpnlEnd = new UserControls.RoundedPanel();
            panel2 = new Panel();
            lblRankingTitle = new Label();
            lblPlacement = new Label();
            panel1 = new Panel();
            lblGradeTitle = new Label();
            lblGrade = new Label();
            btnNextTip = new Button();
            lblScore = new Label();
            lblIncorrect = new Label();
            lblCorrect = new Label();
            flpAchievementsUnlocked = new FlowLayoutPanel();
            lblAchievements = new Label();
            lblUsername = new Label();
            tmrEnd = new System.Windows.Forms.Timer(components);
            rpnlEnd.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rpnlEnd
            // 
            rpnlEnd.Anchor = AnchorStyles.None;
            rpnlEnd.BorderColour = Color.White;
            rpnlEnd.BorderSize = 10;
            rpnlEnd.Controls.Add(panel2);
            rpnlEnd.Controls.Add(panel1);
            rpnlEnd.Controls.Add(btnNextTip);
            rpnlEnd.Controls.Add(lblScore);
            rpnlEnd.Controls.Add(lblIncorrect);
            rpnlEnd.Controls.Add(lblCorrect);
            rpnlEnd.Controls.Add(flpAchievementsUnlocked);
            rpnlEnd.Controls.Add(lblAchievements);
            rpnlEnd.Controls.Add(lblUsername);
            rpnlEnd.Location = new Point(12, 12);
            rpnlEnd.Name = "rpnlEnd";
            rpnlEnd.PanelColour = Color.FromArgb(189, 59, 59);
            rpnlEnd.Radius = 180;
            rpnlEnd.Size = new Size(1176, 776);
            rpnlEnd.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlEnd.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(189, 59, 59);
            panel2.Controls.Add(lblRankingTitle);
            panel2.Controls.Add(lblPlacement);
            panel2.Location = new Point(664, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 217);
            panel2.TabIndex = 12;
            // 
            // lblRankingTitle
            // 
            lblRankingTitle.Anchor = AnchorStyles.Top;
            lblRankingTitle.AutoSize = true;
            lblRankingTitle.BackColor = Color.FromArgb(189, 59, 59);
            lblRankingTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblRankingTitle.ForeColor = Color.White;
            lblRankingTitle.Location = new Point(88, 0);
            lblRankingTitle.Name = "lblRankingTitle";
            lblRankingTitle.Size = new Size(234, 65);
            lblRankingTitle.TabIndex = 7;
            lblRankingTitle.Text = "RANKING";
            // 
            // lblPlacement
            // 
            lblPlacement.Anchor = AnchorStyles.Top;
            lblPlacement.AutoSize = true;
            lblPlacement.BackColor = Color.FromArgb(189, 59, 59);
            lblPlacement.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlacement.ForeColor = Color.White;
            lblPlacement.Location = new Point(115, 55);
            lblPlacement.Name = "lblPlacement";
            lblPlacement.Size = new Size(183, 128);
            lblPlacement.TabIndex = 8;
            lblPlacement.Text = "#N";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(189, 59, 59);
            panel1.Controls.Add(lblGradeTitle);
            panel1.Controls.Add(lblGrade);
            panel1.Location = new Point(664, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 183);
            panel1.TabIndex = 11;
            // 
            // lblGradeTitle
            // 
            lblGradeTitle.Anchor = AnchorStyles.Top;
            lblGradeTitle.AutoSize = true;
            lblGradeTitle.BackColor = Color.FromArgb(189, 59, 59);
            lblGradeTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblGradeTitle.ForeColor = Color.White;
            lblGradeTitle.Location = new Point(106, 0);
            lblGradeTitle.Name = "lblGradeTitle";
            lblGradeTitle.Size = new Size(179, 65);
            lblGradeTitle.TabIndex = 5;
            lblGradeTitle.Text = "GRADE";
            // 
            // lblGrade
            // 
            lblGrade.Anchor = AnchorStyles.Top;
            lblGrade.AutoSize = true;
            lblGrade.BackColor = Color.FromArgb(189, 59, 59);
            lblGrade.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(19, 55);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(355, 128);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "GRADE";
            // 
            // btnNextTip
            // 
            btnNextTip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextTip.BackColor = Color.FromArgb(159, 49, 49);
            btnNextTip.FlatAppearance.BorderSize = 0;
            btnNextTip.FlatStyle = FlatStyle.Flat;
            btnNextTip.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextTip.ForeColor = Color.White;
            btnNextTip.Location = new Point(664, 649);
            btnNextTip.Name = "btnNextTip";
            btnNextTip.Size = new Size(408, 79);
            btnNextTip.TabIndex = 10;
            btnNextTip.Text = "▶";
            btnNextTip.UseVisualStyleBackColor = false;
            btnNextTip.Click += btnNextTip_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.FromArgb(189, 59, 59);
            lblScore.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(31, 324);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(178, 65);
            lblScore.TabIndex = 9;
            lblScore.Text = "Score -";
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.BackColor = Color.FromArgb(189, 59, 59);
            lblIncorrect.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncorrect.ForeColor = Color.White;
            lblIncorrect.Location = new Point(31, 259);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(255, 65);
            lblIncorrect.TabIndex = 4;
            lblIncorrect.Text = "n Incorrect";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.BackColor = Color.FromArgb(189, 59, 59);
            lblCorrect.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorrect.ForeColor = Color.White;
            lblCorrect.Location = new Point(31, 194);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(223, 65);
            lblCorrect.TabIndex = 3;
            lblCorrect.Text = "n Correct";
            // 
            // flpAchievementsUnlocked
            // 
            flpAchievementsUnlocked.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flpAchievementsUnlocked.AutoScroll = true;
            flpAchievementsUnlocked.BackColor = Color.FromArgb(189, 59, 59);
            flpAchievementsUnlocked.ForeColor = Color.White;
            flpAchievementsUnlocked.Location = new Point(31, 454);
            flpAchievementsUnlocked.Name = "flpAchievementsUnlocked";
            flpAchievementsUnlocked.Size = new Size(534, 274);
            flpAchievementsUnlocked.TabIndex = 2;
            // 
            // lblAchievements
            // 
            lblAchievements.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAchievements.AutoSize = true;
            lblAchievements.BackColor = Color.FromArgb(189, 59, 59);
            lblAchievements.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblAchievements.ForeColor = Color.White;
            lblAchievements.Location = new Point(31, 386);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(534, 65);
            lblAchievements.TabIndex = 1;
            lblAchievements.Text = "Achievements Unlocked";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(189, 59, 59);
            lblUsername.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(90, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(996, 128);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "%USERNAME% WINS!";
            // 
            // tmrEnd
            // 
            tmrEnd.Interval = 1000;
            tmrEnd.Tick += tmrEnd_Tick;
            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1200, 800);
            Controls.Add(rpnlEnd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EndScreen";
            Text = "EndScreen";
            WindowState = FormWindowState.Maximized;
            Load += EndScreen_Load;
            rpnlEnd.ResumeLayout(false);
            rpnlEnd.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.RoundedPanel rpnlEnd;
        private Label lblUsername;
        private FlowLayoutPanel flpAchievementsUnlocked;
        private Label lblAchievements;
        private Label lblIncorrect;
        private Label lblCorrect;
        private Label lblPlacement;
        private Label lblRankingTitle;
        private Label lblGrade;
        private Label lblGradeTitle;
        private Label lblScore;
        private System.Windows.Forms.Timer tmrEnd;
        private Button btnNextTip;
        private Panel panel1;
        private Panel panel2;
    }
}