using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WelshWanderers
{
    public partial class ViewMatch : Form
    {
        public ViewMatch()
        {
            InitializeComponent();
        }

        public static int changesMade = 0;
        public static bool league = false;
        public static bool opponent = false;
        public static bool date = false;
        public static bool timeH = false;
        public static bool timeM = false;
        public static bool addressLineA = false;
        public static bool addressLineB = false;
        public static bool postcode = false;

        private void ViewMatch_Load(object sender, EventArgs e)
        {
            LoadMatchData();
            EditOff();
        }


        private void NavBack_Click(object sender, EventArgs e)
        {
            if (changesMade > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToUpcomingMatches();
                }
            }
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
                ChangeMatchData();
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (changesMade > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditOff();
                }
            }
        }

        private void EditOn()
        {
            LoadLeagues();
            ShowEditButtons();
            EnableEditing();
        }
        
        private void EditOff()
        {
            LoadMatchData();
            HideEditButtons();
            EnableEditing();
            LabelChangesMade.Text = "No Changes";
        }

        private void ShowEditButtons()
        {
            EventEdit.Hide();
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
        }

        private void EnableEditing()
        {
            InputLeague.Enabled = true;
            InputOpponent.Enabled = true;
            InputDate.Enabled = true;
            InputTimeH.Enabled = true;
            InputTimeM.Enabled = true;
            InputAddressA.Enabled = true;
            InputAddressB.Enabled = true;
            InputPostcode.Enabled = true;
        }

        private void HideEditButtons()
        {
            EventEdit.Show();
            EventCancelEdit.Hide();
            EventSave.Hide();
            LabelChangesMade.Hide();
        }

        private void UnenableEditing()
        {
            InputLeague.Enabled = false;
            InputOpponent.Enabled = false;
            InputDate.Enabled = false;
            InputTimeH.Enabled = false;
            InputTimeM.Enabled = false;
            InputAddressA.Enabled = false;
            InputAddressB.Enabled = false;
            InputPostcode.Enabled = false;
        }

        private void LoadLeagues()
        {
            string[] file = File.ReadAllLines("leagues");
            foreach (string line in file)
            {
                string[] section = line.Split('|');
                InputLeague.Items.Add(section[1]);
            }
        }

        private void NavToUpcomingMatches()
        {
            new WelshWanderers.UpcomingMatches().Show();
            this.Hide();
        }

        private void LoadMatchData()
        {
            InputLeague.Text = Database.MatchData.league;
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
            Functions.FileEdit.EditLine("matchDetails", 9, data, searchIndex, searchData);

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
            LabelChangesMade.Text = changesMade + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++changesMade;
                ShowChangesMade();
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --changesMade;
                ShowChangesMade();
                return false;
            }

            if (changedVal == true)
                return true;
            else
                return false;
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            league = DetailsChanged(InputLeague.Text, Database.MatchData.league, league);
        }

        private void InputOpponent_TextChanged(object sender, EventArgs e)
        {
            opponent = DetailsChanged(InputOpponent.Text, Database.MatchData.opponent, opponent);
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            date = DetailsChanged(InputDate.Text, Database.MatchData.date, date);
        }

        private void InputTimeH_TextChanged(object sender, EventArgs e)
        {
            timeH = DetailsChanged(InputTimeH.Text, Database.MatchData.timeH.ToString(), timeH);
        }

        private void InputTimeM_TextChanged(object sender, EventArgs e)
        {
            timeM = DetailsChanged(InputTimeM.Text, Database.MatchData.timeM.ToString(), timeM);
        }

        private void InputAddressA_TextChanged(object sender, EventArgs e)
        {
            addressLineA = DetailsChanged(InputAddressA.Text, Database.MatchData.addressLineA, addressLineA);
        }

        private void InputAddressB_TextChanged(object sender, EventArgs e)
        {
            addressLineB = DetailsChanged(InputAddressB.Text, Database.MatchData.addressLineB, addressLineB);
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        {
            postcode = DetailsChanged(InputPostcode.Text, Database.MatchData.postcode, postcode);
        }

        private void InputHomeMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (InputHomeMatch.Checked == true)
                HomeMatchTrue();
            else
                HomeMatchFalse();
        }

        private void HomeMatchTrue()
        {
            InputAddressA.Enabled = false;
            InputAddressB.Enabled = false;
            InputPostcode.Enabled = false;
            InputAddressA.Text = "Cardiff International Pool";
            InputAddressB.Text = "Olympian Drive";
            InputPostcode.Text = "CF11 0JS";
        }

        private void HomeMatchFalse()
        {
            InputAddressA.Enabled = true;
            InputAddressB.Enabled = true;
            InputPostcode.Enabled = true;
            InputAddressA.Text = "";
            InputAddressB.Text = "";
            InputPostcode.Text = "";
        }

        private bool ValidInputs()
        {
            if (ValidLeague() == true && ValidOpponent() == true && ValidTime() == true && ValidAddress() == true && ValidPostcode() == true)
                return true;
            return false;
        }

        private bool ValidLeague()
        {
            if (InputLeague.Text != null)
                return true;
            MessageBox.Show("You must select a league.");
            return false;
        }

        private bool ValidOpponent()
        {
            if (InputOpponent.Text.Length > 3 && InputOpponent.Text.Length < 21)
                return true;
            MessageBox.Show("Opponent must be between 4 and 20 characters.");
            return false;
        }

        private bool ValidTime()
        {
            if (Convert.ToInt16(InputTimeH.Text) < 24 && Convert.ToInt16(InputTimeH.Text) >= 0 && InputTimeH.Text.Length > 0 && InputTimeH.Text.Length < 3)
            {
                if (Convert.ToInt16(InputTimeM.Text) < 60 && Convert.ToInt16(InputTimeM.Text) >= 0 && InputTimeM.Text.Length > 0 && InputTimeM.Text.Length < 3)
                {
                    return true;
                }
            }
            MessageBox.Show("Time entered must be a real time.");
            return false;
        }

        private bool ValidAddress()
        {
            if (InputAddressA.Text.Length > 5 && InputAddressA.Text.Length < 31 && InputAddressB.Text.Length > 5 && InputAddressB.Text.Length < 31)
                return true;
            MessageBox.Show("Each address line must be between 6 and 30 characters.");
            return false;
        }

        private bool ValidPostcode()
        {
            Regex postcodeRegex = new Regex(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})");
            Match compare = postcodeRegex.Match(InputPostcode.Text);
            if (compare.Success)
                return true;
            MessageBox.Show("Postcode must be of a valid format.");
            return false;
        }
    }
}
