using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelshWanderers.Functions
{
    class Backup
    {
        public static void BackupCheck()
        {
            string[,] backups = { { "Week", DateTime.Now.AddDays(-7).ToString(), "4" }, { "Month", DateTime.Now.AddMonths(-1).ToString(), "12" }, { "Year", DateTime.Now.AddYears(-1).ToString(), "0" } };
            for (int i = 0; i < 3; ++i)
            {
                string[] date = Functions.FileSearch.ReturnSegment("backup", backups[i, 0], 2, 1, true).Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string folderNumber = "1";

                try
                {
                    folderNumber = GetFolderName(date[date.Length - 1], Convert.ToInt16(backups[i, 2]));
                    if (Convert.ToDateTime(date[date.Length - 1]) <= Convert.ToDateTime(backups[i, 1]))
                        InitiateBackup(backups[i, 0] + " " + folderNumber);
                }
                catch (IndexOutOfRangeException)
                {
                    InitiateBackup(backups[i, 0] + " " + folderNumber);
                }
            }
        }

        private static string GetFolderName(string lastDate, int limit)
        {
            int previousDateNum = Convert.ToInt16(Functions.FileSearch.ReturnSegment("backup", lastDate, 1, 3));
            if (previousDateNum == limit)
                return "1";
            return (previousDateNum + 1).ToString();
        }

        private static void InitiateBackup(string backupFolder)
        {
            string drive = "D";

            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues" };
            FileInfo[] files = new DirectoryInfo(drive + @":\Welsh Wanderers\WelshWanderers\bin\Debug\Leagues").GetFiles("*.txt");

            if (!Directory.Exists(drive + @":\Backup Test\" + backupFolder))
            {
                Directory.CreateDirectory(drive + @":\Backup Test\" + backupFolder);
                Directory.CreateDirectory(drive + @":\Backup Test\" + backupFolder + @"\Leagues");
            }

            foreach (string sourceFile in filesList)
            {
                File.Copy(sourceFile + ".txt", drive + @":\Backup Test\" + backupFolder + @"\" + sourceFile + ".txt", true);
            }
            foreach (FileInfo file in files)
            {
                File.Copy(@"Leagues\" + file.ToString(), drive + @":\Backup Test\" + backupFolder + @"\Leagues\" + file.ToString(), true);
            }

            string[] folder = backupFolder.Split(' ');
            StoreBackupData(folder[0], folder[1]);
        }

        private static void StoreBackupData(string backupType, string folderNumber)
        {
            Functions.FileWrite.WriteData("backup", Functions.FileSearch.GetNextId("backup") + "|" + DateTime.Now.ToString() + "|" + backupType + "|" + folderNumber + "|");
        }

    }
}
