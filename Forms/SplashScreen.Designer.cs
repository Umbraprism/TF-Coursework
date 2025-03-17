namespace Coursework.Forms
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pnlLoading = new Panel();
            ppbLoading = new UserControls.PercentageProgressBar();
            lblOnWayTo = new Label();
            tmrLoading = new System.Windows.Forms.Timer(components);
            pnlInfo = new Panel();
            pnlTip = new Panel();
            lblTipText = new Label();
            lblTip = new Label();
            pnlOnWayTo = new Panel();
            lblYoureOnWayTo = new Label();
            pnlClassName = new Panel();
            lblTFClassName = new Label();
            pbClassImage = new PictureBox();
            pnlLoading.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlTip.SuspendLayout();
            pnlOnWayTo.SuspendLayout();
            pnlClassName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClassImage).BeginInit();
            SuspendLayout();
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.FromArgb(54, 49, 45);
            pnlLoading.Controls.Add(ppbLoading);
            pnlLoading.Dock = DockStyle.Bottom;
            pnlLoading.Location = new Point(0, 744);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(1600, 156);
            pnlLoading.TabIndex = 0;
            // 
            // ppbLoading
            // 
            ppbLoading.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ppbLoading.BackColor = Color.FromArgb(41, 39, 39);
            ppbLoading.Font = new Font("Segoe UI", 48F);
            ppbLoading.Location = new Point(12, 41);
            ppbLoading.Name = "ppbLoading";
            ppbLoading.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbLoading.Size = new Size(1576, 86);
            ppbLoading.Style = ProgressBarStyle.Continuous;
            ppbLoading.TabIndex = 1;
            ppbLoading.Text = "PERCENTAGE";
            ppbLoading.TextColour = Color.FromArgb(246, 231, 222);
            ppbLoading.UsePercentage = true;
            // 
            // lblOnWayTo
            // 
            lblOnWayTo.Dock = DockStyle.Fill;
            lblOnWayTo.Font = new Font("Segoe UI", 48F);
            lblOnWayTo.ForeColor = Color.FromArgb(246, 231, 222);
            lblOnWayTo.Location = new Point(0, 0);
            lblOnWayTo.Name = "lblOnWayTo";
            lblOnWayTo.Size = new Size(649, 238);
            lblOnWayTo.TabIndex = 1;
            lblOnWayTo.Text = "NextForm";
            lblOnWayTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrLoading
            // 
            tmrLoading.Interval = 1;
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(45, 41, 39);
            pnlInfo.Controls.Add(pnlTip);
            pnlInfo.Controls.Add(pnlOnWayTo);
            pnlInfo.Controls.Add(pnlClassName);
            pnlInfo.Dock = DockStyle.Right;
            pnlInfo.Location = new Point(892, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(708, 744);
            pnlInfo.TabIndex = 2;
            // 
            // pnlTip
            // 
            pnlTip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlTip.BackColor = Color.FromArgb(41, 39, 39);
            pnlTip.Controls.Add(lblTipText);
            pnlTip.Controls.Add(lblTip);
            pnlTip.Location = new Point(35, 448);
            pnlTip.Margin = new Padding(3, 3, 30, 3);
            pnlTip.MaximumSize = new Size(749, 0);
            pnlTip.Name = "pnlTip";
            pnlTip.Size = new Size(649, 271);
            pnlTip.TabIndex = 2;
            // 
            // lblTipText
            // 
            lblTipText.AutoSize = true;
            lblTipText.Font = new Font("Segoe UI", 12F);
            lblTipText.ForeColor = Color.FromArgb(246, 231, 222);
            lblTipText.Location = new Point(6, 41);
            lblTipText.MaximumSize = new Size(637, 0);
            lblTipText.MinimumSize = new Size(637, 0);
            lblTipText.Name = "lblTipText";
            lblTipText.Size = new Size(637, 21);
            lblTipText.TabIndex = 1;
            lblTipText.Text = "tipText";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 18F);
            lblTip.ForeColor = Color.FromArgb(246, 231, 222);
            lblTip.Location = new Point(6, 9);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(46, 32);
            lblTip.TabIndex = 0;
            lblTip.Text = "TIP";
            // 
            // pnlOnWayTo
            // 
            pnlOnWayTo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOnWayTo.BackColor = Color.FromArgb(41, 39, 39);
            pnlOnWayTo.Controls.Add(lblYoureOnWayTo);
            pnlOnWayTo.Controls.Add(lblOnWayTo);
            pnlOnWayTo.Location = new Point(35, 187);
            pnlOnWayTo.Name = "pnlOnWayTo";
            pnlOnWayTo.Size = new Size(649, 238);
            pnlOnWayTo.TabIndex = 1;
            // 
            // lblYoureOnWayTo
            // 
            lblYoureOnWayTo.BackColor = Color.Transparent;
            lblYoureOnWayTo.Dock = DockStyle.Top;
            lblYoureOnWayTo.Font = new Font("Segoe UI", 24F);
            lblYoureOnWayTo.ForeColor = Color.FromArgb(246, 231, 222);
            lblYoureOnWayTo.Location = new Point(0, 0);
            lblYoureOnWayTo.Margin = new Padding(3, 20, 3, 0);
            lblYoureOnWayTo.Name = "lblYoureOnWayTo";
            lblYoureOnWayTo.Padding = new Padding(0, 12, 0, 0);
            lblYoureOnWayTo.Size = new Size(649, 69);
            lblYoureOnWayTo.TabIndex = 0;
            lblYoureOnWayTo.Text = "YOU'RE ON YOUR WAY TO...";
            lblYoureOnWayTo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlClassName
            // 
            pnlClassName.BackColor = Color.FromArgb(41, 39, 39);
            pnlClassName.Controls.Add(lblTFClassName);
            pnlClassName.Location = new Point(35, 28);
            pnlClassName.Name = "pnlClassName";
            pnlClassName.Size = new Size(649, 131);
            pnlClassName.TabIndex = 0;
            // 
            // lblTFClassName
            // 
            lblTFClassName.Dock = DockStyle.Fill;
            lblTFClassName.Font = new Font("Segoe UI", 48F);
            lblTFClassName.ForeColor = Color.FromArgb(246, 231, 222);
            lblTFClassName.Location = new Point(0, 0);
            lblTFClassName.Name = "lblTFClassName";
            lblTFClassName.Size = new Size(649, 131);
            lblTFClassName.TabIndex = 0;
            lblTFClassName.Text = "THE CLASS";
            lblTFClassName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbClassImage
            // 
            pbClassImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbClassImage.BackColor = Color.Transparent;
            pbClassImage.Location = new Point(0, 0);
            pbClassImage.Name = "pbClassImage";
            pbClassImage.Size = new Size(892, 744);
            pbClassImage.TabIndex = 3;
            pbClassImage.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(pnlInfo);
            Controls.Add(pnlLoading);
            Controls.Add(pbClassImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            Text = "Loading Screen";
            WindowState = FormWindowState.Maximized;
            Load += SplashScreen_Load;
            VisibleChanged += SplashScreen_VisibleChanged;
            pnlLoading.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlTip.ResumeLayout(false);
            pnlTip.PerformLayout();
            pnlOnWayTo.ResumeLayout(false);
            pnlClassName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClassImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoading;
        private UserControls.PercentageProgressBar ppbLoading;
        private Label lblOnWayTo;
        private System.Windows.Forms.Timer tmrLoading;
        private Panel pnlInfo;
        private Panel pnlClassName;
        private Label lblTFClassName;
        private Panel pnlOnWayTo;
        private Label lblYoureOnWayTo;
        private Panel pnlTip;
        private Label lblTipText;
        private Label lblTip;
        private PictureBox pbClassImage;
    }
}