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

namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    public partial class EditTrainingForm : Form
    {
        public class Changes
        {
            public static int noMade = 0;
            public static bool trainingType = false;
            public static bool startTimeHour = false;
            public static bool startTimeMin = false;
            public static bool finishTimeHour = false;
            public static bool finishTimeMin = false;
            public static bool date = false;
        }
        
        public EditTrainingForm()
        {
            InitializeComponent();
        }

        private void EditTrainingForm_Load(object sender, EventArgs e)
        {
            CmbTrainingType.Text = TrainingData.trainingType;
            txtStartHours.Text = TrainingData.startTimeHour;
            txtStartMin.Text = TrainingData.startTimeMin;
            txtFinishHours.Text = TrainingData.finishTimeHour;
            txtFinishMin.Text = TrainingData.finishTimeMin;
            TrainingDate.Text = TrainingData.date;
        }

        private void ReturnViewTrainings()
        {
            new Forms.Sub_home_Screens.Shared_sub_Screens.ViewTrainings().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnViewTrainings();
            }
        }

        private void BtnSaveTraining_Click(object sender, EventArgs e)
        {
            if (Changes.noMade == 0)
            {
                if (MessageBox.Show("You have not made any changes, do you want to return to the previous screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ReturnViewTrainings();
                }
            }
            else if (Changes.noMade > 0)
            {
                if (MessageBox.Show("You have made " + Changes.noMade.ToString() + ", do you wish to save these changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChangeDetails();
                }
            }
        }

        private void ShowChangesMade()
        {
            LblChangesMade.Text = Changes.noMade + " change(s) made.";
        }

        private void ChangeDetails()
        {
            int noOfLines = File.ReadLines("trainingDetails.txt").Count();
            string[,] localFile = new string[noOfLines, 7];
            int lineNo = 0;

            StreamReader trainingDetailsFile = new StreamReader("trainingDetails.txt");
            string individualLine = trainingDetailsFile.ReadLine();

            while (null != individualLine)
            {
                string[] section = individualLine.Split('|');

                localFile[lineNo, 0] = section[0];

                if (section[0] == TrainingData.trainingID)
                {
                    localFile[lineNo, 1] = CmbTrainingType.Text;
                    localFile[lineNo, 2] = txtStartHours.Text;
                    localFile[lineNo, 3] = txtStartMin.Text;
                    localFile[lineNo, 4] = txtFinishHours.Text;
                    localFile[lineNo, 5] = txtFinishMin.Text;
                    localFile[lineNo, 6] = TrainingDate.Text;
                }
                else
                {
                    localFile[lineNo, 1] = section[1];
                    localFile[lineNo, 2] = section[2];
                    localFile[lineNo, 3] = section[3];
                    localFile[lineNo, 4] = section[4];
                    localFile[lineNo, 5] = section[5];
                    localFile[lineNo, 6] = section[6];
                }

                ++lineNo;
                individualLine = trainingDetailsFile.ReadLine();
            }
            trainingDetailsFile.Close();

            string[] tempLine = new string[7];
            int i = 0;

            using (System.IO.StreamWriter trainingDetails =
            new System.IO.StreamWriter("trainingDetails.txt"))
            {
                foreach (string line in localFile)
                {
                    tempLine[i] = line;
                    i++;
                    if (i % 7 == 0)
                    {
                        i = 0;
                        trainingDetails.WriteLine(
                            tempLine[0] + "|" + tempLine[1] + "|" +
                            tempLine[2] + "|" + tempLine[3] + "|" +
                            tempLine[4] + "|" + tempLine[5] + "|" +
                            tempLine[6] + "|");
                    }

                }
            }

            TrainingData.trainingType = CmbTrainingType.Text;
            TrainingData.startTimeHour = txtStartHours.Text;
            TrainingData.startTimeMin = txtStartMin.Text;
            TrainingData.finishTimeHour = txtFinishHours.Text;
            TrainingData.finishTimeMin = txtFinishMin.Text;
            TrainingData.date = TrainingDate.Text;

            MessageBox.Show("Training details have been updated!");
            ReturnViewTrainings();
        }

        private void CmbTrainingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTrainingType.Text != TrainingData.trainingType && Changes.trainingType == false)
            {
                Changes.noMade += 1;
                Changes.trainingType = true;
            }
            if (CmbTrainingType.Text == TrainingData.trainingType && Changes.trainingType == true)
            {
                Changes.noMade -= 1;
                Changes.trainingType = false;
            }
            ShowChangesMade();
        }

        private void txtStartHours_TextChanged(object sender, EventArgs e)
        {
            if (txtStartHours.Text != TrainingData.startTimeHour && Changes.startTimeHour == false)
            {
                Changes.noMade += 1;
                Changes.startTimeHour = true;
            }
            if (txtStartHours.Text == TrainingData.startTimeHour && Changes.startTimeHour == true)
            {
                Changes.noMade -= 1;
                Changes.startTimeHour = false;
            }
            ShowChangesMade();
        }

        private void txtStartMin_TextChanged(object sender, EventArgs e)
        {
            if (txtStartMin.Text != TrainingData.startTimeMin && Changes.startTimeMin == false)
            {
                Changes.noMade += 1;
                Changes.startTimeMin = true;
            }
            if (txtStartMin.Text == TrainingData.startTimeMin && Changes.startTimeMin == true)
            {
                Changes.noMade -= 1;
                Changes.startTimeMin = false;
            }
            ShowChangesMade();
        }

        private void txtFinishHours_TextChanged(object sender, EventArgs e)
        {
            if (txtFinishHours.Text != TrainingData.finishTimeHour && Changes.finishTimeHour == false)
            {
                Changes.noMade += 1;
                Changes.finishTimeHour = true;
            }
            if (txtFinishHours.Text == TrainingData.finishTimeHour && Changes.finishTimeHour == true)
            {
                Changes.noMade -= 1;
                Changes.finishTimeHour = false;
            }
            ShowChangesMade();
        }

        private void txtFinishMin_TextChanged(object sender, EventArgs e)
        {
            if (txtFinishMin.Text != TrainingData.finishTimeMin && Changes.finishTimeMin == false)
            {
                Changes.noMade += 1;
                Changes.finishTimeMin = true;
            }
            if (txtFinishMin.Text == TrainingData.finishTimeMin && Changes.finishTimeMin == true)
            {
                Changes.noMade -= 1;
                Changes.finishTimeMin = false;
            }
            ShowChangesMade();
        }

        private void TrainingDate_ValueChanged(object sender, EventArgs e)
        {
            if (TrainingDate.Text != TrainingData.date && Changes.date == false)
            {
                Changes.noMade += 1;
                Changes.date = true;
            }
            if (TrainingDate.Text == TrainingData.date && Changes.date == true)
            {
                Changes.noMade -= 1;
                Changes.date = false;
            }
            ShowChangesMade();
        }



        
    }
}
