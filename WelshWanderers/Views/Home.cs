using System;
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
            HomeInfo(); //calls on a function to show the information on the Home form
            HideAllButtons();   //hides all the necessary buttons on the form
            if (Database.UserData.accessLevel == "Admin")   //checks if the user is an admin
                ShowAdminHome();    //calls on a function to show the admin's buttons
            else if (Database.UserData.accessLevel == "Coach")  //checks if the user is a coach
                ShowCoachHome();    //calls on a function to show the coach's buttons
            else if (Database.UserData.accessLevel == "Player") //checks if the user is a player
                ShowPlayerHome();   //calls on a function to show the player's buttons
            Functions.Backup.BackupCheck(); //calls on a function to check if a backup needs to be done
        }

        private void HomeInfo()
        {
            LabelUserInfo.Text = Database.UserData.firstName + " " + Database.UserData.lastName;    //sets the value for the user's name
            LabelDateTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + "  " + DateTime.Now.Date.ToString("dd/MM/yy");   //sets the value for the date time
        }

        private void HideAllButtons()
        {
            Control[] hideButtons = { NavAddMatch, NavAddTraining, NavUpcomingTrainings, NavUpcomingMatches, NavMatchResults, NavLeagueStatistics, NavMatchAvailability, NavManageUsers, NavUserJoinRequests, NavRestore, NavViewLeagues };
            foreach (var button in hideButtons) //loops through all the buttons
            {
                button.Hide();  //hides the button
            }
        }

        private void ShowAdminHome()
        {
            Control[] showButtons = { NavManageUsers, NavUserJoinRequests, NavViewLeagues, NavRestore };
            foreach (var button in showButtons) //loops through all the buttons to show
            {
                button.Show();  //shows the button
            }
        }

        private void ShowCoachHome()
        {
            Control[] showButtons = { NavAddMatch, NavAddTraining, NavUpcomingMatches, NavUpcomingTrainings, NavMatchResults };
            foreach (var button in showButtons) //loops through all the buttons to show
            {
                button.Show();  //shows the button
            }
        }

        private void ShowPlayerHome()
        {
            Control[] showButtons = { NavUpcomingMatches, NavUpcomingTrainings, NavLeagueStatistics, NavMatchAvailability, NavMatchResults };
            foreach (var button in showButtons) //loops through all the buttons to show
            {
                button.Show();  //shows the button
            }
        }


        private void NavManageUsers_Click(object sender, EventArgs e)
        {
            new ManageUsers().Show();   //shows the Users form
            Close();    //closes this form
        }

        private void NavUserJoinRequests_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("userJoinRequests.txt").Length == 0)  //checks if there are any user join requests
            {
                MessageBox.Show("No new reigstration requests have been made.");    //tells the admin there aren't any user join requests
            }
            else
            {
                new UserJoinRequests().Show();  //shows the User Join Requests form
                Close();    //closes this form
            }
        }

        private void NavViewLeagues_Click(object sender, EventArgs e)
        {
            new ManageLeagues().Show(); //shows the Leagues form
            Close();    //closes this form
        }

        private void NavAddMatch_Click(object sender, EventArgs e)
        {
            new AddMatch().Show();  //shows the Add Match form
            Close();    //closes this form
        }

        private void NavAddTraining_Click(object sender, EventArgs e)
        {
            new AddTraining().Show();   //shows the Add Training form
            Close();    //closes this form
        }

        private void NavLeagueStatistics_Click(object sender, EventArgs e)
        {
            new LeagueStats().Show();   //shows the League Statistics form
            Close();    //closes this form
        }

        private void NavMatchNotifications_Click(object sender, EventArgs e)
        {
            new MatchAvailability().Show(); //shows the Match Availability form
            Close();    //closes this form
        }

        private void NavUpcomingMatches_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();   //shows the Upcoming Matches form
            Close();    //closes this form
        }

        private void NavUpcomingTrainings_Click(object sender, EventArgs e)
        {
            new UpcomingTrainings().Show(); //shows the Upcoming Trainings form
            Close();    //closes this form
        }

        private void NavMyAccount_Click(object sender, EventArgs e)
        {
            new MyAccount().Show(); //shows the My Account form
            Close();    //closes this form
        }

        private void NavViewMatchResults_Click(object sender, EventArgs e)
        {
            new MatchResults().Show();  //shows the Match Results form
            Close();    //closes this form
        }

        private void NavRestore_Click(object sender, EventArgs e)
        {
            new Views.Restore().Show(); //shows the Restore form
            Close();    //closes this form
        }

        private void EventNavSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new SignIn().Show();    //shows the Sign In form
                
                var userData = new Database.UserData(); //resets the variables for the UserData
                userData.ClearUserData();

                var matchData = new Database.MatchData();   //resets the variables for the MatchData
                matchData.ClearMatchData();

                var trainingData = new Database.TrainingData(); //resets the variables for the TrainingData
                trainingData.ClearTrainingData();

                var emailData = new Database.EmailData();   //resets the variables for the EmailData
                emailData.ClearEmailData();

                var leagueData = new Database.LeagueData(); //resets the variables for the LeagueData  
                leagueData.ClearLeagueData();
                
                Close();    //closes this form
            }
        }

    }
}
