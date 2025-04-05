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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerClientScreen));
            pnlHeader = new Panel();
            btnConnect = new Button();
            ppbAchievementProgress = new UserControls.PercentageProgressBar();
            lblHost = new Label();
            btnBack = new Button();
            rpnlMessage = new UserControls.RoundedPanel();
            tbMessage = new TextBox();
            btnSend = new Button();
            tmrCheckMessages = new System.Windows.Forms.Timer(components);
            lvChat = new ListView();
            pnlHeader.SuspendLayout();
            rpnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(btnConnect);
            pnlHeader.Controls.Add(ppbAchievementProgress);
            pnlHeader.Controls.Add(lblHost);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1600, 156);
            pnlHeader.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnect.BackColor = Color.FromArgb(189, 59, 59);
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 30F);
            btnConnect.ForeColor = Color.FromArgb(246, 231, 222);
            btnConnect.Location = new Point(1312, 46);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(276, 67);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.TextAlign = ContentAlignment.TopCenter;
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
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
            // rpnlMessage
            // 
            rpnlMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rpnlMessage.BorderColour = Color.Transparent;
            rpnlMessage.BorderSize = 0;
            rpnlMessage.Controls.Add(tbMessage);
            rpnlMessage.Location = new Point(12, 811);
            rpnlMessage.Name = "rpnlMessage";
            rpnlMessage.PanelColour = Color.White;
            rpnlMessage.Radius = 30;
            rpnlMessage.Size = new Size(1294, 68);
            rpnlMessage.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlMessage.TabIndex = 3;
            // 
            // tbMessage
            // 
            tbMessage.BorderStyle = BorderStyle.None;
            tbMessage.Font = new Font("Segoe UI", 30F);
            tbMessage.Location = new Point(3, 11);
            tbMessage.MaxLength = 65536;
            tbMessage.Name = "tbMessage";
            tbMessage.PlaceholderText = "Send Chat";
            tbMessage.Size = new Size(1288, 54);
            tbMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackColor = Color.FromArgb(189, 59, 59);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 30F);
            btnSend.ForeColor = Color.FromArgb(246, 231, 222);
            btnSend.Location = new Point(1312, 812);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(276, 67);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.TextAlign = ContentAlignment.TopCenter;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // tmrCheckMessages
            // 
            tmrCheckMessages.Interval = 1;
            tmrCheckMessages.Tick += tmrCheckMessages_Tick;
            // 
            // lvChat
            // 
            lvChat.BackColor = Color.FromArgb(41, 39, 39);
            lvChat.BorderStyle = BorderStyle.None;
            lvChat.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvChat.ForeColor = Color.FromArgb(246, 231, 222);
            lvChat.LabelWrap = false;
            lvChat.Location = new Point(15, 175);
            lvChat.Name = "lvChat";
            lvChat.Size = new Size(1573, 612);
            lvChat.TabIndex = 6;
            lvChat.UseCompatibleStateImageBehavior = false;
            lvChat.View = View.List;
            // 
            // ServerClientScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(1600, 900);
            Controls.Add(lvChat);
            Controls.Add(btnSend);
            Controls.Add(rpnlMessage);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerClientScreen";
            Text = "Chatroom";
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
        private UserControls.RoundedPanel rpnlMessage;
        private TextBox tbMessage;
        private Button btnSend;
        private Button btnConnect;
        private System.Windows.Forms.Timer tmrCheckMessages;
        private ListView lvChat;
    }
}