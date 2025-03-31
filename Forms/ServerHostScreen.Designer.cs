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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            btnBack = new Button();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblHost = new Label();
            flpPlayers = new FlowLayoutPanel();
            tmrCheckClients = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblHost);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 1;
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
            btnBack.TabIndex = 3;
            btnBack.Text = "❰";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            lblHost.Location = new Point(296, 39);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(198, 86);
            lblHost.TabIndex = 1;
            lblHost.Text = "HOST";
            // 
            // flpPlayers
            // 
            flpPlayers.Location = new Point(12, 165);
            flpPlayers.Name = "flpPlayers";
            flpPlayers.Size = new Size(1576, 726);
            flpPlayers.TabIndex = 4;
            // 
            // tmrCheckClients
            // 
            tmrCheckClients.Tick += tmrCheckClients_Tick;
            // 
            // ServerHostScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(flpPlayers);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServerHostScreen";
            Text = "Online Match";
            WindowState = FormWindowState.Maximized;
            Load += ServerHostScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblHost;
        private FlowLayoutPanel flpPlayers;
        private System.Windows.Forms.Timer tmrCheckClients;
        private Button btnBack;
    }
}