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
            lblUsedByIndicator = new Label();
            lblSlotIndicator = new Label();
            lblUpdateIndicator = new Label();
            lblGuessedWeaponIndicator = new Label();
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
            rpnlGuessedWeapon.Controls.Add(lblGuessedWeaponIndicator);
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
            lblGuessedWeapon.BackColor = Color.Transparent;
            lblGuessedWeapon.Dock = DockStyle.Fill;
            lblGuessedWeapon.Font = new Font("Segoe UI", 14.25F);
            lblGuessedWeapon.ForeColor = Color.FromArgb(246, 231, 222);
            lblGuessedWeapon.Location = new Point(0, 0);
            lblGuessedWeapon.Name = "lblGuessedWeapon";
            lblGuessedWeapon.Size = new Size(305, 100);
            lblGuessedWeapon.TabIndex = 4;
            lblGuessedWeapon.Text = "Guessed Weapon";
            lblGuessedWeapon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpnlUsedBy
            // 
            rpnlUsedBy.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlUsedBy.BorderSize = 0;
            rpnlUsedBy.Controls.Add(lblUsedByIndicator);
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
            lblUsedBy.BackColor = Color.Transparent;
            lblUsedBy.Dock = DockStyle.Fill;
            lblUsedBy.Font = new Font("Segoe UI", 14.25F);
            lblUsedBy.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsedBy.Location = new Point(0, 0);
            lblUsedBy.Name = "lblUsedBy";
            lblUsedBy.Size = new Size(186, 100);
            lblUsedBy.TabIndex = 5;
            lblUsedBy.Text = "UsedBy";
            lblUsedBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpnlSlot
            // 
            rpnlSlot.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlSlot.BorderSize = 0;
            rpnlSlot.Controls.Add(lblSlotIndicator);
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
            lblSlot.BackColor = Color.Transparent;
            lblSlot.Dock = DockStyle.Fill;
            lblSlot.Font = new Font("Segoe UI", 14.25F);
            lblSlot.ForeColor = Color.FromArgb(246, 231, 222);
            lblSlot.Location = new Point(0, 0);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(186, 100);
            lblSlot.TabIndex = 5;
            lblSlot.Text = "Slot";
            lblSlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpnlUpdate
            // 
            rpnlUpdate.BorderColour = Color.FromArgb(114, 158, 66);
            rpnlUpdate.BorderSize = 0;
            rpnlUpdate.Controls.Add(lblUpdateIndicator);
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
            lblUpdate.BackColor = Color.Transparent;
            lblUpdate.Dock = DockStyle.Fill;
            lblUpdate.Font = new Font("Segoe UI", 14.25F);
            lblUpdate.ForeColor = Color.FromArgb(246, 231, 222);
            lblUpdate.Location = new Point(0, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(186, 100);
            lblUpdate.TabIndex = 5;
            lblUpdate.Text = "Update";
            lblUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsedByIndicator
            // 
            lblUsedByIndicator.BackColor = Color.Transparent;
            lblUsedByIndicator.Dock = DockStyle.Top;
            lblUsedByIndicator.ForeColor = Color.FromArgb(246, 231, 222);
            lblUsedByIndicator.Location = new Point(0, 0);
            lblUsedByIndicator.Name = "lblUsedByIndicator";
            lblUsedByIndicator.Size = new Size(186, 34);
            lblUsedByIndicator.TabIndex = 4;
            lblUsedByIndicator.Text = "USED BY";
            lblUsedByIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSlotIndicator
            // 
            lblSlotIndicator.BackColor = Color.Transparent;
            lblSlotIndicator.Dock = DockStyle.Top;
            lblSlotIndicator.ForeColor = Color.FromArgb(246, 231, 222);
            lblSlotIndicator.Location = new Point(0, 0);
            lblSlotIndicator.Name = "lblSlotIndicator";
            lblSlotIndicator.Size = new Size(186, 34);
            lblSlotIndicator.TabIndex = 6;
            lblSlotIndicator.Text = "SLOT";
            lblSlotIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUpdateIndicator
            // 
            lblUpdateIndicator.BackColor = Color.Transparent;
            lblUpdateIndicator.Dock = DockStyle.Top;
            lblUpdateIndicator.ForeColor = Color.FromArgb(246, 231, 222);
            lblUpdateIndicator.Location = new Point(0, 0);
            lblUpdateIndicator.Name = "lblUpdateIndicator";
            lblUpdateIndicator.Size = new Size(186, 34);
            lblUpdateIndicator.TabIndex = 6;
            lblUpdateIndicator.Text = "UPDATE";
            lblUpdateIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuessedWeaponIndicator
            // 
            lblGuessedWeaponIndicator.BackColor = Color.Transparent;
            lblGuessedWeaponIndicator.Dock = DockStyle.Top;
            lblGuessedWeaponIndicator.ForeColor = Color.FromArgb(246, 231, 222);
            lblGuessedWeaponIndicator.Location = new Point(0, 0);
            lblGuessedWeaponIndicator.Name = "lblGuessedWeaponIndicator";
            lblGuessedWeaponIndicator.Size = new Size(305, 34);
            lblGuessedWeaponIndicator.TabIndex = 5;
            lblGuessedWeaponIndicator.Text = "GUESSED WEAPON";
            lblGuessedWeaponIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(rpnlUpdate);
            Controls.Add(rpnlSlot);
            Controls.Add(rpnlUsedBy);
            Controls.Add(rpnlGuessedWeapon);
            Name = "Guess";
            Size = new Size(1084, 150);
            Load += Guess_Load;
            rpnlGuessedWeapon.ResumeLayout(false);
            rpnlUsedBy.ResumeLayout(false);
            rpnlSlot.ResumeLayout(false);
            rpnlUpdate.ResumeLayout(false);
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
        private Label lblUsedByIndicator;
        private Label lblGuessedWeaponIndicator;
        private Label lblSlotIndicator;
        private Label lblUpdateIndicator;
    }
}
