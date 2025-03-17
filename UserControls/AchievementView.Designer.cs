namespace Coursework.UserControls
{
    partial class AchievementView
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
            components = new System.ComponentModel.Container();
            lblAchievementName = new Label();
            lblAchievementDescription = new Label();
            pbIsAchieved = new PictureBox();
            ttRareAchievement = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pbIsAchieved).BeginInit();
            SuspendLayout();
            // 
            // lblAchievementName
            // 
            lblAchievementName.AutoSize = true;
            lblAchievementName.Font = new Font("Segoe UI", 15.75F);
            lblAchievementName.ForeColor = Color.FromArgb(246, 231, 222);
            lblAchievementName.Location = new Point(140, 13);
            lblAchievementName.Name = "lblAchievementName";
            lblAchievementName.Size = new Size(219, 30);
            lblAchievementName.TabIndex = 1;
            lblAchievementName.Text = "ACHIEVEMENT NAME";
            // 
            // lblAchievementDescription
            // 
            lblAchievementDescription.AutoSize = true;
            lblAchievementDescription.Font = new Font("Segoe UI", 9F);
            lblAchievementDescription.ForeColor = Color.FromArgb(246, 231, 222);
            lblAchievementDescription.Location = new Point(140, 54);
            lblAchievementDescription.MaximumSize = new Size(240, 0);
            lblAchievementDescription.MinimumSize = new Size(240, 0);
            lblAchievementDescription.Name = "lblAchievementDescription";
            lblAchievementDescription.Size = new Size(240, 15);
            lblAchievementDescription.TabIndex = 2;
            lblAchievementDescription.Text = "ACHIEVEMENT DESCRIPTION";
            // 
            // pbIsAchieved
            // 
            pbIsAchieved.BackColor = Color.FromArgb(200, 26, 26, 26);
            pbIsAchieved.Location = new Point(13, 13);
            pbIsAchieved.Name = "pbIsAchieved";
            pbIsAchieved.Size = new Size(121, 121);
            pbIsAchieved.SizeMode = PictureBoxSizeMode.Zoom;
            pbIsAchieved.TabIndex = 3;
            pbIsAchieved.TabStop = false;
            // 
            // ttRareAchievement
            // 
            ttRareAchievement.BackColor = Color.FromArgb(41, 39, 39);
            ttRareAchievement.ForeColor = Color.FromArgb(246, 231, 222);
            ttRareAchievement.OwnerDraw = true;
            ttRareAchievement.Draw += ttRareAchievement_Draw;
            ttRareAchievement.Popup += ttRareAchievement_Popup;
            // 
            // AchievementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            Controls.Add(pbIsAchieved);
            Controls.Add(lblAchievementDescription);
            Controls.Add(lblAchievementName);
            Name = "AchievementView";
            Size = new Size(388, 147);
            Load += AchievementView_Load;
            ((System.ComponentModel.ISupportInitialize)pbIsAchieved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAchievementName;
        private Label lblAchievementDescription;
        private PictureBox pbIsAchieved;
        private ToolTip ttRareAchievement;
    }
}
