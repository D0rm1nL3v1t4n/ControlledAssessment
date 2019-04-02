using System;
using System.Linq;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class AddResult : Form
    {
        public AddResult()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            //Message box with Yes No buttons asking if the user wants to navigate to the Home form even though there are unsaved changes
            if (MessageBox.Show("Are you sure? Match Result will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToViewMatches(); //Navigation to the Home form
            }
        }

        private void NavToViewMatches()
        {
            new UpcomingMatches().Show();   //Shows the Upcoming Matches form and closes this form
            Close();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            ShowOpponentName(); //Calls on a function to show the opponent's name
            AddPlayers();   //Adds all the players selected and available for this match
        }

        private void ShowOpponentName()
        {
            InputOpponent.Text = Database.MatchData.opponent;   //Sets a text box value to be that of the opponent's name
        }

        private void AddPlayers()
        {
            //gets all the id's for players in the match
            string[] userIDs = Functions.FileSearch.ReturnSegment("matchAvailability", Database.MatchData.id.ToString(), 0, 1, true).Split('|');
            for (int i = 0; i < userIDs.Length - 1; ++i)    //loops through for the number of elements in the array above
            {
                //checks if the user i in the array if they are available for the match
                string[] lineA = Functions.FileSearch.ManyToMany("matchAvailability", Database.MatchData.id.ToString(), 0, userIDs[i], 1).Split('|');
                if ("Yes" == lineA[2])
                {
                    //if the user is available their name is added to the table
                    string[] lineB = Functions.FileSearch.ReturnLine("userPersonalDetails", userIDs[i], 0).Split('|');
                    TableAddMatchResult.Rows.Add(userIDs[i], lineB[2] + " " + lineB[3], "0", "0", "None");
                }
            }
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs())  //checks if all the inputs are valid
            {
                SavePlayerMatchData();  //saves the data for each player for that match
                SaveMatchResult();  //saves the overall match data
                SaveLeagueData();   //saves the data for each player for the match in the league
                MessageBox.Show("Match result has been saved.");
                NavToViewMatches(); //navigation to the Matches form
            }
        }

        private void SavePlayerMatchData()
        {
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops through all of the players in the table
            {
                //saves the statistics for that user from this match by calling on a function
                Functions.FileWrite.WriteData("playerMatchStats", GetUserStats(i)); 
            }
        }

        private string GetUserStats(int i)
        {
            string id = TableAddMatchResult.Rows[i].Cells[0].Value.ToString();  //gets the player's id from the table
            string goals;
            string majorFouls;
            string other = TableAddMatchResult.Rows[i].Cells[4].Value.ToString();
            try
            {
                goals = TableAddMatchResult.Rows[i].Cells[2].Value.ToString();  //gets the player's goal count from the table
            }
            catch (NullReferenceException)
            {
                goals = "0";    //sets the value for the goals scored by the player to be 0 if no input
            }
            try
            {
                majorFouls = TableAddMatchResult.Rows[i].Cells[3].Value.ToString(); //gets the player's major foul count from the table
            }
            catch (NullReferenceException)
            {
                majorFouls = "0";   //sets the value for the major fouls conceded by the player to be 0 if no input
            }
            return Database.MatchData.id.ToString() + "|" + id + "|" + goals + "|" + majorFouls + "|" + other + "|";
        }

        private void SaveMatchResult()
        {
            int totalGoals = GetGoals();    //calls on a function to get the total goals scored in the match by Welsh Wanderers
            int totalMajors = GetMajorFouls();  //calls on a function to get the total major fouls conceded in the match by Welsh Wanderers
            string line = Database.MatchData.id + "|" + totalGoals + "|" + InputOpponentGoals.Text + "|" + totalMajors + "|" + InputOpponentMajorFouls.Text + "|";
            Functions.FileWrite.WriteData("matchStats", line);  //writes the data to the file
        }

        private int GetGoals()
        {
            int total = 0;
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops through all the rows in the table
            {
                var goals = TableAddMatchResult.Rows[i].Cells[2].Value; //gets the value for that player's goals scored
                if (!(null == goals || 0 == System.Convert.ToInt16(goals))) //checks if the user has scored any goals
                    total += System.Convert.ToInt16(goals); //adds the goals scored by that player to the team total
            }
            return total;
        }

        private int GetMajorFouls()
        {
            int total = 0;
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops from all the rows in the table
            {
                var majors = TableAddMatchResult.Rows[i].Cells[3].Value;    //gets the value for that player's major fouls conceded
                if (!(null == majors || 0 == System.Convert.ToInt16(majors)))   //checks if the user has conceded any major fouls
                    total += System.Convert.ToInt16(majors);    //adds the major fouls conceded by that player to the team total
            }
            return total;
        }

        private void SaveLeagueData()
        {
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops for the number of rows in the table
            {
                string line;
                int played = 1;
                int goals = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[2].Value.ToString()); //sets the number of goals scored to be the value in the table
                int majors = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[3].Value.ToString());    //sets the number of major fouls to be the value in the table
                //checks if the player already has a record with their statistics in the file
                if (null != (line = Functions.FileSearch.ReturnLine(@"Leagues\" + Database.MatchData.league, TableAddMatchResult.Rows[i].Cells[0].Value.ToString(), 0)))
                {
                    string[] section = line.Split('|');
                    played += Convert.ToInt16(section[1]);  //adds one to the value in the table for games played
                    goals += Convert.ToInt16(section[2]);   //adds the goals from the file to the value in the table
                    majors += Convert.ToInt16(section[3]);  //adds the major fouls from the file to the value in the table
                    string[] data = { played.ToString(), goals.ToString(), majors.ToString() };
                    int[] searchIndex = { 0 };
                    string[] searchData = { TableAddMatchResult.Rows[i].Cells[0].Value.ToString() };
                    Functions.FileEdit.EditLine(@"Leagues\" + Database.MatchData.league, 4, data, searchIndex, searchData); //edits the file to change the statistics for each of the players
                }
                else
                {
                    string data = TableAddMatchResult.Rows[i].Cells[0].Value.ToString() + "|" + played + "|" + goals + "|" + majors + "|";
                    Functions.FileWrite.WriteData(@"Leagues\" + Database.MatchData.league, data);   //writes a record for the player's statistics
                }
            }
        }

        private bool ValidInputs()
        {
            bool opponentGoals = ValidOpponentGoals();  //calls on a function to check if the opponent's goals value is valid
            bool opponentMajorFouls = ValidOpponentMajorFouls();    //calls on a function to check if the opponent's major fouls value is valid
            bool homeGoals = ValidHomeGoals();  //calls on a function to check if the Welsh Wanderer's goals value is valid
            bool homeMajorFouls = ValidHomeMajorFouls();    //calls on a function to check if the Welsh Wanderer's major fouls value is valid
            return opponentGoals && opponentMajorFouls && homeGoals && homeMajorFouls;
        }

        private bool ValidOpponentGoals()
        {
            if (InputOpponentGoals.Text != "")  //checks input is not empty
            {
                if (InputOpponentGoals.Text.All(Char.IsDigit))  //checks input is digits only
                {
                    int goalsVal = Convert.ToInt16(InputOpponentGoals.Text);   //converts input to integer from string
                    if (goalsVal >= 0 && goalsVal < 100)    //range check
                        return true;    //return true if passes validation
                    else
                        MessageBox.Show("Opponent's goals value must be between 0 and 99.");
                }
                else
                    MessageBox.Show("The value for opponent's goals entered must consist only of digits.");

            }
            else
                MessageBox.Show("Enter a value for the opponent's goals.");
            return false;   //return true if validation fails
        }

        private bool ValidOpponentMajorFouls()
        {
            if (InputOpponentMajorFouls.Text != "") //checks input is not empty
            {
	            if (InputOpponentMajorFouls.Text.All(Char.IsDigit)) //checks input is digits only
	            {
		            int majorFoulsVal = Convert.ToInt16(InputOpponentMajorFouls.Text);  //converts input to integer from string
		            if (majorFoulsVal >= 0 && majorFoulsVal < 19)   //range check
			            return true;    //returns true if validation passes
		            else
			            MessageBox.Show("Opponent's major fouls value must be between 0 and 18.");
	            }
	            else
		            MessageBox.Show("The value for opponent's major fouls entered must consist only of digits.");
	
            }
            else
	            MessageBox.Show("Enter a value for the opponent's major fouls.");
            return false;   //returns false if validation fails
        }

        private bool ValidHomeGoals()
        {
            int count = 0;     //sets count to 0 - count is the number of rows that pass validation
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops through all the rows in the table
            {
	            if (TableAddMatchResult.Rows[i].Cells[2].Value == null) //checks input for cell is not empty
		            count += 1; //adds one to count
	            else
	            {
		            if (TableAddMatchResult.Rows[i].Cells[2].Value.ToString().All(Char.IsDigit))    //checks input is digits only
		            {
			            int rowGoals = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[2].Value.ToString());  //converts input to integer from string
                        if (rowGoals >= 0 && rowGoals <= 30)    //range check
                            count += 1; //adds one to count
                        else
                            MessageBox.Show("The goals entered for each player must be between 0 and 30.");
		            }
		            else
			            MessageBox.Show("The value for goals entered for each player must consist only of digits.");
	            }
            }

            if (count == TableAddMatchResult.Rows.Count)
	            return true;    //returns true if count is equal to row count and validation passes
            return false;   //returns false if validation fails
        }

        private bool ValidHomeMajorFouls()
        {
            int count = 0;     //sets count to 0 - count is the number of rows that pass validation
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)    //loops through all the rows in the table
            {
	            if (TableAddMatchResult.Rows[i].Cells[3].Value == null) //checks input for cell is not empty
		            count += 1; //adds one to count
	            else
	            {
		            if (TableAddMatchResult.Rows[i].Cells[3].Value.ToString().All(Char.IsDigit))    //checks input is digits only
		            {
			            int rowMajorFouls = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[3].Value.ToString()); //converts input to integer from string
                        if (rowMajorFouls >= 0 && rowMajorFouls <= 3)   //range check
                            count += 1; //adds one to count
                        else
                            MessageBox.Show("The major fouls entered for each player must be between 0 and 3.");
		            }
		            else
			            MessageBox.Show("The value for major fouls entered for each player must consist only of digits.");
	            }
            }

            if (count == TableAddMatchResult.Rows.Count)
	            return true;    //returns true if count is equal to row count and validation passes
            return false;   //return false if validation fails
        }
    }
}
