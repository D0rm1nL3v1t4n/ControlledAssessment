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
            emailSent = false;
        }

        private static int matchID = -1;
        private static bool emailSent;

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
            ListFindPlayers.Items.Clear();
            ShowFilteredPlayers();
        }

        private void ShowFilteredPlayers()
        {
            int index = InputLeague.SelectedIndex - 1;
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                string[] playerInfo = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|');
                string playerName = playerInfo[2] + " " + playerInfo[3];

                string team = Functions.FileSearch.ReturnSegment("userAccountDetails", section[0], 0, 4, false);
                if (Functions.FileSearch.ReturnSegment("leagues", InputLeague.Text, 1, 2) == team)
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
            LabelPlayersAdded.Text = ListSelectedPlayers.Items.Count + " player(s)";
        }

        private void EventClear_Click(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();
            ShowPlayersAdded();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count > 0)
            {
                if (emailSent)
                {
                    SaveMatchData();
                    SaveAvailabilityData();
                    NavToHome();
                }
                else
                {
                    if (MessageBox.Show("Would you like to send an email before exiting?", "Email not sent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ShowPreviewEmail();
                    }
                    else
                    {
                        NavToHome();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select players for this match.");
            }
        }

        private void SaveAvailabilityData()
        {
            foreach (string player in ListSelectedPlayers.Items)
            {
                string userID = GetPlayerInfo(player, 0);
                Functions.FileWrite.WriteData("matchAvailability", matchID + "|" + userID + "|" + "|");
            }
        }

        private void SaveMatchData()
        {
            matchID = Functions.FileSearch.GetNextId("matchDetails");
            string data = matchID + "|" + InputLeague.Text + "|" + InputOpponent.Text + "|" + InputDate.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputAddressA.Text + "|" + InputAddressB.Text + "|" + InputPostcode.Text + "|";
            Functions.FileWrite.WriteData("matchDetails", data);
        }


        private string GetPlayerInfo(string playerName, int returnIndex)
        {
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                if (playerName == (section[2] + " " + section[3]))
                    return section[returnIndex];
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
            string homeAway = "home";
            string location = "";
            if (InputHomeMatch.Checked == false)
            {
                homeAway = "away";
                location = "Address:" + InputAddressA.Text + ", " + InputAddressB.Text + ", " + InputPostcode.Text + ".";
            }
            string body = "Hello all,\n\nUpcoming " + homeAway + " match in the " + InputLeague.Text
                + " leauge against " + InputOpponent.Text + "." + "\n\nTeam is as follows:" + team
                + "\n\nDate & Time: " + InputDate.Text + ", " + InputTimeH.Text + ":" + InputTimeM.Text + ".\n" + location + "\n\nPlease respond regarding availability."
                + "\n\n\nThanks,\n" + Database.UserData.firstName + " " + Database.UserData.lastName + "\nWelsh Wanderers";

            return body;
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Match will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToHome();
            }
        }

        private void NavToHome()
        {
            new Home().Show();
            Close();
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

        private void EventPreviewEmail_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count > 0)
            {
                ShowPreviewEmail();
                emailSent = true;
                EventPreviewEmail.Hide();
            }
            else
            {
                MessageBox.Show("Please select players for this match.");
            }
        }

        private void ShowPreviewEmail()
        {
            Database.EmailData.body = MatchInfo();
            Database.EmailData.subject = "Upcoming match";

            string[] emails = new string[ListSelectedPlayers.Items.Count];
            int i = 0;
            foreach (string player in ListSelectedPlayers.Items)
            {
                emails[i] = GetPlayerInfo(player, 5);
                ++i;
            }
            Database.EmailData.recipients = emails;

            new Views.PreviewEmail().Show();
            EventPreviewEmail.Hide();
        }
    }
}
