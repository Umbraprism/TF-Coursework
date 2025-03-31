namespace Coursework.Forms
{
    partial class ServerClientScreen
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
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblHost = new Label();
            btnBack = new Button();
            lvChat = new ListView();
            rpnlMessage = new UserControls.RoundedPanel();
            tbMessage = new TextBox();
            flpPlayers = new FlowLayoutPanel();
            tmrCheckMessages = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            rpnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblHost);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 1;
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
            lblHost.Location = new Point(296, 46);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(382, 86);
            lblHost.TabIndex = 1;
            lblHost.Text = "CHATROOM";
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
            btnBack.TabIndex = 0;
            btnBack.Text = "❰";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lvChat
            // 
            lvChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvChat.BackColor = Color.FromArgb(41, 39, 39);
            lvChat.BorderStyle = BorderStyle.None;
            lvChat.Font = new Font("Segoe UI", 20F);
            lvChat.ForeColor = Color.FromArgb(246, 231, 222);
            lvChat.Location = new Point(694, 186);
            lvChat.Name = "lvChat";
            lvChat.Size = new Size(894, 628);
            lvChat.TabIndex = 2;
            lvChat.UseCompatibleStateImageBehavior = false;
            // 
            // rpnlMessage
            // 
            rpnlMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rpnlMessage.BorderColour = Color.Transparent;
            rpnlMessage.BorderSize = 0;
            rpnlMessage.Controls.Add(tbMessage);
            rpnlMessage.Location = new Point(694, 820);
            rpnlMessage.Name = "rpnlMessage";
            rpnlMessage.PanelColour = Color.White;
            rpnlMessage.Radius = 30;
            rpnlMessage.Size = new Size(894, 68);
            rpnlMessage.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlMessage.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.BorderStyle = BorderStyle.None;
            tbMessage.Font = new Font("Segoe UI", 30F);
            tbMessage.Location = new Point(3, 11);
            tbMessage.MaxLength = 20;
            tbMessage.Name = "tbMessage";
            tbMessage.PlaceholderText = "Send Chat";
            tbMessage.Size = new Size(891, 54);
            tbMessage.TabIndex = 0;
            tbMessage.KeyDown += tbUsername_KeyDown;
            // 
            // flpPlayers
            // 
            flpPlayers.Location = new Point(12, 186);
            flpPlayers.Name = "flpPlayers";
            flpPlayers.Size = new Size(676, 702);
            flpPlayers.TabIndex = 4;
            // 
            // tmrCheckMessages
            // 
            tmrCheckMessages.Tick += tmrCheckMessages_Tick;
            // 
            // ServerClientScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(flpPlayers);
            Controls.Add(rpnlMessage);
            Controls.Add(lvChat);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServerClientScreen";
            Text = "Online Match";
            WindowState = FormWindowState.Maximized;
            Load += ServerHostScreen_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            rpnlMessage.ResumeLayout(false);
            rpnlMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private UserControls.PercentageProgressBar ppbAchievementProgress;
        private Label lblHost;
        private Button btnBack;
        private ListView lvChat;
        private UserControls.RoundedPanel rpnlMessage;
        private TextBox tbMessage;
        private FlowLayoutPanel flpPlayers;
        private System.Windows.Forms.Timer tmrCheckMessages;
    }
}