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
using System.Net.Mail;

namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    public partial class AddMatchForm : Form
    {
        public class AddMatch
        {
            public static int playersAdded;
        }

        public AddMatchForm()
        {
            InitializeComponent();
        }

        private void AddMatchForm_Load(object sender, EventArgs e)
        {
            ShowFilteredPlayers();
            MatchDateTime.Format = DateTimePickerFormat.Custom;
            MatchDateTime.CustomFormat = "dd/MM/yyyy  hh:mm";
        }

        private void TxtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchFilter();
        }

        private void CmbTeamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSearchFilter();
        }


        private void UpdateSearchFilter()
        {
            listSearchPlayers.Items.Clear();
            ShowFilteredPlayers();
        }

        private void ShowFilteredPlayers()
        {
            StreamReader userPersonalDetails = new StreamReader("userPersonalDetails.txt");
            StreamReader userAccountDetails = new StreamReader("userAccountDetails.txt");
            string line = userPersonalDetails.ReadLine();
            string line2 = userAccountDetails.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                string[] section2 = line2.Split('|');
                string playerName = section[2] + " " + section[3];
                if (playerName.ToLower().Contains(TxtSearchFilter.Text.ToLower()) && section2[3] == "Player")
                {
                    listSearchPlayers.Items.Add(playerName);
                }

                line = userPersonalDetails.ReadLine();
                line2 = userAccountDetails.ReadLine();
            }
            userPersonalDetails.Close();
            userAccountDetails.Close();
        }

        private void BtnAddPlayers_Click(object sender, EventArgs e)
        {
            if (AddMatch.playersAdded >= 13)
            {
                if (MessageBox.Show("You have already reached the maximum number of players in a squad, continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }                  

            foreach (string selectedPlayer in listSearchPlayers.CheckedItems)
            {
                if (!listPlayersSelected.Items.Contains(selectedPlayer))
                {
                    listPlayersSelected.Items.Add(selectedPlayer);
                    AddMatch.playersAdded += 1;
                    ShowPlayersAdded();
                }
            }

        }

        private void BtnRemovePlayers_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = listPlayersSelected.Items.Count -1; i >= 0; --i)
            {
                if (listPlayersSelected.GetItemChecked(i))
                {
                    listPlayersSelected.Items.RemoveAt(i);
                    AddMatch.playersAdded -= 1;
                    ShowPlayersAdded();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            listPlayersSelected.Items.Clear();
            AddMatch.playersAdded = 0;
            ShowPlayersAdded();
        }

        private void ShowPlayersAdded()
        {
            LblPlayersAdded.Text = AddMatch.playersAdded + " player(s) added.";
        }

        private string GetPlayerEmail(string playerName)
        {
            StreamReader userPersonalDetails = new StreamReader("userPersonalDetails.txt");
            string line = userPersonalDetails.ReadLine();
            while (line != null)
            {
                if (line != null)
                {                 
                    string[] section = line.Split('|');

                    if (playerName == (section[2] + " " + section[3]))
                    {
                        return section[5];
                    }
                }
                line = userPersonalDetails.ReadLine();
            }
            return null;
        }

        private void SendEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("WelshWanderersTest@gmail.com");
            mail.Subject = "Upcoming Match";

            string team = "{";
            int length = listPlayersSelected.Items.Count;
            for (int i = 0; i < length; ++i)
            {
                team += "\n- " + listPlayersSelected.Items[i].ToString();
                mail.To.Add(GetPlayerEmail(listPlayersSelected.Items[i].ToString()));
            }

            string homeAway;
            string location;
            if (chkbxHomeMatch.Checked == true)
            {
                homeAway = "home";
                location = "";
            }
            else
            {
                homeAway = "away";
                location = "Location:" + TxtAddressLine1.Text + ",\n         " + TxtAddressLine2.Text + ",\n         " + TxtPostcode.Text + ".";
            }

            string body = "Hello all,\n\nUpcoming " + homeAway + ", " + CmbTeamType.Text.ToLower() + " " + CmbMatchType.Text.ToLower()
                + " against " + TxtOpponent.Text + "." + "\n\nTeam is as follows:" + team
                + "\n\nDate & Time: " + MatchDateTime.Text + ".\n" + location + "Please respond regarding availability."
                + "\n\nThanks,\n" + UserData.firstName + " " + UserData.lastName + "\nWelsh Wanderers";

            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("WelshWanderersTest@gmail.com", "TestPassword1!");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SendEmail();
                MessageBox.Show("Email sent!");
                string listPlayers = GetListPlayers();
                SaveMatchData(listPlayers);
                MessageBox.Show("Match added.");
                ReturnHome();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetListPlayers()
        {
            string listPlayers = "";
            for (int i = 0; i < listPlayersSelected.Items.Count; ++i)
            {
                listPlayers += listPlayersSelected.Items[i] + ",";
            }
            return listPlayers;
        }

        private void SaveMatchData(string team)
        {
            string matchID = FindMatchID();
            using (System.IO.StreamWriter matchDetailsFile =
                    new System.IO.StreamWriter("matchDetails.txt", true))
            {
                matchDetailsFile.WriteLine(
                    matchID + "|" + CmbMatchType.Text + "|" +
                    TxtOpponent.Text + "|" + CmbTeamType.Text + "|" +
                    MatchDateTime.Text + "|" + TxtAddressLine1.Text + "|" +
                    TxtAddressLine2.Text + "|" + TxtPostcode.Text + "|" +
                    team + "|");
            }
            
        }



        private string FindMatchID()
        {
            if (File.ReadLines("matchDetails.txt").Count() == 0)
            {
                return "0";
            }

            StreamReader matchDetails = new StreamReader("matchDetails.txt");
            string line = matchDetails.ReadLine();
            string previousID = "";
            while (null != line)
            {
                string[] section = line.Split('|');
                previousID = section[0];
                line = matchDetails.ReadLine();
            }
            matchDetails.Close();
            int newMatchID = System.Convert.ToInt16(previousID);
            ++newMatchID;
            return newMatchID.ToString();
        }


        private void chkbxHomeMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxHomeMatch.Checked == true)
            {
                TxtAddressLine1.Text = "Cardiff International Pool";
                TxtAddressLine2.Text = "Olympian Drive, Cardiff";
                TxtPostcode.Text = "CF11 0JS";
            }
            else if (chkbxHomeMatch.Checked == false)
            {
                TxtAddressLine1.Text = "";
                TxtAddressLine2.Text = "";
                TxtPostcode.Text = "";
            }

        }

        private void ReturnHome()
        {
            new Forms.coachHomeForm().Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Match will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnHome();
            }
        }

        
    }
}
