using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class LeagueStats : Form
    {
         public LeagueStats()
        {
            InitializeComponent();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //Navigation to Home form
        }

        private void NavToHome()
        {
            new Home().Show();  //shows Home form
            Close();    //closes this form
        }

        private void LeagueStats_Load(object sender, EventArgs e)
        {
            GetAllLeagues();    //calls on function to add all the leagues
            InputLeague.SelectedItem = "All";   //sets starting value in drop down box in league filter
            InputSortBy.SelectedItem = "Name";  //sets starting value in drop down box in ordering filter
        }

        private void GetAllLeagues()
        {
            InputLeague.Items.Add("All");   //adds an option of 'All' to the drop down bpx
            StreamReader file = new StreamReader("leagues.txt");    //opens file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through file line at a time until line is empty
            {
                string[] section = line.Split('|'); //splits record into individual components
                InputLeague.Items.Add(section[1]);  //adds the league's name as an item to the drop down box
            }
            file.Close();
        }

        private void LoadAllPlayers()
        {
            List<string> allLeagues = new List<string>();   //create string list
            if (InputLeague.SelectedItem.ToString() == "All")   //check if the item selected in the drop down box is 'All'
                AddLeagues(allLeagues);
            else
                allLeagues.Add(InputLeague.SelectedItem.ToString());    //adds the selected league into the list

            AddStatistics(allLeagues);
        }

        private void AddLeagues(List<String> allLeagues)
        {
            foreach (string item in InputLeague.Items)  //loop through each item in the drop down box for leagues
            {
                if (item != "All")  //checks if the item is not 'All'
                    allLeagues.Add(item);   //adds league name to allLeagues list
            }
        }

        private void AddStatistics(List<String> allLeagues)
        {
            foreach (string leagueFileName in allLeagues)   //loops through each the list allLeagues through each league in it
            {
                StreamReader file = new StreamReader(@"Leagues\" + leagueFileName + ".txt");   //Works out which file to read
                string line;
                while (null != (line = file.ReadLine()))
                {
                    string[] section = line.Split('|'); //splits record into components (index--> 0:id, 1:played, 2:goals, 3:majors)
                    string[] playerName = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|');
                    InsertTableData(section, playerName);
                }
                file.Close();
            }
        }

        private void InsertTableData(string[] section, string[] playerName)
        {
            bool found = false;
            for (int i = 0; i < TableLeagueStats.Rows.Count; ++i)   //loops for each row in the table
            {   
                if (TableLeagueStats.Rows[i].Cells[0].Value.ToString() == section[0])   //Compares to see if id already exists within table
                {
                    //adds games played stat to table
                    TableLeagueStats.Rows[i].Cells[2].Value = (Convert.ToDouble(TableLeagueStats.Rows[i].Cells[2].Value) + Convert.ToDouble(section[1]));
                    //adds goals stat to table
                    TableLeagueStats.Rows[i].Cells[3].Value = (Convert.ToDouble(TableLeagueStats.Rows[i].Cells[3].Value) + Convert.ToDouble(section[2]));
                    //adds (average goals = goals/games played) stat to table
                    TableLeagueStats.Rows[i].Cells[4].Value = Math.Round((Convert.ToDouble(TableLeagueStats.Rows[i].Cells[3].Value) / Convert.ToDouble(TableLeagueStats.Rows[i].Cells[2].Value)), 2);
                    //adds majors stat to table
                    TableLeagueStats.Rows[i].Cells[5].Value = (Convert.ToDouble(TableLeagueStats.Rows[i].Cells[5].Value) + Convert.ToDouble(section[3])).ToString();
                    //adds (average majors = majors/games played) stat to table
                    TableLeagueStats.Rows[i].Cells[6].Value = Math.Round((Convert.ToDouble(TableLeagueStats.Rows[i].Cells[5].Value) / Convert.ToDouble(TableLeagueStats.Rows[i].Cells[2].Value)), 2);
                    found = true;
                }
            }
            if (TableLeagueStats.Rows.Count == 0 || found == false)   //checks if table has no rows inside
                //adds row with player's statistics from league
                TableLeagueStats.Rows.Add(section[0], playerName[2] + " " + playerName[3], section[1], section[2], (Convert.ToDouble(section[2]) / Convert.ToDouble(section[1])), section[3], (Convert.ToDouble(section[3]) / Convert.ToDouble(section[1])));
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLeagueStats.Rows.Clear();  //clears all data from the table
            LoadAllPlayers();   //calls function to load data for all players
        }

        private void InputSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort(); //calls function to sort table order
        }

        private void InputDirection_CheckedChanged(object sender, EventArgs e)
        {
            Sort(); //calls function to sort table order
        }

        private void Sort()
        {
            int count = TableLeagueStats.Columns[InputSortBy.SelectedIndex + 1].Index;
            if (InputDirection.Checked == true) //checks if button is in checked state or unchecked state
                TableLeagueStats.Sort(TableLeagueStats.Columns[count], ListSortDirection.Ascending);    //sets table order to ascending
            else
                TableLeagueStats.Sort(TableLeagueStats.Columns[count], ListSortDirection.Descending);   //sets table order to descending

        }
    }
}
