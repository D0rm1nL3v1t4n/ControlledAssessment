using System;
using System.ComponentModel;
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
            InputSortBy.SelectedItem = "All";   //changes the selected item in the drop down box to be 'All'
            ShowLastBackup();   //calls on function to show the last backup done
        }

        private void LoadData()
        {
            StreamReader file = new StreamReader("backup.txt"); //opens file with read access
            string line;
            while ((line = file.ReadLine()) != null)    //loops through file reading it one line at a time until the line is empty
            {
                string[] section = line.Split('|'); //splits the line into individual components by the delimiter '|'
                if (section[2] == InputSortBy.Text || InputSortBy.Text == "All")    //checks if the backup matches the drop down filter
                    TableBackupInfo.Rows.Add(section[0], section[1], section[2], section[3]);   //adds a row to the table with the backup's data
            }
            file.Close();
        }

        private void ShowLastBackup()
        {
            int rowCount = TableBackupInfo.Rows.Count;  //counts the number of rows in the table
            LabelBackupRecent.Text = "Most recent backup:\n" + TableBackupInfo.Rows[rowCount-1].Cells[1].Value;     //shows the date from the last row in the table         
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            new Home().Show();  //shows Home form
            Close();    //closes this form
        }

        private void EventRestore_Click(object sender, EventArgs e)
        {   //Message box with Yes No buttons checking if the admin is sure they wish to restore a previous version of the system
            if (MessageBox.Show("Are you sure you wish to procceed?\nAll data from this version will be restored,\nand all changes since this version will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InitialiseRestore();    //calls on function to restore that version
                StoreRestoreData(); //calls on function to store data on the restoration
            }
        }

        private void InitialiseRestore()
        {   //gets the backup folder which needs to be restored
            string backupFolder = TableBackupInfo.SelectedRows[0].Cells[2].Value.ToString() + " " + TableBackupInfo.SelectedRows[0].Cells[3].Value.ToString();
            string drive = "D";
            FileInfo[] files;
            try
            {
                files = new DirectoryInfo(drive + @":\Backup Test\" + backupFolder + @"\Leagues").GetFiles("*.txt");    //gets all the .txt files in this directory
            }   
            catch (DirectoryNotFoundException)  //catches and prevents potential error
            {
                drive = "F";
                files = new DirectoryInfo(drive + @":\Backup Test\" + backupFolder + @"\Leagues").GetFiles("*.txt");    //gets all the .txt files in this directory
            }
            //an array of all the files that needs to be resotred
            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues" };
            
            foreach (string sourceFile in filesList)    //loops for each file that needs to be restored
            {   //copies the file from the backup folder overwriting the current file
                File.Copy(drive + @":\Backup Test\" + backupFolder + @"\" + sourceFile + ".txt", sourceFile + ".txt", true);  
            }
            foreach (FileInfo file in files)    //loops for each league file in the \Leagues directory
            {   //copies the file from the \Leagues directory in the backup folder overwriting the current file
                File.Copy(drive + @":\Backup Test\" + backupFolder + @"\Leagues\" + file.ToString(), @"Leagues\" + file.ToString(), true);
            }
        }

        private void StoreRestoreData()
        {
            //writes to the restore.txt file with data on the restoration
            Functions.FileWrite.WriteData("restore", Functions.FileSearch.GetNextId("restore") + "|" + TableBackupInfo.SelectedRows[0].Cells[0].Value.ToString() + "|" + DateTime.Now.ToString() + "|");
        }

        private void InputOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (InputOrder.Checked == true) //checks if checkbox is checked
                TableBackupInfo.Sort(TableBackupInfo.Columns[1], ListSortDirection.Ascending);  //sorts table in ascending order
            else
                TableBackupInfo.Sort(TableBackupInfo.Columns[1], ListSortDirection.Descending); //sorts table in descending order
        }

        private void InputSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableBackupInfo.Rows.Clear();   //clears all the data in the table
            LoadData(); //calls on function to load the data into the table about backups
        }
    }
}