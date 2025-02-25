namespace Coursework.UserControls
{
    partial class Guess
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
            rpnlGuessedWeapon = new RoundedPanel();
            lblGuessedWeapon = new Label();
            rpnlUsedBy = new RoundedPanel();
            lblUsedBy = new Label();
            rpnlSlot = new RoundedPanel();
            lblSlot = new Label();
            rpnlUpdate = new RoundedPanel();
            lblUpdate = new Label();
            rpnlGuessedWeapon.SuspendLayout();
            rpnlUsedBy.SuspendLayout();
            rpnlSlot.SuspendLayout();
            rpnlUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // rpnlGuessedWeapon
            // 
            rpnlGuessedWeapon.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlGuessedWeapon.BorderSize = 0;
            rpnlGuessedWeapon.Controls.Add(lblGuessedWeapon);
            rpnlGuessedWeapon.Location = new Point(12, 24);
            rpnlGuessedWeapon.Name = "rpnlGuessedWeapon";
            rpnlGuessedWeapon.PanelColour = Color.FromArgb(114, 158, 66);
            rpnlGuessedWeapon.Radius = 50;
            rpnlGuessedWeapon.Size = new Size(305, 100);
            rpnlGuessedWeapon.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlGuessedWeapon.TabIndex = 0;
            // 
            // lblGuessedWeapon
            // 
            lblGuessedWeapon.Anchor = AnchorStyles.None;
            lblGuessedWeapon.AutoSize = true;
            lblGuessedWeapon.BackColor = Color.FromArgb(114, 158, 66);
            lblGuessedWeapon.Font = new Font("Segoe UI", 14.25F);
            lblGuessedWeapon.ForeColor = Color.FromArgb(246, 231, 222);
            lblGuessedWeapon.Location = new Point(71, 37);
            lblGuessedWeapon.Name = "lblGuessedWeapon";
            lblGuessedWeapon.Size = new Size(158, 25);
            lblGuessedWeapon.TabIndex = 4;
            lblGuessedWeapon.Text = "Guessed Weapon";
            // 
            // rpnlUsedBy
            // 
            rpnlUsedBy.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlUsedBy.BorderSize = 0;
            rpnlUsedBy.Controls.Add(lblUsedBy);
            rpnlUsedBy.Location = new Point(421, 24);
            rpnlUsedBy.Name = "rpnlUsedBy";
            rpnlUsedBy.PanelColour = Color.FromArgb(114, 158, 66);
            rpnlUsedBy.Radius = 50;
            rpnlUsedBy.Size = new Size(186, 100);
            rpnlUsedBy.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlUsedBy.TabIndex = 1;
            // 
            // lblUsedBy
            // 
            lblUsedBy.Anchor = AnchorStyles.None;
            lblUsedBy.AutoSize = true;
            lblUsedBy.BackColor = Color.FromArgb(114, 158, 66);
            lblUsedBy.Font = new Font("Segoe UI", 14.25F);
            lblUsedBy.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsedBy.Location = new Point(52, 38);
            lblUsedBy.Name = "lblUsedBy";
            lblUsedBy.Size = new Size(74, 25);
            lblUsedBy.TabIndex = 5;
            lblUsedBy.Text = "UsedBy";
            // 
            // rpnlSlot
            // 
            rpnlSlot.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlSlot.BorderSize = 0;
            rpnlSlot.Controls.Add(lblSlot);
            rpnlSlot.Location = new Point(643, 24);
            rpnlSlot.Name = "rpnlSlot";
            rpnlSlot.PanelColour = Color.FromArgb(114, 158, 66);
            rpnlSlot.Radius = 50;
            rpnlSlot.Size = new Size(186, 100);
            rpnlSlot.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlSlot.TabIndex = 2;
            // 
            // lblSlot
            // 
            lblSlot.Anchor = AnchorStyles.None;
            lblSlot.AutoSize = true;
            lblSlot.BackColor = Color.FromArgb(114, 158, 66);
            lblSlot.Font = new Font("Segoe UI", 14.25F);
            lblSlot.ForeColor = Color.FromArgb(246, 231, 222);
            lblSlot.Location = new Point(68, 38);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(44, 25);
            lblSlot.TabIndex = 5;
            lblSlot.Text = "Slot";
            // 
            // rpnlUpdate
            // 
            rpnlUpdate.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlUpdate.BorderSize = 0;
            rpnlUpdate.Controls.Add(lblUpdate);
            rpnlUpdate.Location = new Point(865, 24);
            rpnlUpdate.Name = "rpnlUpdate";
            rpnlUpdate.PanelColour = Color.FromArgb(114, 158, 66);
            rpnlUpdate.Radius = 50;
            rpnlUpdate.Size = new Size(186, 100);
            rpnlUpdate.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            rpnlUpdate.TabIndex = 3;
            // 
            // lblUpdate
            // 
            lblUpdate.Anchor = AnchorStyles.None;
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.FromArgb(114, 158, 66);
            lblUpdate.Font = new Font("Segoe UI", 14.25F);
            lblUpdate.ForeColor = Color.FromArgb(246, 231, 222);
            lblUpdate.Location = new Point(53, 37);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(73, 25);
            lblUpdate.TabIndex = 5;
            lblUpdate.Text = "Update";
            // 
            // Guess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            Controls.Add(rpnlUpdate);
            Controls.Add(rpnlSlot);
            Controls.Add(rpnlUsedBy);
            Controls.Add(rpnlGuessedWeapon);
            Name = "Guess";
            Size = new Size(1084, 150);
            Load += Guess_Load;
            rpnlGuessedWeapon.ResumeLayout(false);
            rpnlGuessedWeapon.PerformLayout();
            rpnlUsedBy.ResumeLayout(false);
            rpnlUsedBy.PerformLayout();
            rpnlSlot.ResumeLayout(false);
            rpnlSlot.PerformLayout();
            rpnlUpdate.ResumeLayout(false);
            rpnlUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel rpnlGuessedWeapon;
        private Label lblGuessedWeapon;
        private RoundedPanel rpnlUsedBy;
        private RoundedPanel rpnlSlot;
        private RoundedPanel rpnlUpdate;
        private Label lblUsedBy;
        private Label lblSlot;
        private Label lblUpdate;
    }
}
