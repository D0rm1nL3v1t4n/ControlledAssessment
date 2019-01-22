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

namespace WelshWanderers.Views
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }


        private void Restore_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("backup.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] section = line.Split('|');
                TableBackupInfo.Rows.Add(section[0], section[1], section[2], section[3]);
            }
            file.Close();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Hide();
        }

        private void EventRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to procceed?\nAll data from this version will be restored,\nand all changes since this version will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InitialiseRestore();
                StoreRestoreData();
            }
        }

        private void InitialiseRestore()
        {
            string backupFolder = TableBackupInfo.SelectedRows[0].Cells[2].Value.ToString() + " " + TableBackupInfo.SelectedRows[0].Cells[3].Value.ToString();

            string drive = "D";


            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues" };
            FileInfo[] files = new DirectoryInfo(drive + @":\Backup Test\" + backupFolder + @"\Leagues").GetFiles("*.txt");

            foreach (string sourceFile in filesList)
            {
                File.Copy(drive + @":\Backup Test\" + backupFolder + @"\" + sourceFile + ".txt", sourceFile + ".txt", true);
            }
            foreach (FileInfo file in files)
            {
                File.Copy(drive + @":\Backup Test\" + backupFolder + @"\Leagues\" + file.ToString(), @"Leagues\" + file.ToString(), true);
            }
        }

        private void StoreRestoreData()
        {
            Functions.FileWrite.WriteData("restore", Functions.FileSearch.GetNextId("restore") + "|" + TableBackupInfo.SelectedRows[0].Cells[0].Value.ToString() + "|" + DateTime.Now.ToString() + "|");
        }

    }
}
