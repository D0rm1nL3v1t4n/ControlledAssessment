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
            if (Database.UserData.accessLevel == "Player")
                HideButtons();
            InputFilter.SelectedItem = "All";
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                if ((Convert.ToDateTime(section[3]) >= DateTime.Today && InputFilter.Text == "Upcoming") || (Convert.ToDateTime(section[3]) < DateTime.Today && InputFilter.Text == "Past") || (InputFilter.Text == "All"))
                TableViewMatches.Rows.Add(section[0], section[1], section[2], section[3], section[4] + ":" + section[5], section[6], section[7], section[8]);
            }
            file.Close();
        }

        private void HideButtons()
        {
            NavAddResult.Hide();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Close();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            try 
            {
                LoadMatchData();
                new ViewMatch("Upcoming Matches").Show();
                Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a match it view details about that match.");
            }
            
        }

        private void LoadMatchData()
        {
            string[] time = TableViewMatches.SelectedRows[0].Cells[4].Value.ToString().Split(':');
            Database.MatchData.id = Convert.ToInt16(TableViewMatches.SelectedRows[0].Cells[0].Value);
            Database.MatchData.league = TableViewMatches.SelectedRows[0].Cells[1].Value.ToString();
            Database.MatchData.opponent = TableViewMatches.SelectedRows[0].Cells[2].Value.ToString();
            Database.MatchData.date = TableViewMatches.SelectedRows[0].Cells[3].Value.ToString();
            Database.MatchData.timeH = Convert.ToInt16(time[0]);
            Database.MatchData.timeM= Convert.ToInt16(time[1]);
            Database.MatchData.addressLineA = TableViewMatches.SelectedRows[0].Cells[5].Value.ToString();
            Database.MatchData.addressLineB = TableViewMatches.SelectedRows[0].Cells[6].Value.ToString();
            Database.MatchData.postcode= TableViewMatches.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void NavViewResult_Click(object sender, EventArgs e)
        {
            //Change to prevent navigation if match result for that match does not exist.
            if (TableViewMatches.SelectedRows.Count > 0)
            { 
                if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[3].Value) > DateTime.Now)
                {
                    MessageBox.Show("Match not taken place yet.\n\nHey Doc, pretty sure we ain't time travelling yet - Marty.");
                }
                else if (Functions.FileSearch.ReturnSegment("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0, 1) == null)
                {
                    MessageBox.Show("No result has been added to this match yet.");
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
            if (null != Functions.FileSearch.ReturnLine("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0))
            {
                LoadMatchResult();
            }
            else
            {
                MessageBox.Show("No match result yet.");
            }
        }

        private void LoadMatchResult()
        {
            LoadMatchData();
            new ViewMatchResult().Show();
            Close();
        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableViewMatches.Rows.Clear();
            FillTableData();
            if (InputFilter.Text == "Upcoming")
            {
                NavViewResult.Hide();
                NavAddResult.Hide();
                NavMatchAvailability.Show();
            }
            else if (InputFilter.Text == "Past")
            {
                NavMatchAvailability.Hide();
            }
            else
            {
                NavViewResult.Show();
                if (Database.UserData.accessLevel != "Player")
                    NavAddResult.Show();
            }
        }

        private void NavAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == Functions.FileSearch.ReturnLine("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0))
                {
                    LoadMatchData();
                    new AddResult().Show();
                    Close();
                }
                else if (MessageBox.Show("This match already has a result. Would you like to view it?", "No Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoadMatchResult();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a match to add its result.");
            }
        }

        private void NavMatchAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[3].Value.ToString()) < DateTime.Today)
                    MessageBox.Show("That match has already occured.");
                else
                {
                    Database.MatchData.id = Convert.ToInt16(TableViewMatches.SelectedRows[0].Cells[0].Value.ToString());
                    new Views.ViewMatchAvailability().Show();
                    Close();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a match it view the availability of the players for that match.");
            }
        }
    }
}
