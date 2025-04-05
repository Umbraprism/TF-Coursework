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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerHostScreen));
            pnlHeader = new Panel();
            btnMinimise = new Button();
            btnClose = new Button();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblHost = new Label();
            lblConnected = new Label();
            lblIPAddress = new Label();
            lblPort = new Label();
            btnHost = new Button();
            tmrCheckClientConnections = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(btnMinimise);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblHost);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 156);
            pnlHeader.TabIndex = 1;
            // 
            // btnMinimise
            // 
            btnMinimise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimise.BackColor = Color.FromArgb(189, 59, 59);
            btnMinimise.FlatAppearance.BorderSize = 0;
            btnMinimise.FlatStyle = FlatStyle.Flat;
            btnMinimise.Font = new Font("Segoe UI", 60F);
            btnMinimise.ForeColor = Color.FromArgb(246, 231, 222);
            btnMinimise.Location = new Point(581, 0);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Size = new Size(156, 156);
            btnMinimise.TabIndex = 4;
            btnMinimise.Text = "_";
            btnMinimise.UseVisualStyleBackColor = false;
            btnMinimise.Click += btnMinimise_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(189, 59, 59);
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 60F);
            btnClose.ForeColor = Color.FromArgb(246, 231, 222);
            btnClose.Location = new Point(744, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(156, 156);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ppbAchievementProgress
            // 
            ppbAchievementProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ppbAchievementProgress.BackColor = Color.FromArgb(26, 26, 26);
            ppbAchievementProgress.Font = new Font("Segoe UI", 48F);
            ppbAchievementProgress.Location = new Point(1667, 34);
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
            lblHost.Location = new Point(12, 37);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(198, 86);
            lblHost.TabIndex = 1;
            lblHost.Text = "HOST";
            // 
            // lblConnected
            // 
            lblConnected.AutoSize = true;
            lblConnected.ForeColor = Color.FromArgb(246, 231, 222);
            lblConnected.Location = new Point(12, 576);
            lblConnected.Name = "lblConnected";
            lblConnected.Size = new Size(121, 15);
            lblConnected.TabIndex = 5;
            lblConnected.Text = "Connected Players   n";
            // 
            // lblIPAddress
            // 
            lblIPAddress.Dock = DockStyle.Top;
            lblIPAddress.Font = new Font("Segoe UI", 40F);
            lblIPAddress.ForeColor = Color.FromArgb(246, 231, 222);
            lblIPAddress.Location = new Point(0, 156);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(900, 179);
            lblIPAddress.TabIndex = 2;
            lblIPAddress.Text = "IP Address - ";
            lblIPAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPort
            // 
            lblPort.Dock = DockStyle.Top;
            lblPort.Font = new Font("Segoe UI", 40F);
            lblPort.ForeColor = Color.FromArgb(246, 231, 222);
            lblPort.Location = new Point(0, 335);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(900, 108);
            lblPort.TabIndex = 3;
            lblPort.Text = "Port - ";
            lblPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHost
            // 
            btnHost.BackColor = Color.FromArgb(189, 59, 59);
            btnHost.FlatAppearance.BorderSize = 0;
            btnHost.FlatStyle = FlatStyle.Flat;
            btnHost.Font = new Font("Segoe UI", 36F);
            btnHost.ForeColor = Color.FromArgb(246, 231, 222);
            btnHost.Location = new Point(300, 471);
            btnHost.Name = "btnHost";
            btnHost.Size = new Size(300, 89);
            btnHost.TabIndex = 4;
            btnHost.Text = "HOST";
            btnHost.UseVisualStyleBackColor = false;
            btnHost.Click += btnHost_Click;
            // 
            // tmrCheckClientConnections
            // 
            tmrCheckClientConnections.Interval = 1;
            tmrCheckClientConnections.Tick += tmrCheckClientConnections_Tick;
            // 
            // ServerHostScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(900, 600);
            Controls.Add(lblConnected);
            Controls.Add(btnHost);
            Controls.Add(lblPort);
            Controls.Add(lblIPAddress);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerHostScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hosting Panel";
            Load += ServerHostScreen_Load;
            Shown += ServerHostScreen_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblHost;
        private Button btnClose;
        private Label lblIPAddress;
        private Label lblPort;
        private Button btnMinimise;
        private Button btnHost;
        private System.Windows.Forms.Timer tmrCheckClientConnections;
        private Label lblConnected;
    }
}