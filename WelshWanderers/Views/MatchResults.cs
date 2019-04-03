using System;
using System.ComponentModel;
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
            NavToHome();    //navigation to Home form
        }

        private void NavToHome()
        {
            new Home().Show();  //shows the Home form
            Close();    //hides this form
        }

        private void ViewMatchResults_Load(object sender, EventArgs e)
        {
            InputFilter.SelectedItem = "All";   //sets the drop down box to have 'All' selected
            TableMatchResults.MultiSelect = false;  //prevents the user from selecting more than one row at a time
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchStats.txt"); //opens file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through file reading one line at a time until line is empty
            {
                string[] section = line.Split('|'); //splits the row into individual components
                string[] sectionB = Functions.FileSearch.ReturnLine("matchDetails", section[0], 0).Split('|');  //gets the league for this match
                //checks if the team for this league for this match is that specified in the filter
                if (Functions.FileSearch.ReturnSegment("leagues", sectionB[1], 1, 2) == InputFilter.Text || InputFilter.Text == "All")
                    //adds row in the table for the data of this match result
                    TableMatchResults.Rows.Add(section[0], "Welsh Wanderers", section[1], section[2], sectionB[2], sectionB[3]);
            }
            file.Close();   
            TableMatchResults.Sort(TableMatchResults.Columns[5], ListSortDirection.Descending); //sorts the rows of the tbale by date descending
        }

        private void NavMatchDetails_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMatchDetails(); //calls on function to load data into database variables
                NavToViewMatchDetails();    //navigation to View Match
            }
            catch (ArgumentOutOfRangeException) //catches potential errors
            {
                MessageBox.Show("Please select a match.");
            }
        }

        private void LoadMatchDetails()
        {
            //changes variables pf database matchdata to the data in the cells of the selected row
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
            new ViewMatch("Match Results").Show();  //shows the Match Results form
            Close();    //hides this form
        }

        private void NavViewMatch_Click(object sender, EventArgs e)
        {
            try
            {   //changes database match data id and opponent to data in table
                Database.MatchData.id = Convert.ToInt16(TableMatchResults.SelectedRows[0].Cells[0].Value);
                Database.MatchData.opponent = TableMatchResults.SelectedRows[0].Cells[4].Value.ToString();
                new ViewMatchResult("Match Results").Show();   //shows the View Result form
                Close();    //closes this form
            }
            catch (ArgumentOutOfRangeException) //catches potential error
            {
                MessageBox.Show("Please select a match to view its result.");
            }

        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableMatchResults.Rows.Clear(); //clears all data in table
            FillTableData();    //calls on function to populate table with data
        }
    }
}
