using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ViewMatchResult : Form
    {
        public ViewMatchResult()
        {
            InitializeComponent();
        }

        private static string wanderersGoalsData;
        private static string opponentGoalsData;
        private static string wanderersMajorsData;
        private static string opponentMajorsData;

        private void ViewMatchResult_Load(object sender, EventArgs e)
        {
            this.Height = 507;
            HideButton();   //calls on function to hide the edit button
            LoadData(); //calls on function to load data for the match
            GetPlayersData();   //calls on function to load data into the table
            ResetChanges(); //calls on function to reset the changes made
        }

        private void HideButton()
        {
            if (Database.UserData.accessLevel == "Player")  //checks if users access level is 'player'
                EventEditMatchResult.Hide();    //hides edit button
            else
                this.Height += 36;
            EventSave.Hide();   //hides save button
            EventCancelEdit.Hide(); //hides cancel edit button
            LabelChangesMade.Hide();    //hides changes made label
        }

        private class Changes   //sets variables for the changes made by the user since the original data
        {
            public static int count = 0;
            public static bool wanGoals = false;
            public static bool oppGoals = false;
            public static bool wanMajors = false;
            public static bool oppMajors = false;
        }

        private void ResetChanges() //resets the variables for the changes made
        {
            Changes.count = 0;
            Changes.wanGoals = false;
            Changes.oppGoals = false;
            Changes.wanMajors = false;
            Changes.oppMajors = false;
            ShowChangesMade();
        }

        private void GetPlayersData()
        {   //searches for all the ids in this match
            string[] playerIDs = Functions.FileSearch.ReturnSegment("playerMatchStats", Database.MatchData.id.ToString(), 0, 1, true).Split('|');

            for (int i = 0; i < playerIDs.Length - 1; ++i)  //loops for each of the ids found
            {
                string[] name = Functions.FileSearch.ReturnLine("userPersonalDetails", playerIDs[i], 0).Split('|'); //gets the players name using the id
                //gets the statistics for the player using the id
                string[] stats = Functions.FileSearch.ManyToMany("playerMatchStats", Database.MatchData.id.ToString(), 0, playerIDs[i], 1).Split('|');
                TableMatchResult.Rows.Add(playerIDs[i], name[2] + " " + name[3], stats[2], stats[3], stats[4]); //adds row to the table with that players match stats
            }
        }

        private void LoadData()
        {   //loads data into the text boxes
            string line = Functions.FileSearch.ReturnLine("matchStats", Database.MatchData.id.ToString(), 0);
            string[] section = line.Split('|');
            InputOpponent.Text = Database.MatchData.opponent;
            InputWanderersGoals.Text = section[1];
            InputOpponentGoals.Text = section[2];
            InputWanderersMajors.Text = section[3];
            InputOpponentMajorFouls.Text = section[4];
            StoreDataLocal();   //calls on function to load data into varaibles
        }

        private void StoreDataLocal()
        {   //sets variables equal to the values for the overall match statistics
            wanderersGoalsData = InputWanderersGoals.Text;
            opponentGoalsData = InputOpponentGoals.Text;
            wanderersMajorsData = InputWanderersMajors.Text;
            opponentMajorsData = InputOpponentMajorFouls.Text;
        }

        private void EditOn()
        {
            EditingEnableChange(true);  //calls on function to change the editability of the form
            ShowEditButtons();  //calls on function to show buttons for editing
        }

        private void EditOff()
        {
            EditingEnableChange(false); //calls on function to change the editability of the form
            HideEditButtons();  //calls on function to hide buttons for editing
            LoadData(); //calls on function to load data into the form
            LabelChangesMade.Text = "0 changes\nmade.";
            LabelChangesMade.Hide();
        }

        private void EditingEnableChange(bool state)
        {   //sets the enabled state of the text boxes as true/false
            InputWanderersGoals.Enabled = state;
            InputOpponentGoals.Enabled = state;
            InputWanderersMajors.Enabled = state;
            InputOpponentMajorFouls.Enabled = state;
            bool oppositeState = true;
            if (state == true)
                oppositeState = false;
            //sets the readonly value for the table as true/false
            TableMatchResult.ReadOnly = oppositeState;
        }

        private void ShowEditButtons()
        {   //hides edit button
            EventEditMatchResult.Hide();
            //shows save and edit buttons & label for changes made
            EventSave.Show();
            EventCancelEdit.Show();
            LabelChangesMade.Show();
        }

        private void HideEditButtons()
        {   //shows edit button
            EventEditMatchResult.Show();
            //hides save and edit button & label for changes made
            EventSave.Hide();
            EventCancelEdit.Hide();
            LabelChangesMade.Hide();
        }

        private void EventEditMatchResult_Click(object sender, EventArgs e)
        {
            EditOn();   //calls on function to turn the editability of the form on
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            EditOff();  //calls on function to turn the editability of the form off
            ResetChanges(); //calls on function to change the data in the form to the original data
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {   //Message box with Yes No buttons asking the user if they are sure they wish to continue as they have unsaved changes
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToMatchResults();    //navigation to Match Results form
                    return;
                }
            }
            NavToMatchResults();    //Navigation to Match Results form
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)  //Checks if inputs are valid
            {
                ChangeMatchResultData();    //calls on function to edit the match result data
                MessageBox.Show("Changes have been saved.");
                EditOff();  //calls on function to turn the editability of the form off
            }
        }

        private void ChangeMatchResultData()
        {
            ChangeMatchStatsData(); //calls on function to change data in the matchStats file
            ChangeMatchPlayerData();    //calls on function to change data in the playerMatchStats file
            ChangeLeaguePlayerData();   //calls on function to change data in the league's file
        }

        private void ChangeMatchStatsData()
        {
            string[] data = { InputWanderersGoals.Text, InputOpponentGoals.Text, InputWanderersMajors.Text, InputOpponentMajorFouls.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.MatchData.id.ToString(), null };
            //calls on EditLine function to edit the data in the matchStats file
            Functions.FileEdit.EditLine("matchStats", 5, data, searchIndex, searchData);
        }

        private void ChangeMatchPlayerData()
        {
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)   //loops for each row in the table
            {   
                string[] data = { TableMatchResult.Rows[i].Cells[2].Value.ToString(), TableMatchResult.Rows[i].Cells[3].Value.ToString(), TableMatchResult.Rows[i].Cells[4].Value.ToString() };
                int[] searchIndex = { 0, 1 };
                string[] searchData = { Database.MatchData.id.ToString() ,TableMatchResult.Rows[i].Cells[0].Value.ToString() };
                //calls on EditLine function to edit the data in the playerMatchStats file
                Functions.FileEdit.EditLine("playerMatchStats", 5, data, searchIndex, searchData);
            }
        }

        private void ChangeLeaguePlayerData()
        {   //gets the name of the league
            string leagueName = Functions.FileSearch.ReturnSegment("matchDetails", Database.MatchData.id.ToString(), 0, 1); //gets the league's name

            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)   //loop through each row in the table
            {
                string id = TableMatchResult.Rows[i].Cells[0].Value.ToString(); //get the id from that row (user's id)

                string[] playerStats = GetPlayerStats(id.ToString(), leagueName);  //gets the player overall statistics
                string[] data = { Functions.FileSearch.ReturnSegment(@"Leagues\" + leagueName, id, 0, 1), playerStats[0], playerStats[1] }; 
                int[] searchIndex = { 0 };
                string[] searchData = { id };
                //calls on EditLine to edit the line data in the league's file for that player
                Functions.FileEdit.EditLine(@"Leagues\" + leagueName, 4, data, searchIndex, searchData);
            }
        }

        private string[] GetPlayerStats(string id, string leagueName)
        {
            StreamReader file = new StreamReader("playerMatchStats.txt");   //open file with read access
            string line;
            int goals = 0;
            int majors = 0;
            while (null != (line = file.ReadLine()))    //loop through file reading one line at a time until line is empty
            {
                string[] section = line.Split('|'); //split the line into individual components
                //checks that the record is both that of the player getting stats for and the match is in that league
                if (section[1] == id && Functions.FileSearch.ReturnSegment("matchDetails", section[0], 0, 1) == leagueName)
                {
                    goals += Convert.ToInt16(section[2]);   //adding the goals they scored in that match
                    majors += Convert.ToInt16(section[3]);  //adding the major fouls they conceded in that match
                }
            }
            string[] data = { goals.ToString(), majors.ToString() };
            return data;    //return this data
        }

        private bool ValidInputs()
        {   //checks that all the possible inputs are valid
            if (ValidOpponentGoals() && ValidWanderersGoals() && ValidOpponentMajors() && ValidWanderersMajors())
                return true;    //returns true if all inputs are valid
            return false;   //returns false if not all inputs are valid
        }

        private bool ValidOpponentGoals()
        {   //converts the data from string to integer
            int opponentGoalsVal = Convert.ToInt16(InputOpponentGoals.Text);
            if (opponentGoalsVal >= 0 && opponentGoalsVal < 100)    //range check
                return true;    //returns true if validation passes
            MessageBox.Show("Opponent goals entered must be between 0 and 99.");
            return false;   //returns false if validation fails
        }

        private bool ValidWanderersGoals()
        {   //converts the data from string to integer
            int wanderersGoalsVal = Convert.ToInt16(InputWanderersGoals.Text);
            int sumGoals = 0;
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)   //loops for each row in the table
                sumGoals += Convert.ToInt16(TableMatchResult.Rows[i].Cells[2].Value);   //adds the goals value in that row to the total
            if (wanderersGoalsVal < 0 || wanderersGoalsVal > 99)    //range check
                MessageBox.Show("Welsh Wanderers goals entered must be between 0 and 99.");
            else if (sumGoals != wanderersGoalsVal)   //compares if the value in the text box is the same as the total from the table
                MessageBox.Show("The number of goals scored by the Welsh Wanderers must equal the sum of the players' goals.");
            else
                return true;    //returns true if validation passes
            return false;   //returns false if validation fails
        }

        private bool ValidOpponentMajors()
        {   //converts the data from string to integer
            int opponentMajorsVal = Convert.ToInt16(InputOpponentMajorFouls.Text);
            if (opponentMajorsVal >= 0 && opponentMajorsVal < 21)   //range check
                return true;    //returns true if validation passes
            MessageBox.Show("Opponent major fouls must be between 0 and 20.");
            return false;   //returns false if validation fails
        }

        private bool ValidWanderersMajors()
        {   //converts data from string to integer
            int wanderersMajorsVal = Convert.ToInt16(InputWanderersMajors.Text);
            int sumMajors = 0;
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)   //loops for each row in the table
                sumMajors += Convert.ToInt16(TableMatchResult.Rows[i].Cells[3].Value);  //adds the majors value in that row to the total
            if (wanderersMajorsVal < 0 || wanderersMajorsVal > 30)  //range check
                MessageBox.Show("Welsh Wanderers majors entered must be between 0 and 30.");
            else if (sumMajors != wanderersMajorsVal)   //compares if the value in the text box is the same as the total from the table
                MessageBox.Show("The number of majors conceded by the Welsh Wanderers must equal the sum of the players' major fouls.");
            else
                return true;    //returns true if validation passes
            return false;   //returns false if validation fails
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {   //checks if the data has been changed from the original data
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;    //incraments count by 1
                ShowChangesMade();  //calls on function to show the changes made
                return true;       
            }  
            //checks if the data has been changed back to the original data
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;    //decreases count by 1
                ShowChangesMade();  //calls on function to show the changes made
                return false;   
            }
            return changedVal;
        }

        private void ShowChangesMade()
        {   //label showing the changes made to the original data
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private void NavToMatchResults()
        {
            new MatchResults().Show();  //shows Match Results form
            Close();    //closes this form
        }

        private void InputWanderersGoals_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the wanderers goals data
            Changes.wanGoals = DetailsChanged(InputWanderersGoals.Text, wanderersGoalsData, Changes.wanGoals);
        }

        private void InputWanderersMajors_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the wanderers majors data
            Changes.wanMajors = DetailsChanged(InputWanderersMajors.Text, wanderersMajorsData, Changes.wanMajors);
        }

        private void InputOpponentGoals_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the opponent goals data
            Changes.oppGoals = DetailsChanged(InputOpponentGoals.Text, opponentGoalsData, Changes.oppGoals);
        }

        private void InputOpponentMajorFouls_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the opponent majors data
            Changes.oppMajors = DetailsChanged(InputOpponentMajorFouls.Text, opponentMajorsData, Changes.oppMajors);
        }
    }
}