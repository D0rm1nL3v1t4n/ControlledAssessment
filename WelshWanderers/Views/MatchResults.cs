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
    public partial class MatchResults : Form
    {
        public MatchResults()
        {
            InitializeComponent();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Hide();
        }

        private void ViewMatchResults_Load(object sender, EventArgs e)
        {
            InputFilter.SelectedItem = "All";
            TableMatchResults.MultiSelect = false;
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchStats.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                if (Functions.FileSearch.ReturnSegment("leagues", Functions.FileSearch.ReturnSegment("matchDetails", section[0], 0, 1), 1, 2) == InputFilter.Text || InputFilter.Text == "All")
                    TableMatchResults.Rows.Add(section[0], "Welsh Wanderers", section[1], section[2], Functions.FileSearch.ReturnSegment("matchDetails", section[0], 0, 2));
            }
            file.Close();
        }

        private void NavMatchDetails_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMatchDetails();
                NavToViewMatchDetails();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a match.");
            }
        }

        private void LoadMatchDetails()
        {
            string[] section = Functions.FileSearch.ReturnLine("matchDetails", TableMatchResults.SelectedRows[0].Cells[0].Value.ToString(), 0).Split('|');
            Database.MatchData.id = Convert.ToInt16(section[0]);
            Database.MatchData.league = section[1];
            Database.MatchData.opponent = section[2];
            Database.MatchData.date = section[3];
            Database.MatchData.timeH = Convert.ToInt16(section[4]);
            Database.MatchData.timeM = Convert.ToInt16(section[5]);
            Database.MatchData.addressLineA = section[6];
            Database.MatchData.addressLineB = section[7];
            Database.MatchData.postcode = section[8];
        }

        private void NavToViewMatchDetails()
        {
            new ViewMatch("Match Results").Show();
            Hide();
        }

        private void NavViewMatch_Click(object sender, EventArgs e)
        {
            try
            {
                Database.MatchData.id = Convert.ToInt16(TableMatchResults.SelectedRows[0].Cells[0].Value);
                Database.MatchData.opponent = TableMatchResults.SelectedRows[0].Cells[4].Value.ToString();
                new ViewMatchResult().Show();
                Hide();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a match to view its result.");
            }

        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableMatchResults.Rows.Clear();
            FillTableData();
        }
    }
}
