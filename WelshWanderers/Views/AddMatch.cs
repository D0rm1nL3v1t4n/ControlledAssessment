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

        List<string> searchID;
        List<string> selectedID;

        private void InputFilter_TextChanged(object sender, EventArgs e) => UpdateSearchFilter();

        private void AddMatch_Load(object sender, EventArgs e) => LoadLeagues();

        private void LoadLeagues()
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:\VisualCSharp\VisualCSharp\bin\Debug");
            FileInfo[] filesList = dir.GetFiles("*League*", SearchOption.TopDirectoryOnly); //Check if two * are for containing
            foreach (var file in filesList)
            {
                string[] fileName = file.ToString().Split('_');
                string newFileName = "";
                int fileNameLength = fileName.Count();
                for (int i = 0; i < fileNameLength - 1; ++i)
                {
                    newFileName += fileName[i];
                }
                InputLeague.Items.Add(newFileName);
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
            //Dont want this here.
            StreamReader file = new StreamReader("userPersonalDetails.txt");
            string line = file.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                string playerName = section[2] + " " + section[3];
                if (playerName.ToLower().Contains(InputFilter.Text.ToLower()))
                {
                    if ("Player" == Functions.FileSearch.ReturnSegment("userAccountDetails", section[0], 0, 3, false))
                    {
                        searchID.Add(section[0]);
                        ListFindPlayers.Items.Add(playerName);
                    }
                }
                line = file.ReadLine();
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
                    selectedID.Add(searchID[ListFindPlayers.Items.IndexOf(selectedPlayer)]);
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

        private void ShowPlayersAdded() => LabelPlayersAdded.Text = ListSelectedPlayers.Items.Count + " player(s) added.";

        private void EventClear_Click(object sender, EventArgs e)
        {
            ListSelectedPlayers.Items.Clear();
            ShowPlayersAdded();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ListSelectedPlayers.Items.Count > 0)
            {
                string[] emails = new string[ListSelectedPlayers.Items.Count];
                int i = 0;
                foreach (string id in selectedID)
                {
                    emails[i] = Functions.FileSearch.ReturnSegment("userPersonalDetails", id, 0, 5, false);
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
                + "match against " + InputOpponent.Text + "." + "\n\nTeam is as follows:" + team
                + "\n\nDate & Time: " + InputDate.Text + ", " + InputTimeH + ":" + InputTimeM + ".\n" + location + "Please respond regarding availability."
                + "\n\nThanks,\n" + Database.UserData.firstName + " " + Database.UserData.lastName + "\nWelsh Wanderers";

            return body;
        }

        private void NavSignIn_Click(object sender, EventArgs e) => NavToHome();

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }
    }
}
