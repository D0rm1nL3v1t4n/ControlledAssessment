using System;
using System.ComponentModel;
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
            InputFilter.SelectedItem = "Upcoming";  //sets the item in the drop down box to be 'Upcoming'
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchDetails.txt");   //opens file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through file reading one line at a time until line is empty
            {
                string[] section = line.Split('|'); //splits the record into individual components
                //checks if match date adheres to the conditions set by the option selected in the filter drop down box
                if ((Convert.ToDateTime(section[3]) >= DateTime.Today && InputFilter.Text == "Upcoming") || (Convert.ToDateTime(section[3]) < DateTime.Today && InputFilter.Text == "Past") || (InputFilter.Text == "All"))
                    //adds row to table with match data
                    TableViewMatches.Rows.Add(section[0], section[1], section[2], section[3], section[4] + ":" + section[5], section[6], section[7], section[8]);
            }
            file.Close();
        }

        private void ButtonCheck()
        {
            if (InputFilter.Text == "All")  //checks if filter drop down is set at 'All'
            {
                AllButtons();   //calls on function to show all buttons
            }
            else if (InputFilter.Text == "Upcoming")    //checks if filter drop down is set at 'Upcoming'
            {
                UpcomingButtons();  //calls on function to show buttons for upcoming matches
            }
            else if (InputFilter.Text == "Past")    //checks if filter drop down is set at 'Past'
            {
                PastButtons();  //calls on function to show buttons for past matches
            }
        }

        private void AllButtons()
        {
            //shows these buttons
            NavAddResult.Show();
            NavMatchAvailability.Show();
            NavViewResult.Show();
            if (Database.UserData.accessLevel == "Player")  //checks if user is a player
            {
                //hides these buttons if user is a player
                NavAddResult.Hide();
                NavMatchAvailability.Hide();
            }
        }

        private void UpcomingButtons()
        {
            //shows these buttons
            NavMatchAvailability.Show();
            NavViewResult.Hide();
            NavAddResult.Hide();
            if (Database.UserData.accessLevel == "Player")  //checks if user is a player
                //hides this button if user is a player
                NavMatchAvailability.Hide();
        }

        private void PastButtons()
        {
            //shows these buttons
            NavViewResult.Show();
            NavAddResult.Show();
            NavMatchAvailability.Hide();
            if (Database.UserData.accessLevel == "Player")  //checks if user is a player
                //hides this button if user is a player
                NavAddResult.Hide();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //navigation to Home form
        }

        private void NavToHome()
        {
            new Home().Show();  //shows Home form
            Close();    //hides this form
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            try 
            {
                LoadMatchData();    //calls on function to load data into database variables
                new ViewMatch("Upcoming Matches").Show();  //shows Matches form
                Close();    //closes this form
            }
            catch (ArgumentOutOfRangeException)     //catches potential error
            {
                MessageBox.Show("Select a match it view details about that match.");
            }
            
        }

        private void LoadMatchData()
        {
            //sets database matchdata variables as data in the selected row
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
            if (TableViewMatches.SelectedRows.Count > 0)    //checks if the user has selected a row
            { 
                if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[3].Value) > DateTime.Now) //checks if the match is in the future
                {
                    MessageBox.Show("Match not taken place yet.");
                }
                //checks if match result exists
                else if (Functions.FileSearch.ReturnSegment("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0, 1) == null)
                {
                    MessageBox.Show("No result has been added to this match yet.");
                }
                else
                {
                    NavToMatchResult(); //navigation to Match Result form
                }
            }
            else
            {
                MessageBox.Show("Please select a match to view a result.");
            }
        }

        private void NavToMatchResult()
        {
            //checks if match result exists
            if (null != Functions.FileSearch.ReturnLine("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0))
            {
                LoadMatchResult();  //if result exists - navigation to Match Result form
            }
            else
            {
                MessageBox.Show("No match result yet.");
            }
        }

        private void LoadMatchResult()
        {
            LoadMatchData();    //calls on function to load data into database variables
            new ViewMatchResult("Matches").Show();   //shows the View Result form
            Close();    //closes this form
        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableViewMatches.Rows.Clear();  //clears all the data in the table
            FillTableData();    //calls on function to enter data into the table
            ButtonCheck();      //calls on function to check which buttons need to be shown and hidden
            TableViewMatches.Sort(TableViewMatches.Columns[3], ListSortDirection.Descending);   //sets the order of the rows to be descending based on date
        }

        private void NavAddResult_Click(object sender, EventArgs e)
        {
            try
            {   //checks if a result exists for this match already
                if (null == Functions.FileSearch.ReturnLine("matchStats", TableViewMatches.SelectedRows[0].Cells[0].Value.ToString(), 0))
                {
                    //checks if the match has already happened - in the past
                    if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[3].Value.ToString()) < DateTime.Today)
                    {
                        LoadMatchData();    //calls function to load data into database variables
                        new AddResult().Show(); //shows Add Result form
                        Close();    //hides this form
                    }
                    else
                    {
                        MessageBox.Show("Match result cannot be added until match has happened.");
                    }
                }
                //Message box with Yes No buttons to check if the user wants to view the result as one already exists
                else if (MessageBox.Show("This match already has a result. Would you like to view it?", "No Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoadMatchResult();  //navigation to View Match form
                }
            }
            catch (ArgumentOutOfRangeException) //catches potential error
            {
                MessageBox.Show("Select a match to add its result.");
            }
        }

        private void NavMatchAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if match has already happened - in the past
                if (Convert.ToDateTime(TableViewMatches.SelectedRows[0].Cells[3].Value.ToString()) < DateTime.Today)
                    MessageBox.Show("That match has already occured.");
                else
                {   //sets the variable for the match id to be that of the match selected
                    Database.MatchData.id = Convert.ToInt16(TableViewMatches.SelectedRows[0].Cells[0].Value.ToString());
                    new Views.ViewMatchAvailability().Show();   //shows the View Match Availability form
                    Close();    //closes this form
                }
            }
            catch (ArgumentOutOfRangeException) //catches potential error
            {
                MessageBox.Show("Select a match it view the availability of the players for that match.");
            }
        }
    }
}
