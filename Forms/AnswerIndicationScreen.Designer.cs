namespace Coursework.Forms
{
    partial class AnswerIndicationScreen
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
            lblIndicator = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lblIndicator
            // 
            lblIndicator.Anchor = AnchorStyles.None;
            lblIndicator.AutoSize = true;
            lblIndicator.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblIndicator.ForeColor = SystemColors.ButtonHighlight;
            lblIndicator.Location = new Point(229, 148);
            lblIndicator.Name = "lblIndicator";
            lblIndicator.Size = new Size(375, 86);
            lblIndicator.TabIndex = 0;
            lblIndicator.Text = "INDICATOR!";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.None;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(229, 257);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(129, 37);
            lblScore.TabIndex = 1;
            lblScore.Text = "+n Points";
            // 
            // AnswerIndicationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(845, 500);
            Controls.Add(lblScore);
            Controls.Add(lblIndicator);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnswerIndicationScreen";
            Text = "AnswerIndicationScreen";
            WindowState = FormWindowState.Maximized;
            Load += AnswerIndicationScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndicator;
        private Label lblScore;
    }
}