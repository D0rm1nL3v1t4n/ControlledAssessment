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
using System.Globalization;

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
            CheckForBackup();
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
            NavRestore.Hide();
        }

        private void ShowAdminHome()
        {
            NavManageUsers.Show();
            NavUserJoinRequests.Show();
            NavViewLeagues.Show();
            NavRestore.Show();
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

        private void NavRestore_Click(object sender, EventArgs e)
        {
            new Views.Restore().Show();
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

        private void CheckForBackup()
        {
            string[,] backups = { { "Week", DateTime.Now.AddDays(-7).ToString(), "4" }, { "Month", DateTime.Now.AddMonths(-1).ToString(), "12" }, { "Year", DateTime.Now.AddYears(-1).ToString(), "0" } };
            for (int i = 0; i < 3; ++i)
            {
                string[] date = Functions.FileSearch.ReturnSegment("backup", backups[i,0], 2, 1, true).Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string folderNumber = "1";

                try
                {
                    folderNumber = GetFolderName(date[date.Length - 1], Convert.ToInt16(backups[i,2]));
                    if (Convert.ToDateTime(date[date.Length - 1]) <= Convert.ToDateTime(backups[i, 1]))
                        BackupFiles(backups[i, 0] + " " + folderNumber);
                }
                catch (IndexOutOfRangeException)
                {
                    BackupFiles(backups[i, 0] + " " + folderNumber);
                }
            }
        }

        private string GetFolderName(string lastDate, int limit)
        {
            int previousDateNum = Convert.ToInt16(Functions.FileSearch.ReturnSegment("backup", lastDate, 1, 3));
            if (previousDateNum == limit)
                return "1";
            return (previousDateNum + 1).ToString();
        }

        private void BackupFiles(string backupFolder)
        {
            string drive = "F";

            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues", "backup", "restore" };
            FileInfo[] files = new DirectoryInfo(drive + @":\Welsh Wanderers\WelshWanderers\bin\Debug\Leagues").GetFiles("*.txt");

            if (!Directory.Exists(drive + @":\Backup Test\" + backupFolder))
            {
                Directory.CreateDirectory(drive + @":\Backup Test\" + backupFolder);
                Directory.CreateDirectory(drive + @":\Backup Test\" + backupFolder + @"\Leagues");
            }

            foreach (string sourceFile in filesList)
            {
                File.Copy(sourceFile + ".txt",drive +  @":\Backup Test\" + backupFolder + @"\" + sourceFile + ".txt", true);
            }
            foreach (FileInfo file in files)
            {
                File.Copy(@"Leagues\" + file.ToString(), drive + @":\Backup Test\" + backupFolder + @"\Leagues\" + file.ToString(), true);
            }

            string[] folder = backupFolder.Split(' ');
            StoreBackupData(folder[0], folder[1]);
        }

        private void StoreBackupData(string backupType, string folderNumber)
        {
            Functions.FileWrite.WriteData("backup", Functions.FileSearch.GetNextId("backup") + "|" + DateTime.Now.ToString() + "|" + backupType + "|" + folderNumber + "|");
        }

    }
}
