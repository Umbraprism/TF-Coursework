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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AchievementsScreen));
            pnlHeader = new Panel();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblAchievements = new Label();
            btnBack = new Button();
            flpAchievements = new FlowLayoutPanel();
            ttMyAchievementProgress = new ToolTip(components);
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblAchievements);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 0;
            // 
            // ppbAchievementProgress
            // 
            ppbAchievementProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ppbAchievementProgress.BackColor = Color.FromArgb(26, 26, 26);
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            ppbAchievementProgress.Location = new Point(967, 34);
            ppbAchievementProgress.Name = "ppbAchievementProgress";
            ppbAchievementProgress.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbAchievementProgress.Size = new Size(621, 86);
            ppbAchievementProgress.Style = ProgressBarStyle.Continuous;
            ppbAchievementProgress.TabIndex = 2;
            ppbAchievementProgress.Text = "PERCENTAGE";
            ppbAchievementProgress.TextColour = Color.FromArgb(246, 231, 222);
            ttMyAchievementProgress.SetToolTip(ppbAchievementProgress, "This is the percentage of achievements you have completed.");
            ppbAchievementProgress.UsePercentage = true;
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
            // flpAchievements
            // 
            flpAchievements.AutoScroll = true;
            flpAchievements.AutoSize = true;
            flpAchievements.Dock = DockStyle.Fill;
            flpAchievements.Location = new Point(0, 156);
            flpAchievements.Name = "flpAchievements";
            flpAchievements.Size = new Size(1600, 744);
            flpAchievements.TabIndex = 1;
            // 
            // ttMyAchievementProgress
            // 
            ttMyAchievementProgress.BackColor = Color.FromArgb(41, 39, 39);
            ttMyAchievementProgress.ForeColor = Color.FromArgb(246, 231, 222);
            ttMyAchievementProgress.OwnerDraw = true;
            ttMyAchievementProgress.UseAnimation = false;
            ttMyAchievementProgress.UseFading = false;
            ttMyAchievementProgress.Draw += ttMyAchievementProgress_Draw;
            ttMyAchievementProgress.Popup += ttMyAchievementProgress_Popup;
            // 
            // AchievementsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(flpAchievements);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AchievementsScreen";
            Text = "AchievementsScreen";
            WindowState = FormWindowState.Maximized;
            Load += AchievementsScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnBack;
        private Label lblAchievements;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private FlowLayoutPanel flpAchievements;
        private ToolTip ttMyAchievementProgress;
    }
}