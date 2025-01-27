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
    public partial class AchievementsScreen : Form
    {
        public AchievementsScreen()
        {
            InitializeComponent();
        }

        private void AchievementsScreen_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);
        }

        private void lblAchievements_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.s_mainMenuScreen.Show();
        }
    }
}
