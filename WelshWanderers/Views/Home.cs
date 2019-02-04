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
            HideAllButtons();
            if (Database.UserData.accessLevel == "Admin")
                ShowAdminHome();
            else if (Database.UserData.accessLevel == "Coach")
                ShowCoachHome();
            else if (Database.UserData.accessLevel == "Player")
                ShowPlayerHome();
            Functions.Backup.BackupCheck();
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
            Hide();
        }

        private void NavUserJoinRequests_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("userJoinRequests.txt").Length == 0)
            {
                MessageBox.Show("No new reigstration join requests have been made.");
            }
            else
            {
                new UserJoinRequests().Show();
                Hide();
            }
        }

        private void NavViewLeagues_Click(object sender, EventArgs e)
        {
            new ManageLeagues().Show();
            Hide();
        }

        private void NavAddMatch_Click(object sender, EventArgs e)
        {
            new AddMatch().Show();
            Hide();
        }

        private void NavAddTraining_Click(object sender, EventArgs e)
        {
            new AddTraining().Show();
            Hide();
        }


        private void NavLeagueStatistics_Click(object sender, EventArgs e)
        {
            new LeagueStats().Show();
            Hide();
        }

        private void NavMatchNotifications_Click(object sender, EventArgs e)
        {
            new MatchAvailability().Show();
            Hide();
        }

        private void NavUpcomingMatches_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();
            Hide();
        }

        private void NavUpcomingTrainings_Click(object sender, EventArgs e)
        {
            new UpcomingTrainings().Show();
            Hide();
        }

        private void NavMyAccount_Click(object sender, EventArgs e)
        {
            new MyAccount().Show();
            Hide();
        }

        private void NavViewMatchResults_Click(object sender, EventArgs e)
        {
            new MatchResults().Show();
            Hide();
        }

        private void NavRestore_Click(object sender, EventArgs e)
        {
            new Views.Restore().Show();
            Hide();
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
                Hide();
            }
        }

    }
}
