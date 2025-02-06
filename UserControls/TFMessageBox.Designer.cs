namespace Coursework.UserControls
{
    partial class TFMessageBox
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblMessage = new Label();
            tlpYesAndNo = new TableLayoutPanel();
            btnNo = new Button();
            btnYes = new Button();
            btnOk = new Button();
            pnlHeader.SuspendLayout();
            tlpYesAndNo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 39, 39);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(552, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(246, 231, 222);
            lblTitle.Location = new Point(12, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TITLE";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(246, 231, 222);
            lblMessage.Location = new Point(12, 110);
            lblMessage.MaximumSize = new Size(530, 0);
            lblMessage.MinimumSize = new Size(530, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(530, 25);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message";
            // 
            // tlpYesAndNo
            // 
            tlpYesAndNo.ColumnCount = 2;
            tlpYesAndNo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpYesAndNo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpYesAndNo.Controls.Add(btnNo, 1, 0);
            tlpYesAndNo.Controls.Add(btnYes, 0, 0);
            tlpYesAndNo.Location = new Point(12, 297);
            tlpYesAndNo.Name = "tlpYesAndNo";
            tlpYesAndNo.RowCount = 1;
            tlpYesAndNo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpYesAndNo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpYesAndNo.Size = new Size(528, 86);
            tlpYesAndNo.TabIndex = 2;
            // 
            // btnNo
            // 
            btnNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnNo.BackColor = Color.FromArgb(189, 59, 59);
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.ForeColor = Color.FromArgb(246, 231, 222);
            btnNo.Location = new Point(288, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(216, 80);
            btnNo.TabIndex = 8;
            btnNo.Tag = "No";
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnYes.BackColor = Color.FromArgb(189, 59, 59);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.ForeColor = Color.FromArgb(246, 231, 222);
            btnYes.Location = new Point(24, 3);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(216, 80);
            btnYes.TabIndex = 7;
            btnYes.Tag = "Yes";
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnOk.BackColor = Color.FromArgb(189, 59, 59);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.FromArgb(246, 231, 222);
            btnOk.Location = new Point(300, 303);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(216, 80);
            btnOk.TabIndex = 9;
            btnOk.Tag = "OK";
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // TFMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(552, 395);
            Controls.Add(tlpYesAndNo);
            Controls.Add(btnOk);
            Controls.Add(lblMessage);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TFMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TFMessageBox";
            Load += TFMessageBox_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpYesAndNo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblMessage;
        private TableLayoutPanel tlpYesAndNo;
        private Button btnNo;
        private Button btnYes;
        private Button btnOk;
    }
}