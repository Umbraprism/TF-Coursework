using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Helpers;

namespace Coursework.Forms
{
    public partial class AnswerIndicationScreen : Form
    {
        private int score;
        private bool isCorrect = false;
        public AnswerIndicationScreen(int score)
        {
            this.score = score;
            InitializeComponent();
        }

        private void AnswerIndicationScreen_Load(object sender, EventArgs e) // change to appropriate colours soon
        {
            FontHelper.ApplyFonts(this);

            lblIndicator.Width = this.Width / 2;
            lblIndicator.Height = this.Height / 2;

            lblScore.Width = this.Width / 2;
            lblScore.Height = this.Height / 2;

            if (score > 0 )
            {
                isCorrect = true;
            }
            
            if (isCorrect)
            {
                lblIndicator.Text = "CORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = Color.FromArgb(1, 1, 1);
            }
            else
            {
                lblIndicator.Text = "INCORRECT!";
                lblScore.Text = $"+{score} Points";
                lblScore.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
    }
}
