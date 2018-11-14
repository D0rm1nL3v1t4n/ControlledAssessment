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
            NavViewMatches.Hide();
            NavViewMatchResults.Hide();
            NavAddTraining.Hide();
            NavViewTrainings.Hide();
            NavViewLeagues.Hide();
            NavLeagueStatistics.Hide();
            NavMatchNotifications.Hide();
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
            NavViewMatches.Show();
            NavViewTrainings.Show();
            NavViewMatchResults.Show();
        }

        private void ShowPlayerHome()
        {
            NavViewMatches.Show();
            NavViewTrainings.Show();
            NavLeagueStatistics.Show();
            NavMatchNotifications.Show();
            NavViewMatchResults.Show();
        }

        private void HideHome()
        {
            this.Hide();
        }

        private void NavManageUsers_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ManageUsers().Show();
            HideHome();
        }

        private void NavUserJoinRequests_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("userJoinRequests.txt").Count() == 0)
            {
                MessageBox.Show("No new reigstration join requests have been made.");
            }
            else
            {
                new WelshWanderers.UserJoinRequests().Show();
                HideHome();
            }
        }

        private void NavViewLeagues_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ManageLeagues().Show();
            HideHome();
        }

        private void NavAddMatch_Click(object sender, EventArgs e)
        {
            new WelshWanderers.AddMatch().Show();
            HideHome();
        }

        private void NavAddTraining_Click(object sender, EventArgs e)
        {
            new WelshWanderers.AddTraining().Show();
            HideHome();
        }


        private void NavLeagueStatistics_Click(object sender, EventArgs e)
        {
            new WelshWanderers.LeagueStats().Show();
            HideHome();
        }

        private void NavMatchNotifications_Click(object sender, EventArgs e)
        {
            new WelshWanderers.MatchNotifications().Show();
            HideHome();
        }

        private void NavViewMatches_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ViewMatch().Show();
            HideHome();
        }

        private void NavViewTrainings_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ViewTraining().Show();
            HideHome();
        }

        private void NavMyAccount_Click(object sender, EventArgs e)
        {
            new WelshWanderers.MyAccount().Show();
            HideHome();
        }
        
        private void NavViewMatchResults_Click(object sender, EventArgs e)
        {
            new WelshWanderers.ViewMatchResults().Show();
            HideHome();
        }

        private void EventNavSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new WelshWanderers.SignIn().Show();
                var userData = new Database.UserData();
                var matchData = new Database.MatchData();
                var trainingData = new Database.TrainingData();
                userData.ClearUserData();
                matchData.ClearMatchData();
                trainingData.ClearTrainingData();
                this.Hide();
            }
        }
    }
}
