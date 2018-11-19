using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class UpcomingMatches : Form
    {
        public UpcomingMatches()
        {
            InitializeComponent();
        }

        private void ViewMatch_Load(object sender, EventArgs e)
        {
            HideButtons();
            FillTableData();
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                TableViewMatches.Rows.Add(section[0], section[1], section[2], section[3], section[4], section[5], section[6], section[7], section[8]);
            }
            file.Close();
        }

        private void HideButtons()
        {
            NavMatchAddResult.Hide();
            NavEditMatch.Hide();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void NavAddResult_Click(object sender, EventArgs e)
        {
            LoadMatchData();
            new WelshWanderers.AddResult().Show();
            this.Hide();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            LoadMatchData();
            new WelshWanderers.ViewMatch().Show();
            this.Hide();
        }

        private void LoadMatchData()
        {
            string[] time = TableViewMatches.SelectedRows[0].Cells[5].Value.ToString().Split(':');
            Database.MatchData.id = Convert.ToInt16(TableViewMatches.SelectedRows[0].Cells[0].Value);
            Database.MatchData.league = TableViewMatches.SelectedRows[0].Cells[1].Value.ToString();
            Database.MatchData.opponent = TableViewMatches.SelectedRows[0].Cells[2].Value.ToString();
            Database.MatchData.team = TableViewMatches.SelectedRows[0].Cells[3].Value.ToString();
            Database.MatchData.date = TableViewMatches.SelectedRows[0].Cells[4].Value.ToString();
            Database.MatchData.timeH = Convert.ToInt16(time[0]);
            Database.MatchData.timeM= Convert.ToInt16(time[1]);
            Database.MatchData.addressLineA = TableViewMatches.SelectedRows[0].Cells[6].Value.ToString();
            Database.MatchData.addressLineB = TableViewMatches.SelectedRows[0].Cells[7].Value.ToString();
            Database.MatchData.postcode= TableViewMatches.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void NavViewResult_Click(object sender, EventArgs e)
        {
            //Change to prevent navigation if match result for that match does not exist.
            if (TableViewMatches.SelectedRows.Count > 0)
            { 
                if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[4].Value) > DateTime.Now)
                {
                    MessageBox.Show("Match not taken place yet.\n\nHey Doc, pretty sure we ain't time travelling yet - Marty.");
                }
                else
                {
                    NavToMatchResult();
                }
            }
            else
            {
                MessageBox.Show("Please select a match to view a result.");
            }
        }

        private void NavToMatchResult()
        {
            LoadMatchData();
            new WelshWanderers.ViewMatchResult().Show();
            this.Hide();
        }
    }
}
