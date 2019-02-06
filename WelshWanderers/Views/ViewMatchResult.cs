using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            HideButton();
            LoadData();
            GetPlayersData();
            ResetChanges();
        }

        private void HideButton()
        {
            if (Database.UserData.accessLevel == "Player")
                EventEditMatchResult.Hide();
            else
                this.Height += 36;
            EventSave.Hide();
            EventCancelEdit.Hide();
            LabelChangesMade.Hide();
        }

        private class Changes
        {
            public static int count = 0;
            public static bool wanGoals = false;
            public static bool oppGoals = false;
            public static bool wanMajors = false;
            public static bool oppMajors = false;
        }

        private void ResetChanges()
        {
            Changes.count = 0;
            Changes.wanGoals = false;
            Changes.oppGoals = false;
            Changes.wanMajors = false;
            Changes.oppMajors = false;
            ShowChangesMade();
        }

        private void GetPlayersData()
        {
            string[] playerIDs = Functions.FileSearch.ReturnSegment("playerMatchStats", Database.MatchData.id.ToString(), 0, 1, true).Split('|');

            for (int i = 0; i < playerIDs.Length - 1; ++i)
            {
                string[] name = Functions.FileSearch.ReturnLine("userPersonalDetails", playerIDs[i], 0).Split('|');
                string[] stats = Functions.FileSearch.ManyToMany("playerMatchStats", Database.MatchData.id.ToString(), 0, playerIDs[i], 1).Split('|');
                TableMatchResult.Rows.Add(playerIDs[i], name[2] + " " + name[2], stats[2], stats[3], stats[4]);
            }
        }

        private void LoadData()
        {
            string line = Functions.FileSearch.ReturnLine("matchStats", Database.MatchData.id.ToString(), 0);
            string[] section = line.Split('|');
            InputOpponent.Text = Database.MatchData.opponent;
            InputWanderersGoals.Text = section[1];
            InputOpponentGoals.Text = section[2];
            InputWanderersMajors.Text = section[3];
            InputOpponentMajorFouls.Text = section[4];
            StoreDataLocal();
        }

        private void StoreDataLocal()
        {
            wanderersGoalsData = InputWanderersGoals.Text;
            opponentGoalsData = InputOpponentGoals.Text;
            wanderersMajorsData = InputWanderersMajors.Text;
            opponentMajorsData = InputOpponentMajorFouls.Text;
        }

        private void EditOn()
        {
            EditingEnableChange(true);
            ShowEditButtons();
        }

        private void EditOff()
        {
            EditingEnableChange(false);
            HideEditButtons();
            LoadData();
            LabelChangesMade.Text = "0 changes\nmade.";
            LabelChangesMade.Hide();
        }

        private void EditingEnableChange(bool state)
        {
            InputWanderersGoals.Enabled = state;
            InputOpponentGoals.Enabled = state;
            InputWanderersMajors.Enabled = state;
            InputOpponentMajorFouls.Enabled = state;
            bool oppositeState = true;
            if (state == true)
                oppositeState = false;
            TableMatchResult.ReadOnly = oppositeState;
        }

        private void ShowEditButtons()
        {
            EventEditMatchResult.Hide();
            EventSave.Show();
            EventCancelEdit.Show();
            LabelChangesMade.Show();
        }

        private void HideEditButtons()
        {
            EventEditMatchResult.Show();
            EventSave.Hide();
            EventCancelEdit.Hide();
            LabelChangesMade.Show();
        }

        private void EventEditMatchResult_Click(object sender, EventArgs e)
        {
            EditOn();
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            EditOff();
            ResetChanges();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToMatchResults();
                    return;
                }
            }
            NavToMatchResults();
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
            {
                ChangeMatchResultData();
                EditOff();
            }
        }

        private void ChangeMatchResultData()
        {
            ChangeMatchStatsData();
            ChangeMatchPlayerData();
        }

        private void ChangeMatchStatsData()
        {
            string[] data = { InputWanderersGoals.Text, InputOpponentGoals.Text, InputWanderersMajors.Text, InputOpponentMajorFouls.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.MatchData.id.ToString(), null };
            Functions.FileEdit.EditLine("matchStats", 5, data, searchIndex, searchData);
        }

        private void ChangeMatchPlayerData()
        {
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)
            {
                string[] data = { TableMatchResult.Rows[i].Cells[2].Value.ToString(), TableMatchResult.Rows[i].Cells[3].Value.ToString(), TableMatchResult.Rows[i].Cells[4].Value.ToString() };
                int[] searchIndex = { 0, 1 };
                string[] searchData = { Database.MatchData.id.ToString() ,TableMatchResult.Rows[i].Cells[0].Value.ToString() };
                Functions.FileEdit.EditLine("playerMatchStats", 5, data, searchIndex, searchData);
            }
        }

        private bool ValidInputs()
        {
            if (ValidOpponentGoals() && ValidWanderersGoals() && ValidOpponentMajors() && ValidWanderersMajors())
            {
                return true;
            }
            return false;
        }

        private bool ValidOpponentGoals()
        {
            int opponentGoalsVal = Convert.ToInt16(InputOpponentGoals.Text);
            if (opponentGoalsVal >= 0 && opponentGoalsVal < 100)
                return true;
            MessageBox.Show("Opponent goals entered must be between 0 ad 99.");
            return false;
        }

        private bool ValidWanderersGoals()
        {
            int wanderersGoalsVal = Convert.ToInt16(InputWanderersGoals.Text);
            int sumGoals = 0;
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)
                sumGoals += Convert.ToInt16(TableMatchResult.Rows[i].Cells[2].Value);
            if (wanderersGoalsVal < 0 || wanderersGoalsVal > 99)
                MessageBox.Show("Welsh Wanderers goals entered must be between 0 and 99.");
            else if (sumGoals != wanderersGoalsVal)
                MessageBox.Show("The number of goals scored by the Welsh Wanderers must equal the sum of the players' goals.");
            else
                return true;
            return false;
        }

        private bool ValidOpponentMajors()
        {
            int opponentMajorsVal = Convert.ToInt16(InputOpponentMajorFouls.Text);
            if (opponentMajorsVal >= 0 && opponentMajorsVal < 21)
                return true;
            MessageBox.Show("Opponent major fouls must be between 0 and 20.");
            return false;
        }

        private bool ValidWanderersMajors()
        {
            int wanderersMajorsVal = Convert.ToInt16(InputWanderersMajors.Text);
            int sumMajors = 0;
            for (int i = 0; i < TableMatchResult.Rows.Count; ++i)
                sumMajors += Convert.ToInt16(TableMatchResult.Rows[i].Cells[3].Value);
            if (wanderersMajorsVal < 0 || wanderersMajorsVal > 30)
                MessageBox.Show("Welsh Wanderers majors entered must be between 0 and 30.");
            else if (sumMajors != wanderersMajorsVal)
                MessageBox.Show("The number of majors conceded by the Welsh Wanderers must equal the sum of the players' major fouls.");
            else
                return true;
            return false;
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;
                ShowChangesMade();
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;
                ShowChangesMade();
                return false;
            }
            return changedVal;
        }

        private void ShowChangesMade()
        {
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private void NavToMatchResults()
        {
            new MatchResults().Show();
            Hide();
        }

        private void InputWanderersGoals_TextChanged(object sender, EventArgs e)
        {
            Changes.wanGoals = DetailsChanged(InputWanderersGoals.Text, wanderersGoalsData, Changes.wanGoals);
        }

        private void InputWanderersMajors_TextChanged(object sender, EventArgs e)
        {
            Changes.wanMajors = DetailsChanged(InputWanderersMajors.Text, wanderersMajorsData, Changes.wanMajors);
        }

        private void InputOpponentGoals_TextChanged(object sender, EventArgs e)
        {
            Changes.oppGoals = DetailsChanged(InputOpponentGoals.Text, opponentGoalsData, Changes.oppGoals);
        }

        private void InputOpponentMajorFouls_TextChanged(object sender, EventArgs e)
        {
            Changes.oppMajors = DetailsChanged(InputOpponentMajorFouls.Text, opponentMajorsData, Changes.oppMajors);
        }


    }
}
