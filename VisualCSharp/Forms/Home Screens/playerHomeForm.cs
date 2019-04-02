using System;
using System.Windows.Forms;

namespace VisualCSharp.Forms
{
    public partial class playerHomeForm : Form
    {
        public playerHomeForm()
        {
            InitializeComponent();
        }

        private void BtnMyAccountPlayer_Click(object sender, EventArgs e)
        {
            new Home_Screens.myAccountDetails().Show();
            this.Hide();

        }

        private void BtnSignOutPlayer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new signInForm().Show();
                this.Hide();

                var userData = new UserData();
                var matchData = new MatchData();
                var trainingData = new TrainingData();
                userData.ClearUserData();
                matchData.ClearMatchData();
                trainingData.ClearTrainingData();
                

                
            }
        }

        private void BtnViewMatches_Click(object sender, EventArgs e)
        {
            new Sub_home_Screens.Shared_sub_Screens.ViewMatches().Show();
            this.Hide();
        }

        private void BtnViewTrainings_Click(object sender, EventArgs e)
        {
            new Sub_home_Screens.Shared_sub_Screens.ViewTrainings().Show();
            this.Hide();
        }

        private void BtnPlayerStatistics_Click(object sender, EventArgs e)
        {

        }

        private void BtnMatchNotifications_Click(object sender, EventArgs e)
        {

        }
    }
}
