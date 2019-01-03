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
        }

        private void HideAllButtons()
        {
            NavAddMatch.Hide();
            NavUpcomingMatches.Hide();
            NavMatchResults.Hide();
            NavAddTraining.Hide();
            NavUpcomingTrainings.Hide();
            NavViewLeagues.Hide();
            NavLeagueStatistics.Hide();
            NavMatchAvailability.Hide();
            NavUserJoinRequests.Hide();
            NavManageUsers.Hide();
        }

        private void ShowAdminHome()
        {
            NavManageUsers.Show();
            NavUserJoinRequests.Show();
            NavViewLeagues.Show();
        }

        private void ShowCoachHome()
        {
            NavAddMatch.Show();
            NavAddTraining.Show();
            NavUpcomingMatches.Show();
            NavUpcomingTrainings.Show();
            NavMatchResults.Show();
        }

        private void ShowPlayerHome()
        {
            NavUpcomingMatches.Show();
            NavUpcomingTrainings.Show();
            NavLeagueStatistics.Show();
            NavMatchAvailability.Show();
            NavMatchResults.Show();
        }

        private void HideHome()
        {
            Hide();
        }

        private void NavManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();
            HideHome();
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
                HideHome();
            }
        }

        private void NavViewLeagues_Click(object sender, EventArgs e)
        {
            new ManageLeagues().Show();
            HideHome();
        }

        private void NavAddMatch_Click(object sender, EventArgs e)
        {
            new AddMatch().Show();
            HideHome();
        }

        private void NavAddTraining_Click(object sender, EventArgs e)
        {
            new AddTraining().Show();
            HideHome();
        }


        private void NavLeagueStatistics_Click(object sender, EventArgs e)
        {
            new LeagueStats().Show();
            HideHome();
        }

        private void NavMatchNotifications_Click(object sender, EventArgs e)
        {
            new MatchAvailability().Show();
            HideHome();
        }

        private void NavUpcomingMatches_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();
            HideHome();
        }

        private void NavUpcomingTrainings_Click(object sender, EventArgs e)
        {
            new UpcomingTrainings().Show();
            HideHome();
        }

        private void NavMyAccount_Click(object sender, EventArgs e)
        {
            new MyAccount().Show();
            HideHome();
        }
        
        private void NavViewMatchResults_Click(object sender, EventArgs e)
        {
            new MatchResults().Show();
            HideHome();
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
