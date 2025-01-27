namespace Coursework.Forms
{
    partial class AchievementsScreen
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
            percentageProgressBar1 = new UserControls.PercentageProgressBar();
            lblAchievements = new Label();
            btnBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(percentageProgressBar1);
            pnlHeader.Controls.Add(lblAchievements);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 0;
            // 
            // percentageProgressBar1
            // 
            percentageProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            percentageProgressBar1.BackColor = Color.FromArgb(26, 26, 26);
            percentageProgressBar1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            percentageProgressBar1.Location = new Point(967, 34);
            percentageProgressBar1.Name = "percentageProgressBar1";
            percentageProgressBar1.ProgressColour = Color.FromArgb(246, 231, 222);
            percentageProgressBar1.Size = new Size(621, 86);
            percentageProgressBar1.Style = ProgressBarStyle.Continuous;
            percentageProgressBar1.TabIndex = 2;
            percentageProgressBar1.TextColour = Color.FromArgb(246, 231, 222);
            percentageProgressBar1.UsePercentage = true;
            // 
            // lblAchievements
            // 
            lblAchievements.Anchor = AnchorStyles.Left;
            lblAchievements.AutoSize = true;
            lblAchievements.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblAchievements.ForeColor = Color.FromArgb(246, 231, 222);
            lblAchievements.Location = new Point(296, 46);
            lblAchievements.Name = "lblAchievements";
            lblAchievements.Size = new Size(487, 86);
            lblAchievements.TabIndex = 1;
            lblAchievements.Text = "ACHIEVEMENTS";
            lblAchievements.Click += lblAchievements_Click;
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
            btnBack.Click += btnBack_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 156);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1600, 744);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // AchievementsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AchievementsScreen";
            Text = "AchievementsScreen";
            WindowState = FormWindowState.Maximized;
            Load += AchievementsScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnBack;
        private Label lblAchievements;
        private UserControls.PercentageProgressBar percentageProgressBar1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}