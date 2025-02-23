namespace Coursework.UserControls
{
    partial class PlayerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbAvatar = new PictureBox();
            lblUsername = new Label();
            lblRank = new Label();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.FromArgb(26, 26, 26);
            pbAvatar.Location = new Point(13, 20);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(152, 152);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsername.Location = new Point(171, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(136, 37);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRank.ForeColor = Color.FromArgb(246, 231, 222);
            lblRank.Location = new Point(171, 85);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(102, 50);
            lblRank.TabIndex = 2;
            lblRank.Text = "Rank";
            // 
            // PlayerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 39, 39);
            Controls.Add(lblRank);
            Controls.Add(lblUsername);
            Controls.Add(pbAvatar);
            Name = "PlayerView";
            Size = new Size(490, 196);
            Load += PlayerView_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAvatar;
        private Label lblUsername;
        private Label lblRank;
    }
}
