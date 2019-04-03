using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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
            List<string> table = new List<string>();    //creates a string list

            if (InputSortBy.Text == "Week" || InputSortBy.Text == "All")    //checks if Week needs to be added to table
                table = AddToTable("Week", table, 4);   //adds Week backup data to table list
            if (InputSortBy.Text == "Month" || InputSortBy.Text == "All")   //checks if Month needs to be added to table
                table = AddToTable("Month", table, 12); //adds Month backup data to table list
            if (InputSortBy.Text == "Year" || InputSortBy.Text == "All")    //checks if Year needs to be added to table
                table = AddToTable("Year", table, 999); //adds Year backup data to table list

            foreach (string row in table)   //loops for each row that needs to be added to the table
            {
                string[] section = row.Split('|');  //splits the data of the row into individual components
                TableBackupInfo.Rows.Add(section[0], Convert.ToDateTime(section[1]), section[2], section[3]);   //adds a row to the table with the backup's data
            }
        }

        private List<string> AddToTable(string type, List<string> table, int maxBackups)
        {   //gets an array of all the ids from that type of backup
            string[] ids = Functions.FileSearch.ReturnSegment("backup", type, 2, 0, true).Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < maxBackups; ++i)    //loops for the number of possible backups of that type
            {
                try
                {   //adds the record to the table list
                    table.Add(Functions.FileSearch.ReturnLine("backup", ids[ids.Length - i - 1], 0));
                }
                catch (IndexOutOfRangeException)    //catches and prevents potential error
                {
                    return table;   //returns the table with added rows
                }
            }
            return table;   //returns the table with added rows
        }

        private void ShowLastBackup()
        {
            int rowCount = TableBackupInfo.Rows.Count;  //counts the number of rows in the table
            LabelBackupRecent.Text = "Most recent backup:\n" + TableBackupInfo.Rows[0].Cells[1].Value;     //shows the date from the first row in the table         
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
                files = new DirectoryInfo(drive + @":\Backup\" + backupFolder + @"\Leagues").GetFiles("*.txt");    //gets all the .txt files in this directory
            }   
            catch (DirectoryNotFoundException)  //catches and prevents potential error
            {
                drive = "F";
                files = new DirectoryInfo(drive + @":\Backup\" + backupFolder + @"\Leagues").GetFiles("*.txt");    //gets all the .txt files in this directory
            }
            //an array of all the files that needs to be resotred
            string[] filesList = { "userPersonalDetails", "userAccountDetails", "userJoinRequests", "trainingDetails", "matchDetails", "matchAvailability", "matchStats", "playerMatchStats", "leagues" };
            
            foreach (string sourceFile in filesList)    //loops for each file that needs to be restored
            {   //copies the file from the backup folder overwriting the current file
                File.Copy(drive + @":\Backup\" + backupFolder + @"\" + sourceFile + ".txt", sourceFile + ".txt", true);  
            }
            foreach (FileInfo file in files)    //loops for each league file in the \Leagues directory
            {   //copies the file from the \Leagues directory in the backup folder overwriting the current file
                File.Copy(drive + @":\Backup\" + backupFolder + @"\Leagues\" + file.ToString(), @"Leagues\" + file.ToString(), true);
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