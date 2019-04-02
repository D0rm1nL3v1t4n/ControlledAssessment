using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class AddMatch : Form
    {
        public AddMatch()
        {
            InitializeComponent();
            emailSent = false;
        }

        private static int matchID = -1;    //integer for the match id set at -1 at the start
        private static bool emailSent;  //boolean value for whether an email has been sent yet

        private void InputFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchFilter();   //shows the players selected for the match
        }

        private void AddMatch_Load(object sender, EventArgs e)
        {
            LoadLeagues();  //calls on a function to load all of the leagues into the dropdown box
        }

        private void LoadLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");    //opens the file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through reading one line at a time until line is empty
            {
                string[] section = line.Split('|'); //splits the line based on the delimter
                InputLeague.Items.Add(section[1]);  //adds the name of each league to the dropdown box
            }
        }

        private void UpdateSearchFilter()
        {
            ListFindPlayers.Items.Clear();  //clears all the data in the listbox
            ShowFilteredPlayers();  //shows the players selected for the match
        }

        private void ShowFilteredPlayers()
        {
            string leagueTeam = Functions.FileSearch.ReturnSegment("leagues", InputLeague.Text, 1, 2);  //Gets the team for that league
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))    //Loops through userPersonalDetails file
            {
                string[] section = line.Split('|');
                string[] playerInfo = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|'); //Gets each player's record
                string playerName = playerInfo[2] + " " + playerInfo[3];    //Gets each player's full name from their record

                string team = Functions.FileSearch.ReturnSegment("userAccountDetails", section[0], 0, 4, false);    //Gets each player's team
                if (leagueTeam == team)  //If player is in same team has the team for that league
                {
                    if (playerName.ToLower().Contains(InputFilter.Text.ToLower()))  //Checks if search filter's data is contained within the player's full name
                    {
                        ListFindPlayers.Items.Add(playerName);  //Adds player to list box
                    }
                }
            }
            file.Close();
        }

        private void EventAddPlayers_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count >= 13)  //checks there aren't too many players added to the match
            {
                if (MessageBox.Show("You have already reached the maximum number of players in a squad, continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            foreach (string selectedPlayer in ListFindPlayers.CheckedItems)
            { 
                if (!ListSelectedPlayers.Items.Contains(selectedPlayer))    //checks if player has already been added to match
                {
                    ListSelectedPlayers.Items.Add(selectedPlayer);  //if player not already in match, adds them to the listbox
                    ShowPlayersAdded(); //shows the count for the number of players selected for the match
                }
            }
        }

        private void EventRemovePlayers_Click(object sender, EventArgs e)
        {
            //loops from the last item to the first in the list box for selected players
            for (int i = ListSelectedPlayers.Items.Count -1 ; i >= 0; --i)
            {
                if (ListSelectedPlayers.GetItemChecked(i))  //checks if player has had checkbox selected
                {
                    ListSelectedPlayers.Items.RemoveAt(i);  //removes player from listbox
                    ShowPlayersAdded(); //shows count for players currently added to match
                }
            }
        }

        private void ShowPlayersAdded() 
        {
            //updates the count for the number of players currently added to the match
            LabelPlayersAdded.Text = ListSelectedPlayers.Items.Count + " player(s)";
        }

        private void EventClear_Click(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();  //clears all data from the list box
            ShowPlayersAdded(); //shows the count for the number of players currently added to the match
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count > 0)    //checks at least one player has been selected for the match
            {
                if (ValidInputs())  //checks all user inputs are valid
                {
                    if (emailSent)  //checks if an email has already been sent
                        SaveMatch();    //saves all the data relating to this match
                    else
                    {
                        //checks if the user wants to send an email before they close the form
                        if (MessageBox.Show("Would you like to send an email before exiting?", "Email not sent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            ShowPreviewEmail(); //navigates to Preview Email form
                        else
                            SaveMatch();    //save all the data relating to this match
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select players for this match.");
            }
        }

        private void SaveMatch()
        {
            SaveMatchData();    //saves the data for the match's details
            SaveAvailabilityData(); //saves the data for all the players' availability
            MessageBox.Show("Match saved.");
            NavToHome();    //Navigates to the Home form
        }

        private void SaveAvailabilityData()
        {
            foreach (string player in ListSelectedPlayers.Items)    //loops through all the players selected for the match
            {
                string userID = GetPlayerInfo(player, 0);   //gets the id for the player
                Functions.FileWrite.WriteData("matchAvailability", matchID + "|" + userID + "|" + "|"); //stores a record to the file
            }
        }

        private void SaveMatchData()
        {
            matchID = Functions.FileSearch.GetNextId("matchDetails");   //gets the next id for the file
            string data = matchID + "|" + InputLeague.Text + "|" + InputOpponent.Text + "|" + InputDate.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputAddressA.Text + "|" + InputAddressB.Text + "|" + InputPostcode.Text + "|";
            Functions.FileWrite.WriteData("matchDetails", data);    //stores the data for the match in the file
        }


        private string GetPlayerInfo(string playerName, int returnIndex)
        {
            StreamReader file = new StreamReader("userPersonalDetails.txt");    //Opens file with read access
            string line;
            while (null != (line = file.ReadLine()))    //Loops through the file reading each line until the line is empty
            {
                string[] section = line.Split('|'); //splits the line based on the delimter
                if (playerName == (section[2] + " " + section[3]))  //checks the player's name
                    return section[returnIndex];    //returns a part of their record's data
            }
            return "";
        }

        private string MatchInfo()
        {
            //Sets the default format for the body of the email address depending on the players added to the match and
             // if the home match input checkbox has been checked
            string team = "";
            for (int i = 0; i < ListSelectedPlayers.Items.Count; ++i)
            {
                team += "\n- " + ListSelectedPlayers.Items[i].ToString();   //adds all the players from the match to the body
            }
            string homeAway = "home";
            string location = "";
            if (InputHomeMatch.Checked == false)    //sets the address for the match based on home/away
            {
                homeAway = "away";
                location = "Address:" + InputAddressA.Text + ", " + InputAddressB.Text + ", " + InputPostcode.Text + ".";
            }
            string body = "Hello all,\n\nUpcoming " + homeAway + " match in the " + InputLeague.Text    //sets the value of the body of the email
                + " leauge against " + InputOpponent.Text + "." + "\n\nTeam is as follows:" + team
                + "\n\nDate & Time: " + InputDate.Text + ", " + InputTimeH.Text + ":" + InputTimeM.Text + ".\n" + location + "\n\nPlease respond regarding availability."
                + "\n\n\nThanks,\n" + Database.UserData.firstName + " " + Database.UserData.lastName + "\nWelsh Wanderers";

            return body;
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            //Message box appears with Yes No buttons asking if the user wants to leave this form
            if (MessageBox.Show("Are you sure? Match will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Navigates to Home form
                NavToHome();
            }
        }

        private void NavToHome()
        {
            //Navigating to the Home form, closing this form.
            new Home().Show();
            Close();
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();  //Clears all items in the listbox
            UpdateSearchFilter();   //Calls on a function to update the search based on the filter
        }

        private void InputHomeMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (InputHomeMatch.Checked == true)
            {
                //Sets the address and postcode in the text boxes as the address and postcode for the Cardiff International Pool
                InputAddressA.Text = "Internation Pool";
                InputAddressB.Text = "Olympian Drive, Cardiff";
                InputPostcode.Text = "CF11 0JS";
                ToggleReadOnly(true);
            }
            else if (InputHomeMatch.Checked == false)
            {
                //Sets the text in the address and postcode text boxes as empty
                InputAddressA.Text = "";
                InputAddressB.Text = "";
                InputPostcode.Text = "";
                ToggleReadOnly(false);
            }
        }

        private void ToggleReadOnly(bool state)
        {
            //Toggles the editablility of the address and postcode inputs by changing their readonly state
            InputAddressA.ReadOnly = state;
            InputAddressB.ReadOnly = state;
            InputPostcode.ReadOnly = state;
        }

        private void EventPreviewEmail_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count > 0)    //Checks at least one player has been selected for the match
            {
                if (ValidInputs())  //calls on another function to check inputs are valid
                {
                    ShowPreviewEmail(); //calls on a function to open the Preview Email form
                    emailSent = true;
                    EventPreviewEmail.Hide();   //hides the email button
                }
            }
            else
            {
                MessageBox.Show("Please select players for this match.");
            }
        }

        private void ShowPreviewEmail()
        {
            emailSent = true;
            Database.EmailData.body = MatchInfo();  //Sets the body of the email by calling on another function
            Database.EmailData.subject = "Upcoming match";  //Sets the subject of the email

            string[] emails = new string[ListSelectedPlayers.Items.Count];  //Creates array of length equal to number of players selected
            int i = 0;
            foreach (string player in ListSelectedPlayers.Items)
            {
                emails[i] = GetPlayerInfo(player, 5);   //Loops adding each player's email to the array by calling on a function to find their email
                ++i;
            }
            Database.EmailData.recipients = emails; //setting all the emails to send the email to

            //Navigating to the Preview Email form, hiding the email button
            new Views.PreviewEmail().Show();
            EventPreviewEmail.Hide();
        }

        private bool ValidInputs()
        {
            //Calls on functions to check the validation of inputs and returns as a boolean value
            bool league = ValidLeague();
            bool opponent = ValidOpponent();
            bool date = ValidDate();
            bool time = ValidTime();
            bool address = ValidAddress();
            bool postcode = ValidPostcode();
            return league && opponent && date && time && address && postcode;
        }

        private bool ValidLeague()
        {
            //Validation to check a league has been selected by checking if the input has at least 1 character in the league input
            if (InputLeague.Text.Length > 0)
                return true;    //returns true if valdation passes
            MessageBox.Show("Select a league.");
            return false;   //returns false if validation fails
        }

        private bool ValidOpponent()
        {
            //Validation to for the input for the opponent - length check and check the input is digits only
            if (InputOpponent.TextLength > 4 && InputOpponent.TextLength < 21 && InputOpponent.Text.All(Char.IsLetter))
                return true;    //returns true if valdation passes
            MessageBox.Show("Opponent's name must be between 5 and 20 letters in length.");
            return false;   //returns false if validation fails
        }

        private bool ValidDate()
        {
            if (InputDate.Value > DateTime.Today)   //Validation for the input for the date entered - checks if date is after today
                return true;    
            MessageBox.Show("Select a date in the future.");
            return false;   //returns false if validation fails
        }

        private bool ValidTime()
        {
            //Validation for the inputs for the times - checking if the inputs are digits
            if (InputTimeH.Text.All(Char.IsDigit) && InputTimeM.Text.All(Char.IsDigit))
            {
                int hours = Convert.ToInt16(InputTimeH.Text);   //converting the hours input from string to integer
                int mins = Convert.ToInt16(InputTimeM.Text);    //conterting the minutes input from string to integer
                if (hours < 24 && hours > -1 && mins < 60 && mins > -1) //range check for the inputs
                    return true;    //returns true if validation passes
                MessageBox.Show("Time must be a valid time.");
            }
            MessageBox.Show("Time entered must be digits only.");
            return false;   //returns false if validation fails
        }

        private bool ValidAddress()
        {
            //Validation for the input for the address - length check
            if (InputAddressA.TextLength > 4 && InputAddressA.TextLength < 31 && InputAddressB.TextLength > 4 && InputAddressB.TextLength < 31)
                return true;    //returns true if the validation passes
            MessageBox.Show("Address lines entered must be at between 5 and 30 charaters in length."); //alerts the user of the validation rules of the address
            return false;   //returns false if the validation fails
        }

        private bool ValidPostcode()
        {
            return Functions.Validation.IsPostcodeValid(InputPostcode.Text);    //Calls on the Validation class to validation the postcode input
        }

    }
}