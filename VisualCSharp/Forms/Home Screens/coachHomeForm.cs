using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace VisualCSharp.Forms
{
    public partial class coachHomeForm : Form
    {
        public coachHomeForm()
        {
            InitializeComponent();
        }

        private void BtnMyAccountCoach_Click(object sender, EventArgs e)
        {
            new Home_Screens.myAccountDetails().Show();
            this.Hide();
        }

        private void BtnSignOutCoach_Click(object sender, EventArgs e)
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

        private void BtnAddMatch_Click(object sender, EventArgs e)
        {
            new Sub_home_Screens.Coach_sub_Screens.AddMatchForm().Show();
            this.Hide();
        }

        private void BtnAddTraining_Click(object sender, EventArgs e)
        {
            new Sub_home_Screens.Coach_sub_Screens.AddTrainingForm().Show();
            this.Hide();
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
    }
}
