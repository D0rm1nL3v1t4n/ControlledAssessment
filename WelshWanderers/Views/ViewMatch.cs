using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ViewMatch : Form
    {
        public ViewMatch(string previousScreen)
        {
            previous = previousScreen;
            InitializeComponent();
        }

        private static string previous;

        private void ViewMatch_Load(object sender, EventArgs e)
        {
            LoadLeagues();  //calls on function to load all the leagues
            ChangeBackButton(); //calls on function to set the text on the back button
            LoadMatchData();    //calls on function to load the matches data
            EditOff();  //calls on function to turn the edit state of the form off
            AccessLevelButtons();   //calls on function to show or hide buttons based on user's access level
        }

        private class Changes   //variables for the changes made as boolean values and count for changes made
        {
            public static int count = 0;
            public static bool league = false;
            public static bool opponent = false;
            public static bool date = false;
            public static bool timeH = false;
            public static bool timeM = false;
            public static bool addressLineA = false;
            public static bool addressLineB = false;
            public static bool postcode = false;
        
        }

        private void AccessLevelButtons()
        {
            if (Database.UserData.accessLevel == "Player")  //checks if user is a player
            {
                EventEdit.Hide();   //hides edit button
            }
        }

        private void ChangeBackButton()
        {
            if (previous == "Match Availability")   //checks if previous form was Match Availability
                NavBack.Text = "Close"; //sets back button text to 'Close'
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {   //Message box with Yes No buttons asking if user if they wish to close the form even if changes to the data have been made
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Navigation();   //navigation to the previous form
                }
                return;
            }
            Navigation();   //navigation to the previous form
        }

        private void Navigation()
        {
            if (previous == "Match Availability")  //checks if previous form was Match Availability
                Close();    //closes this form
            else if (previous == "Upcoming Matches")    //checks if previous form was Upcoming Matches
                NavToUpcomingMatches(); //navigation to Upcoming Matches form
            else if (previous == "Match Results")   //checks if previous form was Match Results
                NavToMatchResults();    //navigation to Match Results form
        }

        private void NavToMatchResults()
        {
            new MatchResults().Show();  //shows Match Results form
            Close();    //closes this form
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();   //calls on function to turn the edit state of the form on
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)  //checks if inputs are all valid
            {
                ChangeMatchData();  //changes the data of the match 
                MessageBox.Show("Changes have been saved.");
                EditOff();  //calls on function to turn the edit state of the form off
            }
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if any changes have been made
            {   //Message box with Yes No buttons checking if the user is sure they want to cancel the editing session
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditOff();  //calls on function to turn the edit state of the form off
                }
            }
            EditOff();  //calls on function to turn the edit state of the form off
        }

        private void EditOn()
        {
            ShowEditButtons();  //calls on function to show the buttons for editing the form
            ChangeEnableStatus(true, false);    //calls on function to change the enable state of the features of the form
        }
        
        private void EditOff()
        {
            LoadMatchData();    //calls on function loads the original data of the match
            HideEditButtons();  //calls on function to hide the buttons for editing
            ChangeEnableStatus(false, true);    //calls on function to change the enable status of the features of the form
            LabelChangesMade.Text = "No Changes";   //sets the label for changes made to be 'No changes'
        }

        private void ShowEditButtons()
        {   
            EventEdit.Hide();   //hides the edit button
            //shows the cancel edit & save button and changes made label
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
        }

        private void ChangeEnableStatus(bool state, bool oppositeState)
        {
            //sets readonly or enabled state of input boxes
            InputLeague.Enabled = state;
            InputOpponent.ReadOnly = oppositeState;
            InputDate.Enabled = state;
            InputTimeH.ReadOnly = oppositeState;
            InputTimeM.ReadOnly = oppositeState;
            InputHomeMatch.Enabled = state;
            InputAddressA.ReadOnly = oppositeState;
            InputAddressB.ReadOnly = oppositeState;
            InputPostcode.ReadOnly = oppositeState;
        }

        private void HideEditButtons()
        {
            EventEdit.Show();   //shows edit button
            //hides the cancel edit & save button and changes made label
            EventCancelEdit.Hide();
            EventSave.Hide();
            LabelChangesMade.Hide();
        }


        private void LoadLeagues()
        {
            string[] file = File.ReadAllLines("leagues.txt");   //opens file with read access, reading all the lines into an array
            foreach (string line in file)   //loops through each line in the file
            {
                string[] section = line.Split('|'); //splits the line into individual components
                InputLeague.Items.Add(section[1]);  //adds the name of the league into the drop down box
            }
        }

        private void NavToUpcomingMatches()
        {
            new UpcomingMatches().Show();   //shows Upcoming Matches
            Close();    //closes this form
        }

        private void LoadMatchData()
        {   //sets the data in the input boxes to be that from the database MatchData
            InputLeague.SelectedItem = Database.MatchData.league;
            InputOpponent.Text = Database.MatchData.opponent;
            InputDate.Text = Database.MatchData.date;
            InputTimeH.Text = Database.MatchData.timeH.ToString();
            InputTimeM.Text = Database.MatchData.timeM.ToString();
            InputAddressA.Text = Database.MatchData.addressLineA;
            InputAddressB.Text = Database.MatchData.addressLineB;
            InputPostcode.Text = Database.MatchData.postcode;
        }

        private void ChangeMatchData()
        {
            string[] data = { InputLeague.Text, InputOpponent.Text, InputDate.Text, InputTimeH.Text, InputTimeM.Text, InputAddressA.Text, InputAddressB.Text, InputPostcode.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.MatchData.id.ToString() };
            Functions.FileEdit.EditLine("matchDetails", 9, data, searchIndex, searchData);  //edits the file to account for the changes made
            //sets the MatchData in the database to be that of the new data for the match
            Database.MatchData.league = InputLeague.Text;
            Database.MatchData.opponent = InputOpponent.Text;
            Database.MatchData.date = InputDate.Text;
            Database.MatchData.timeH = Convert.ToInt16(InputTimeH.Text);
            Database.MatchData.timeM = Convert.ToInt16(InputTimeM.Text);
            Database.MatchData.addressLineA = InputAddressA.Text;
            Database.MatchData.addressLineB = InputAddressB.Text;
            Database.MatchData.postcode = InputPostcode.Text;
        }

        private void ShowChangesMade()
        {
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";    //label showing changes made by the user
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)  //checks if data changed from original data
            {
                ++Changes.count;
                ShowChangesMade();  //calls on function to show the changes made
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)  //checks if data is changed to the original data
            {
                --Changes.count;
                ShowChangesMade();  //calls on function to show the changes made
                return false;
            }
            return changedVal;
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changes.league = DetailsChanged(InputLeague.Text, Database.MatchData.league, Changes.league);   //checks if data has been changed for the league
        }

        private void InputOpponent_TextChanged(object sender, EventArgs e)
        {
            Changes.opponent = DetailsChanged(InputOpponent.Text, Database.MatchData.opponent, Changes.opponent);   //checks if data has been changed for the opponent
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            Changes.date = DetailsChanged(InputDate.Text, Database.MatchData.date, Changes.date);   //checks if data has been changed for the date
        }

        private void InputTimeH_TextChanged(object sender, EventArgs e)
        {
            Changes.timeH = DetailsChanged(InputTimeH.Text, Database.MatchData.timeH.ToString(), Changes.timeH);    ///checks if data has been changed for the hours
        }

        private void InputTimeM_TextChanged(object sender, EventArgs e)
        {
            Changes.timeM = DetailsChanged(InputTimeM.Text, Database.MatchData.timeM.ToString(), Changes.timeM);    //checks if data has been changed for the minutes
        }

        private void InputAddressA_TextChanged(object sender, EventArgs e)
        {
            Changes.addressLineA = DetailsChanged(InputAddressA.Text, Database.MatchData.addressLineA, Changes.addressLineA);   //checks if data has been changed for the address (line 1)
        }

        private void InputAddressB_TextChanged(object sender, EventArgs e)
        {
            Changes.addressLineB = DetailsChanged(InputAddressB.Text, Database.MatchData.addressLineB, Changes.addressLineB);   //checks if data has been changed for the address (line 2)
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        {
            Changes.postcode = DetailsChanged(InputPostcode.Text, Database.MatchData.postcode, Changes.postcode);   //checks if data has been changed for the postcode
        }

        private void InputHomeMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (InputHomeMatch.Checked == true) //checks if the the checkbox is checked
                HomeMatchTrue();    //calls on function to set data for home matfch
            else
                HomeMatchFalse();   //calls on function to set data for away match
        }

        private void HomeMatchTrue()
        {   //makes the text boxes read only
            InputAddressA.ReadOnly = true;
            InputAddressB.ReadOnly = true;
            InputPostcode.ReadOnly = true;
            //sets the values in the text box's to be the address and postcode of the Cardiff International pool
            InputAddressA.Text = "Cardiff International Pool";
            InputAddressB.Text = "Olympian Drive";
            InputPostcode.Text = "CF11 0JS";
        }

        private void HomeMatchFalse()
        {   //makes the text boxes editable
            InputAddressA.ReadOnly = false;
            InputAddressB.ReadOnly = false;
            InputPostcode.ReadOnly = false;
            //sets the address and postcode text boxes to have no text in them
            InputAddressA.Text = "";
            InputAddressB.Text = "";
            InputPostcode.Text = "";
        }

        private bool ValidInputs()
        {   //checks validation
            if (ValidLeague() == true && ValidOpponent() == true && ValidTime() == true && ValidAddress() == true && ValidPostcode() == true)
                return true;    //returns true if validation passes
            return false;   //returns false if validation fails
        }

        private bool ValidLeague()
        {
            if (InputLeague.Text != null)   //presence check
                return true;    //returns true if validation passes
            MessageBox.Show("You must select a league.");
            return false;   //returns false if validation fails
        }

        private bool ValidOpponent()
        {
            if (InputOpponent.Text.Length > 3 && InputOpponent.Text.Length < 21)    //length check
                return true;    //returns true if validation passes
            MessageBox.Show("Opponent must be between 4 and 20 characters.");
            return false;   //returns false if validation fails
        }

        private bool ValidTime()
        {   //range check
            if (Convert.ToInt16(InputTimeH.Text) < 24 && Convert.ToInt16(InputTimeH.Text) >= 0 && InputTimeH.Text.Length > 0 && InputTimeH.Text.Length < 3)
            {   //range check
                if (Convert.ToInt16(InputTimeM.Text) < 60 && Convert.ToInt16(InputTimeM.Text) >= 0 && InputTimeM.Text.Length > 0 && InputTimeM.Text.Length < 3)
                {
                    return true;    //returns true if validation passes
                }
            }
            MessageBox.Show("Time entered must be a real time.");
            return false;   //returns false if validation fails
        }

        private bool ValidAddress()
        {   //length check
            if (InputAddressA.Text.Length > 5 && InputAddressA.Text.Length < 31 && InputAddressB.Text.Length > 5 && InputAddressB.Text.Length < 31)
                return true;    //returns true if validation passes
            MessageBox.Show("Each address line must be between 6 and 30 characters.");
            return false;   //returns false if validation fails
        }

        private bool ValidPostcode()
        {   //calls on function to return boolean value for the validation of the postcode
            return Functions.Validation.IsPostcodeValid(InputPostcode.Text);
        }
    }
}
