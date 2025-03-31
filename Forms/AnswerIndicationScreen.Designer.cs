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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerIndicationScreen));
            lblIndicator = new Label();
            lblScore = new Label();
            lblCorrectAnswer = new Label();
            SuspendLayout();
            // 
            // lblIndicator
            // 
            lblIndicator.Dock = DockStyle.Top;
            lblIndicator.Font = new Font("Segoe UI", 48F);
            lblIndicator.ForeColor = Color.FromArgb(246, 231, 222);
            lblIndicator.Location = new Point(0, 0);
            lblIndicator.Name = "lblIndicator";
            lblIndicator.Size = new Size(845, 273);
            lblIndicator.TabIndex = 0;
            lblIndicator.Text = "INDICATOR!";
            lblIndicator.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.Transparent;
            lblScore.Dock = DockStyle.Top;
            lblScore.Font = new Font("Segoe UI", 20F);
            lblScore.ForeColor = Color.FromArgb(246, 231, 222);
            lblScore.Location = new Point(0, 273);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(845, 61);
            lblScore.TabIndex = 1;
            lblScore.Text = "+n Points";
            lblScore.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCorrectAnswer
            // 
            lblCorrectAnswer.BackColor = Color.Transparent;
            lblCorrectAnswer.Dock = DockStyle.Bottom;
            lblCorrectAnswer.Font = new Font("Segoe UI", 20F);
            lblCorrectAnswer.ForeColor = Color.FromArgb(246, 231, 222);
            lblCorrectAnswer.Location = new Point(0, 370);
            lblCorrectAnswer.Name = "lblCorrectAnswer";
            lblCorrectAnswer.Size = new Size(845, 130);
            lblCorrectAnswer.TabIndex = 2;
            lblCorrectAnswer.Text = "Correct Answer - ";
            lblCorrectAnswer.TextAlign = ContentAlignment.TopCenter;
            lblCorrectAnswer.Visible = false;
            // 
            // AnswerIndicationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 48, 46);
            ClientSize = new Size(845, 500);
            Controls.Add(lblCorrectAnswer);
            Controls.Add(lblScore);
            Controls.Add(lblIndicator);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnswerIndicationScreen";
            Text = "Indicator";
            WindowState = FormWindowState.Maximized;
            Load += AnswerIndicationScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblIndicator;
        private Label lblScore;
        private Label lblCorrectAnswer;
    }
}