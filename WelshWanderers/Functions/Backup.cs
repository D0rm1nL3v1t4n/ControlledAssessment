using System;
using System.IO;

namespace WelshWanderers.Functions
{
    class Backup
    {
        public static void BackupCheck()
        {   //creates an array with information regarding the existing backup
            string[,] backups = { { "Week", DateTime.Now.AddDays(-7).ToString(), "4" }, { "Month", DateTime.Now.AddMonths(-1).ToString(), "12" }, { "Year", DateTime.Now.AddYears(-1).ToString(), "0" } };
            for (int i = 0; i < 3; ++i) //loops three times
            {   //gets the dates for all the backups splitting all the dates by the delimiter '|' and removing any empty items
                string[] date = Functions.FileSearch.ReturnSegment("backup", backups[i, 0], 2, 1, true).Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string folderNumber = "1";

                try
                {
                    folderNumber = GetFolderName(date[date.Length - 1], Convert.ToInt16(backups[i, 2]));    //gets the number for next backup folder for Week/Month/Year
                    if (Convert.ToDateTime(date[date.Length - 1]) <= Convert.ToDateTime(backups[i, 1]))     //checks if backup needs to be done
                        InitiateBackup(backups[i, 0] + " " + folderNumber); //calls on function to backup system
                }
                catch (IndexOutOfRangeException)    //catches and prevents potential error
                {
                    InitiateBackup(backups[i, 0] + " " + folderNumber); //calls on function to backup system
                }
            }
        }

        private static string GetFolderName(string lastDate, int limit)
        {   //gets the number for the backup folder for the last backup done for Week/Month/Year
            int previousDateNum = Convert.ToInt16(Functions.FileSearch.ReturnSegment("backup", lastDate, 1, 3));
            if (previousDateNum == limit)
                return "1"; //returns one if the backup folder number needs to loop back
            return (previousDateNum + 1).ToString();    //returns the folder number + 1 as the new folder number
        }

        private static void InitiateBackup(string backupFolder)
        {
            string drive = "D"; //sets the drive to d
            FileInfo[] files;
            try
            {
                files = new DirectoryInfo(drive + @":\Welsh Wanderers\WelshWanderers\bin\Debug\Leagues").GetFiles("*.txt"); //get all the files in the Leagues directory
            }
            catch (DirectoryNotFoundException)
            {
                drive = "F";    //sets the drive to f
                files = new DirectoryInfo(drive + @":\Welsh Wanderers\WelshWanderers\bin\Debug\Leagues").GetFiles("*.txt"); //get all the files in the Leagues directory
            }
            //array with all the files that need to be backed up
            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues" };            

            if (!Directory.Exists(drive + @":\Backup\" + backupFolder)) //checks if the directory exists
            {
                Directory.CreateDirectory(drive + @":\Backup\" + backupFolder); //creates directory
                Directory.CreateDirectory(drive + @":\Backup\" + backupFolder + @"\Leagues");   //creates directory
            }

            foreach (string sourceFile in filesList)    //loops through each file that needs to be backed up
            {
                File.Copy(sourceFile + ".txt", drive + @":\Backup\" + backupFolder + @"\" + sourceFile + ".txt", true); //copies file to backup folder
            }
            foreach (FileInfo file in files)    //loops through each file that needs to be backed up
            {
                File.Copy(@"Leagues\" + file.ToString(), drive + @":\Backup\" + backupFolder + @"\Leagues\" + file.ToString(), true);   //copies file to backup folder
            }

            string[] folder = backupFolder.Split(' ');  //splits the folder based on the space character
            StoreBackupData(folder[0], folder[1]);  //calls on function to save the backup data
        }

        private static void StoreBackupData(string backupType, string folderNumber)
        {   //writes to backup.txt file with data on the backup
            Functions.FileWrite.WriteData("backup", Functions.FileSearch.GetNextId("backup") + "|" + DateTime.Now.ToString() + "|" + backupType + "|" + folderNumber + "|");
        }

    }
}
