using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    public partial class EditMatchForm : Form
    {
        public class Changes
        {
            public static int noMade = -1;
            public static bool matchType = false;
            public static bool opponent = false;
            public static bool teamType = false;
            public static bool dateAndTime = false;
            public static bool addressLine1 = false;
            public static bool addressLine2 = false;
            public static bool postcode = false;
        }


        public EditMatchForm()
        {
            InitializeComponent();
        }

        private void EditMatchForm_Load(object sender, EventArgs e)
        {
            cmbMatchType.Text = MatchData.matchType;
            txtOpponent.Text = MatchData.opponent;
            cmbTeamType.Text = MatchData.teamType;
            matchDateAndTime.Text = MatchData.dateAndTime;
            txtAddressLine1.Text = MatchData.addressLine1;
            txtAddressLine2.Text = MatchData.addressLine2;
            txtPostcode.Text = MatchData.postcode;
        }

        private void ReturnViewMatches()
        {
            new Forms.Sub_home_Screens.Shared_sub_Screens.ViewMatches().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnViewMatches();
            }
        }

        private void BtnSaveMatch_Click(object sender, EventArgs e)
        {
            if (Changes.noMade == 0)
            {
                if (MessageBox.Show("You have not made any changes, do you want to return to the previous screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ReturnViewMatches();
                }
            }
            else if (Changes.noMade > 0)
            {
                if (MessageBox.Show("You have made " + Changes.noMade.ToString() + ", do you wish to save these changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChangeDetails();
                }
            }
        }

        private void ShowChangesMade()
        {
            LblChangesMade.Text = Changes.noMade + " change(s) made.";
        }

        private void ChangeDetails()
        {
            int noOfLines = File.ReadLines("matchDetails.txt").Count();
            string[,] localFile = new string[noOfLines, 9];
            int lineNo = 0;

            StreamReader matchDetailsFile = new StreamReader("matchDetails.txt");
            string individualLine = matchDetailsFile.ReadLine();

            while (null != individualLine)
            {
                string[] section = individualLine.Split('|');

                localFile[lineNo,0] = section[0];
                localFile[lineNo, 8] = section[8];

                if (section[0] == MatchData.matchID)
                {
                    localFile[lineNo, 1] = cmbMatchType.Text;
                    localFile[lineNo, 2] = txtOpponent.Text;
                    localFile[lineNo, 3] = cmbTeamType.Text;
                    localFile[lineNo, 4] = matchDateAndTime.Text;
                    localFile[lineNo, 5] = txtAddressLine1.Text;
                    localFile[lineNo, 6] = txtAddressLine2.Text;
                    localFile[lineNo, 7] = txtPostcode.Text;
                }
                else
                {
                    localFile[lineNo, 1] = section[1];
                    localFile[lineNo, 2] = section[2];
                    localFile[lineNo, 3] = section[3];
                    localFile[lineNo, 4] = section[4];
                    localFile[lineNo, 5] = section[5];
                    localFile[lineNo, 6] = section[6];
                    localFile[lineNo, 7] = section[7];

                }

                ++lineNo;
                individualLine = matchDetailsFile.ReadLine();
            }
            matchDetailsFile.Close();

            string[] tempLine = new string[9];
            int i = 0;

            using (System.IO.StreamWriter matchDetails =
            new System.IO.StreamWriter("matchDetails.txt"))
            {
                foreach (string line in localFile)
                {
                    tempLine[i] = line;
                    i++;
                    if (i % 9 == 0)
                    {
                        i = 0;
                        matchDetails.WriteLine(
                            tempLine[0] + "|" + tempLine[1] + "|" +
                            tempLine[2] + "|" + tempLine[3] + "|" +
                            tempLine[4] + "|" + tempLine[5] + "|" +
                            tempLine[6] + "|" + tempLine[7] + "|" +
                            tempLine[8]);
                    }

                }
            }

            MatchData.matchType = cmbMatchType.Text;
            MatchData.opponent = txtOpponent.Text;
            MatchData.teamType = cmbTeamType.Text;
            MatchData.dateAndTime = matchDateAndTime.Text;
            MatchData.addressLine1 = txtAddressLine1.Text;
            MatchData.addressLine2 = txtAddressLine2.Text;
            MatchData.postcode = txtPostcode.Text;

            MessageBox.Show("Match details have been updated!");
            ReturnViewMatches();
        }

        private void cmbMatchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMatchType.Text != MatchData.matchType && Changes.matchType == false)
            {
                Changes.noMade += 1;
                Changes.matchType = true;
            }
            if (cmbMatchType.Text == MatchData.matchType && Changes.matchType == true)
            {
                Changes.noMade -= 1;
                Changes.matchType = false;
            }
            ShowChangesMade();
        }

        private void txtOpponent_TextChanged(object sender, EventArgs e)
        {
            if (txtOpponent.Text != MatchData.opponent && Changes.opponent == false)
            {
                Changes.noMade += 1;
                Changes.opponent = true;
            }
            if (txtOpponent.Text == MatchData.opponent && Changes.opponent == true)
            {
                Changes.noMade -= 1;
                Changes.opponent = false;
            }
            ShowChangesMade();
        }

        private void cmbTeamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeamType.Text != MatchData.teamType && Changes.teamType == false)
            {
                Changes.noMade += 1;
                Changes.teamType = true;
            }
            if (cmbTeamType.Text == MatchData.teamType && Changes.teamType == true)
            {
                Changes.noMade -= 1;
                Changes.teamType = false;
            }
            ShowChangesMade();
        }

        private void matchDateAndTime_ValueChanged(object sender, EventArgs e)
        {
            if (matchDateAndTime.Text != MatchData.dateAndTime && Changes.dateAndTime == false)
            {
                Changes.noMade += 1;
                Changes.dateAndTime = true;
            }
            if (matchDateAndTime.Text == MatchData.dateAndTime && Changes.dateAndTime == true)
            {
                Changes.noMade -= 1;
                Changes.dateAndTime = false;
            }
            ShowChangesMade();
        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            if (txtAddressLine1.Text != MatchData.addressLine1 && Changes.addressLine1 == false)
            {
                Changes.noMade += 1;
                Changes.addressLine1 = true;
            }
            if (txtAddressLine1.Text == MatchData.addressLine1 && Changes.addressLine1 == true)
            {
                Changes.noMade -= 1;
                Changes.addressLine1 = false;
            }
            ShowChangesMade();
        }

        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {
            if (txtAddressLine2.Text != MatchData.addressLine2 && Changes.addressLine2 == false)
            {
                Changes.noMade += 1;
                Changes.addressLine2 = true;
            }
            if (txtAddressLine2.Text == MatchData.addressLine2 && Changes.addressLine2 == true)
            {
                Changes.noMade -= 1;
                Changes.addressLine2 = false;
            }
            ShowChangesMade();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostcode.Text != MatchData.postcode && Changes.postcode == false)
            {
                Changes.noMade += 1;
                Changes.postcode = true;
            }
            if (txtPostcode.Text == MatchData.postcode && Changes.postcode == true)
            {
                Changes.noMade -= 1;
                Changes.postcode = false;
            }
            ShowChangesMade();
        }
    }
}
