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
            label1 = new Label();
            tmrLoading = new System.Windows.Forms.Timer(components);
            pnlLoading.SuspendLayout();
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
            ppbLoading.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            ppbLoading.Location = new Point(12, 41);
            ppbLoading.Name = "ppbLoading";
            ppbLoading.ProgressColour = Color.FromArgb(246, 231, 222);
            ppbLoading.Size = new Size(1576, 86);
            ppbLoading.Style = ProgressBarStyle.Continuous;
            ppbLoading.TabIndex = 1;
            ppbLoading.TextColour = Color.FromArgb(246, 231, 222);
            ppbLoading.UsePercentage = true;
            ppbLoading.Click += ppbLoading_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 131);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tmrLoading
            // 
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cwBgWide;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(label1);
            Controls.Add(pnlLoading);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            Text = "Loading Screen";
            WindowState = FormWindowState.Maximized;
            Load += SplashScreen_Load;
            VisibleChanged += SplashScreen_VisibleChanged;
            pnlLoading.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoading;
        private UserControls.PercentageProgressBar ppbLoading;
        private Label label1;
        private System.Windows.Forms.Timer tmrLoading;
    }
}