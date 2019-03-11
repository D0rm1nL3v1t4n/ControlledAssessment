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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            HomeInfo();
            HideAllButtons();
            if (Database.UserData.accessLevel == "Admin")
                ShowAdminHome();
            else if (Database.UserData.accessLevel == "Coach")
                ShowCoachHome();
            else if (Database.UserData.accessLevel == "Player")
                ShowPlayerHome();
            Functions.Backup.BackupCheck();
        }

        private void HomeInfo()
        {
            LabelUserInfo.Text = Database.UserData.firstName + " " + Database.UserData.lastName;
            LabelDateTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + "  " + DateTime.Now.Date.ToString("dd/MM/yy");
        }

        private void HideAllButtons()
        {
            Control[] hideButtons = { NavAddMatch, NavAddTraining, NavUpcomingTrainings, NavUpcomingMatches, NavMatchResults, NavLeagueStatistics, NavMatchAvailability, NavManageUsers, NavUserJoinRequests, NavRestore, NavViewLeagues };
            foreach (var button in hideButtons)
            {
                button.Hide();
            }
        }

        private void ShowAdminHome()
        {
            Control[] showButtons = { NavManageUsers, NavUserJoinRequests, NavViewLeagues, NavRestore };
            foreach (var button in showButtons)
            {
                button.Show();
            }
        }

        private void ShowCoachHome()
        {
            Control[] showButtons = { NavAddMatch, NavAddTraining, NavUpcomingMatches, NavUpcomingTrainings, NavMatchResults };
            foreach (var button in showButtons)
            {
                button.Show();
            }
        }

        private void ShowPlayerHome()
        {
            Control[] showButtons = { NavUpcomingMatches, NavUpcomingTrainings, NavLeagueStatistics, NavMatchAvailability, NavMatchResults };
            foreach (var button in showButtons)
            {
                button.Show();
            }
        }


        private void NavManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();
            Close();
        }

        private void NavUserJoinRequests_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("userJoinRequests.txt").Length == 0)
            {
                MessageBox.Show("No new reigstration requests have been made.");
            }
            else
            {
                new UserJoinRequests().Show();
                Close();
            }
        }

        private void NavViewLeagues_Click(object sender, EventArgs e)
        {
            new ManageLeagues().Show();
            Close();
        }

        private void NavAddMatch_Click(object sender, EventArgs e)
        {
            new AddMatch().Show();
            Close();
        }

        private void NavAddTraining_Click(object sender, EventArgs e)
        {
            new AddTraining().Show();
            Close();
        }

        private void NavLeagueStatistics_Click(object sender, EventArgs e)
        {
            new LeagueStats().Show();
            Close();
        }

        private void NavMatchNotifications_Click(object sender, EventArgs e)
        {
            new MatchAvailability().Show();
            Close();
        }

        private void NavUpcomingMatches_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();
            Close();
        }

        private void NavUpcomingTrainings_Click(object sender, EventArgs e)
        {
            new UpcomingTrainings().Show();
            Close();
        }

        private void NavMyAccount_Click(object sender, EventArgs e)
        {
            new MyAccount().Show();
            Close();
        }

        private void NavViewMatchResults_Click(object sender, EventArgs e)
        {
            new MatchResults().Show();
            Close();
        }

        private void NavRestore_Click(object sender, EventArgs e)
        {
            new Views.Restore().Show();
            Close();
        }

        private void EventNavSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new SignIn().Show();
                var userData = new Database.UserData();
                var matchData = new Database.MatchData();
                var trainingData = new Database.TrainingData();
                userData.ClearUserData();
                matchData.ClearMatchData();
                trainingData.ClearTrainingData();
                Close();
            }
        }

    }
}
