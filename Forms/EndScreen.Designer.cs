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
            pnlPlacement = new Panel();
            lblRankingTitle = new Label();
            lblPlacement = new Label();
            pnlGrade = new Panel();
            lblGradeTitle = new Label();
            lblGrade = new Label();
            btnFinished = new Button();
            lblScore = new Label();
            lblIncorrect = new Label();
            lblCorrect = new Label();
            flpAchievementsUnlocked = new FlowLayoutPanel();
            lblAchievements = new Label();
            lblUsername = new Label();
            tmrEnd = new System.Windows.Forms.Timer(components);
            rpnlEnd.SuspendLayout();
            pnlPlacement.SuspendLayout();
            pnlGrade.SuspendLayout();
            SuspendLayout();
            // 
            // rpnlEnd
            // 
            rpnlEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rpnlEnd.BorderColour = Color.White;
            rpnlEnd.BorderSize = 10;
            rpnlEnd.Controls.Add(pnlPlacement);
            rpnlEnd.Controls.Add(pnlGrade);
            rpnlEnd.Controls.Add(btnFinished);
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
            // pnlPlacement
            // 
            pnlPlacement.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlPlacement.BackColor = Color.FromArgb(189, 59, 59);
            pnlPlacement.Controls.Add(lblRankingTitle);
            pnlPlacement.Controls.Add(lblPlacement);
            pnlPlacement.Location = new Point(664, 426);
            pnlPlacement.Name = "pnlPlacement";
            pnlPlacement.Size = new Size(408, 217);
            pnlPlacement.TabIndex = 12;
            // 
            // lblRankingTitle
            // 
            lblRankingTitle.BackColor = Color.FromArgb(189, 59, 59);
            lblRankingTitle.Dock = DockStyle.Top;
            lblRankingTitle.Font = new Font("Segoe UI", 36F);
            lblRankingTitle.ForeColor = Color.White;
            lblRankingTitle.Location = new Point(0, 0);
            lblRankingTitle.Name = "lblRankingTitle";
            lblRankingTitle.Size = new Size(408, 65);
            lblRankingTitle.TabIndex = 7;
            lblRankingTitle.Text = "RANKING";
            lblRankingTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlacement
            // 
            lblPlacement.BackColor = Color.FromArgb(189, 59, 59);
            lblPlacement.Dock = DockStyle.Fill;
            lblPlacement.Font = new Font("Segoe UI", 72F);
            lblPlacement.ForeColor = Color.White;
            lblPlacement.Location = new Point(0, 0);
            lblPlacement.Name = "lblPlacement";
            lblPlacement.Size = new Size(408, 217);
            lblPlacement.TabIndex = 8;
            lblPlacement.Text = "#N";
            lblPlacement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGrade
            // 
            pnlGrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlGrade.BackColor = Color.FromArgb(189, 59, 59);
            pnlGrade.Controls.Add(lblGradeTitle);
            pnlGrade.Controls.Add(lblGrade);
            pnlGrade.Location = new Point(664, 172);
            pnlGrade.Name = "pnlGrade";
            pnlGrade.Size = new Size(391, 183);
            pnlGrade.TabIndex = 11;
            // 
            // lblGradeTitle
            // 
            lblGradeTitle.BackColor = Color.FromArgb(189, 59, 59);
            lblGradeTitle.Dock = DockStyle.Top;
            lblGradeTitle.Font = new Font("Segoe UI", 36F);
            lblGradeTitle.ForeColor = Color.White;
            lblGradeTitle.Location = new Point(0, 0);
            lblGradeTitle.Name = "lblGradeTitle";
            lblGradeTitle.Size = new Size(391, 65);
            lblGradeTitle.TabIndex = 5;
            lblGradeTitle.Text = "GRADE";
            lblGradeTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGrade
            // 
            lblGrade.BackColor = Color.FromArgb(189, 59, 59);
            lblGrade.Dock = DockStyle.Bottom;
            lblGrade.Font = new Font("Segoe UI", 72F);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(0, 55);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(391, 128);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "GRADE";
            lblGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinished
            // 
            btnFinished.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinished.BackColor = Color.FromArgb(159, 49, 49);
            btnFinished.FlatAppearance.BorderSize = 0;
            btnFinished.FlatStyle = FlatStyle.Flat;
            btnFinished.Font = new Font("Segoe UI", 21.75F);
            btnFinished.ForeColor = Color.White;
            btnFinished.Location = new Point(664, 649);
            btnFinished.Name = "btnFinished";
            btnFinished.Size = new Size(408, 79);
            btnFinished.TabIndex = 10;
            btnFinished.Text = "▶";
            btnFinished.UseVisualStyleBackColor = false;
            btnFinished.Click += btnFinished_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.FromArgb(189, 59, 59);
            lblScore.Font = new Font("Segoe UI", 36F);
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
            lblIncorrect.Font = new Font("Segoe UI", 36F);
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
            lblCorrect.Font = new Font("Segoe UI", 36F);
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
            lblAchievements.Font = new Font("Segoe UI", 36F);
            lblAchievements.ForeColor = Color.White;
            lblAchievements.Location = new Point(31, 386);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(534, 65);
            lblAchievements.TabIndex = 1;
            lblAchievements.Text = "Achievements Unlocked";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Dock = DockStyle.Top;
            lblUsername.Font = new Font("Segoe UI", 72F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(0, 0);
            lblUsername.Margin = new Padding(3, 20, 3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(0, 20, 0, 0);
            lblUsername.Size = new Size(1176, 128);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "%USERNAME% WINS!";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
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
            pnlPlacement.ResumeLayout(false);
            pnlGrade.ResumeLayout(false);
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
        private Button btnFinished;
        private Panel pnlGrade;
        private Panel pnlPlacement;
    }
}