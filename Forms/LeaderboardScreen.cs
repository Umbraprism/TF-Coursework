using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework.Helpers;
using Coursework.ParentClasses;

namespace Coursework.Forms
{
    public partial class LeaderboardScreen : Form
    {
        public LeaderboardScreen()
        {
            InitializeComponent();
        }

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {
            FontHelper.ApplyFonts(this);
            FontHelper.ApplyCursor(this, "TFClass");
        }

        private void btnWeaponsLeaderboard_Click(object sender, EventArgs e)
        {
            lvLeaderboard.Items.Clear();

            for (int i = 0; i < FormHelper.s_playerList.Count; i++)
            {
                Player player = FormHelper.s_playerList[i];
                player.WeaponsRank = "Unusual";
                Random rnd = new();
                player.WeaponsHighestScore = rnd.Next(0, 100);

                ListViewItem item = new();

                item.SubItems.Add(player.Username);
                item.SubItems.Add(player.WeaponsHighestScore.ToString());
                item.SubItems.Add(player.WeaponsRank);

                item.UseItemStyleForSubItems = false;

                item.SubItems[0].Font = FontHelper.TF2Build;

                lvLeaderboard.Items.Add(item);
            }

            lvLeaderboard.Columns[1].Width += lvLeaderboard.Width - (lvLeaderboard.Columns[0].Width + lvLeaderboard.Columns[1].Width + lvLeaderboard.Columns[2].Width + lvLeaderboard.Columns[3].Width);

            ListViewSorter sorter = new(2, SortOrder.Descending);
            lvLeaderboard.ListViewItemSorter = sorter;

            for (int i = 0; i < lvLeaderboard.Items.Count; i++)
            {
                ListViewItem item = lvLeaderboard.Items[i];

                item.SubItems[0].Text = (i+1).ToString();
            }

            lvLeaderboard.Sort();
        }
    }

    public class ListViewSorter : IComparer
    {
        public int columnToSort = 0;
        public SortOrder sortOrder = SortOrder.None;
        private CaseInsensitiveComparer ciComparer = new();
        public ListViewSorter(int columnToSort, SortOrder sortOrder)
        {
            this.columnToSort = columnToSort;
            this.sortOrder = sortOrder;
        }
        public int Compare(Object x, Object y)
        {
            try
            {
                ListViewItem lviX = (ListViewItem)x;
                ListViewItem lviY = (ListViewItem)y;

                int comparison = ciComparer.Compare(lviX.SubItems[columnToSort].Text, lviY.SubItems[columnToSort].Text);

                switch (sortOrder)
                {
                    case SortOrder.Ascending:
                        return comparison;

                    case SortOrder.Descending:
                        return -comparison;

                    default:
                        return 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
