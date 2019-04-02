using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class UpcomingTrainings : Form
    {
        public UpcomingTrainings()
        {
            InitializeComponent();
        }

        private void ViewTraining_Load(object sender, EventArgs e)
        {
            InputFilter.SelectedItem = "Upcoming";  //sets the selected item in the drop down box to be 'Upcoming'
            TableViewTrainings.MultiSelect = false;  //allows the user to only select one row at a time in the table
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("trainingDetails.txt");    //opens the file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through the file reading one line at a time until line is empyt
            {
                string[] section = line.Split('|'); //splits the line into individual components by the delimiter '|'
                //checks if the date for that training adheres the condition selected in the drop down box
                if ((Convert.ToDateTime(section[5]) >= DateTime.Today && InputFilter.Text == "Upcoming") || (Convert.ToDateTime(section[5]) < DateTime.Today && InputFilter.Text == "Past") || (InputFilter.Text == "All"))
                    //adds a row to the table with the training data
                    TableViewTrainings.Rows.Add(section[0], section[1], section[2] + ":" + section[3], section[4], section[5]); 
            }
            file.Close();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTrainingData();     //calls on function to load the training data into the database
                NavToEditTraining();    //navigation to View Training form
            }
            catch (ArgumentOutOfRangeException) //catches and prevents potential error
            {
                MessageBox.Show("Select a training session to view it.");
            }
        }

        private void LoadTrainingData()
        {   //loads the training data into TrainingData in the database
            string[] time = TableViewTrainings.SelectedRows[0].Cells[2].Value.ToString().Split(':');
            Database.TrainingData.id = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[0].Value);
            Database.TrainingData.team = TableViewTrainings.SelectedRows[0].Cells[1].Value.ToString();
            Database.TrainingData.timeH = Convert.ToInt16(time[0]);
            Database.TrainingData.timeM = Convert.ToInt16(time[1]);
            Database.TrainingData.duration = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[3].Value);
            Database.TrainingData.date = TableViewTrainings.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void NavToEditTraining()
        {
            new ViewTrainings().Show(); //shows the View Training form
            Close();    //closes this form
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //navigation to Home form
        }

        private void NavToHome()
        {
            new Home().Show();  //shows the Home form
            Close();    //closes this form
        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableViewTrainings.Rows.Clear();    //clears all the data in the table
            FillTableData();    //calls on function to fill the table with data
            ListSortDirection direction = ListSortDirection.Descending; //sets the direction for the table to be ordered in
            if (InputFilter.Text == "Upcoming") //checks if drop down box has 'Upcoming' selected
                direction = ListSortDirection.Ascending;    //sets table order direction to ascending
            TableViewTrainings.Sort(TableViewTrainings.Columns[3], direction);  //sorts table based on date in the direction specified
        }
    }
}
