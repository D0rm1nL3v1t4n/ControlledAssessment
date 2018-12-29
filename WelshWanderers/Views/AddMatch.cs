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
    public partial class AddMatch : Form
    {
        public AddMatch()
        {
            InitializeComponent();
        }

        private static string leagueTeam = "";

        private void InputFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchFilter();
        }

        private void AddMatch_Load(object sender, EventArgs e)
        {
            LoadLeagues();
        }

        private void LoadLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                InputLeague.Items.Add(section[1]);
            }
        }

        private void UpdateSearchFilter()
        {
            leagueTeam = Functions.FileSearch.ReturnSegment("leagues",InputLeague.Text, 1, 3);
            ListFindPlayers.Items.Clear();
            ShowFilteredPlayers();
        }

        private void ShowFilteredPlayers()
        {
            int index = InputLeague.SelectedIndex - 1;
            //Dont want this here.
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                string[] playerInfo = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|');
                string playerName = playerInfo[2] + " " + playerInfo[3];

                string team = Functions.FileSearch.ReturnSegment("userAccountDetails", section[0], 0, 4, false);
                if (leagueTeam == team)
                {
                    if (playerName.ToLower().Contains(InputFilter.Text.ToLower()))
                    {
                        ListFindPlayers.Items.Add(playerName);
                    }
                }
            }
            file.Close();
        }

        
        private void EventAddPlayers_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count >= 13)
            {
                if (MessageBox.Show("You have already reached the maximum number of players in a squad, continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            foreach (string selectedPlayer in ListFindPlayers.CheckedItems)
            { 
                if (!ListSelectedPlayers.Items.Contains(selectedPlayer))
                {
                    ListSelectedPlayers.Items.Add(selectedPlayer);
                    ShowPlayersAdded();
                }
            }
        }

        private void EventRemovePlayers_Click(object sender, EventArgs e)
        {
            for (int i = ListSelectedPlayers.Items.Count -1 ; i >= 0; --i)
            {
                if (ListSelectedPlayers.GetItemChecked(i))
                {
                    ListSelectedPlayers.Items.RemoveAt(i);
                    ShowPlayersAdded();
                }
            }
        }

        private void ShowPlayersAdded() 
        {
            LabelPlayersAdded.Text = ListSelectedPlayers.Items.Count + " player(s) added.";
        }

        private void EventClear_Click(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();
            ShowPlayersAdded();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            SendMatchEmail();
            SaveMatchData();
        }

        private void SendMatchEmail()
        {
            if (ListSelectedPlayers.Items.Count > 0)
            {
                string[] emails = new string[ListSelectedPlayers.Items.Count];
                int i = 0;
                foreach (string player in ListSelectedPlayers.Items)
                {
                    emails[i] = GetPlayerEmails(player);
                    ++i;
                }
                Functions.SendEmail.Email("Upcoming Match", MatchInfo(), emails);
                MessageBox.Show("Email sent!");
                NavToHome();
            }
            else
            {
                MessageBox.Show("Please select players for this match.");
            }
        }

        private void SaveMatchData()
        {
            string data = Functions.FileSearch.GetNextId("matchDetails") + "|" + InputLeague.Text + "|" + InputOpponent.Text + "|" + InputDate.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputAddressA.Text + "|" + InputAddressB.Text + "|" + InputPostcode.Text + "|";
            Functions.FileWrite.WriteData("matchDetails", data);
        }


        private string GetPlayerEmails(string playerName)
        {
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                MessageBox.Show(playerName + " | " + section[2] + " " + section[3]);
                if (playerName == (section[2] + " " + section[3]))
                    return section[5];
            }
            return "";
        }

        private string MatchInfo()
        {
            string team = "";
            for (int i = 0; i < ListSelectedPlayers.Items.Count; ++i)
            {
                team += "\n- " + ListSelectedPlayers.Items[i].ToString();
            }
            string homeAway;
            string location;
            if (InputHomeMatch.Checked == true)
            {
                homeAway = "home";
                location = "";
            }
            else
            {
                homeAway = "away";
                location = "Location:" + InputAddressA.Text + ",\n         " + InputAddressB.Text + ",\n         " + InputPostcode.Text + ".";
            }
            string body = "Hello all,\n\nUpcoming " + homeAway + ", " + InputLeague.Text
                + " leauge match against " + InputOpponent.Text + "." + "\n\nTeam is as follows:" + team
                + "\n\nDate & Time: " + InputDate.Text + ", " + InputTimeH.Text + ":" + InputTimeM.Text + ".\n" + location + "Please respond regarding availability."
                + "\n\nThanks,\n" + Database.UserData.firstName + " " + Database.UserData.lastName + "\nWelsh Wanderers";

            return body;
        }

        private void NavSignIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Match will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToHome();
            }
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();
            UpdateSearchFilter();
        }

        private void InputHomeMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (InputHomeMatch.Checked == true)
            {
                InputAddressA.Text = "Internation Pool";
                InputAddressB.Text = "Olympian Drive, Cardiff";
                InputPostcode.Text = "CF11 0JS";
            }
            else if (InputHomeMatch.Checked == false)
            {
                InputAddressA.Text = "";
                InputAddressB.Text = "";
                InputPostcode.Text = "";
            }
        }
    }
}
