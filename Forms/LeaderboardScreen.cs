using System.Collections;
using System.Globalization;
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
            UIHelper.ApplyCursor(this, CursorStyle.TFClass);
            UIHelper.ApplyFonts(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.MainMenuScreen.Show();
        }

        private void btnQuizLeaderboard_Click(object sender, EventArgs e)
        {
            lvLeaderboard.Items.Clear();

            Button btn = (Button)sender;
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;

            QuizScores quizScore = (QuizScores)Enum.Parse(typeof(QuizScores), btn.Tag.ToString());

            lblQuizSelected.Text = $"{ti.ToTitleCase(btn.Text.ToLower())} Quiz";

            for (int i = 0; i < FormHelper.PlayerList.Count; i++)
            {
                Player player = FormHelper.PlayerList[i];

                ListViewItem item = new();

                item.SubItems.Add(player.Username);
                item.SubItems.Add(player.ScoresHashmap[quizScore].HighestScore.ToString());
                item.SubItems.Add(player.ScoresHashmap[quizScore].Rank);

                item.UseItemStyleForSubItems = false;

                UIHelper.ApplyFonts(this);

                item.SubItems[0].Font = UIHelper.TF2Build;
                item.SubItems[3].ForeColor = player.ScoresHashmap[quizScore].Rank != String.Empty ? FormHelper.ColourPalette[player.ScoresHashmap[quizScore].Rank] : Color.FromArgb(0, 0, 0);

                lvLeaderboard.Items.Add(item);
            }

            lvLeaderboard.Columns[1].Width += lvLeaderboard.Width - (lvLeaderboard.Columns[0].Width + lvLeaderboard.Columns[1].Width + lvLeaderboard.Columns[2].Width + lvLeaderboard.Columns[3].Width);

            ListViewSorter sorter = new(2, SortOrder.Descending);
            lvLeaderboard.ListViewItemSorter = sorter;

            for (int i = 0; i < lvLeaderboard.Items.Count; i++)
            {
                ListViewItem item = lvLeaderboard.Items[i];

                item.SubItems[0].Text = (i + 1).ToString();
            }

            lvLeaderboard.Sort();

            for (int i = 0; i < lvLeaderboard.Items.Count; i++)
            {
                ListViewItem item = lvLeaderboard.Items[i];

                switch (item.SubItems[0].Text)
                {
                    case "1":
                        item.SubItems[1].ForeColor = FormHelper.ColourPalette["Gold"];
                        item.SubItems[2].ForeColor = FormHelper.ColourPalette["Gold"];
                        break;
                    case "2":
                        item.SubItems[1].ForeColor = FormHelper.ColourPalette["Silver"];
                        item.SubItems[2].ForeColor = FormHelper.ColourPalette["Silver"];
                        break;
                    case "3":
                        item.SubItems[1].ForeColor = FormHelper.ColourPalette["Bronze"];
                        item.SubItems[2].ForeColor = FormHelper.ColourPalette["Bronze"];
                        break;
                    default:
                        break;
                }
            }
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
        public int Compare(Object? x, Object? y)
        {
            try
            {
                ListViewItem? lviX = (ListViewItem?)x;
                ListViewItem? lviY = (ListViewItem?)y;

                int comparison = ciComparer.Compare(Int32.Parse(lviX.SubItems[columnToSort].Text), Int32.Parse(lviY.SubItems[columnToSort].Text));

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
            catch (InvalidCastException)
            {
                throw;
            }
        }
    }
}
