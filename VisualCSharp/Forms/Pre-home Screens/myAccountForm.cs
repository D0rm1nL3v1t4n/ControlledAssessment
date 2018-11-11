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

namespace VisualCSharp.Forms.Home_Screens
{
    public partial class myAccountDetails : Form
    {
        public class Changes
        {
            public static int NoMade = 0;
            public static bool title = false;
            public static bool firstName = false;
            public static bool lastName = false;
            public static bool dateOfBirth = false;
            public static bool emailAddress = false;
            public static bool telephoneNumber = false;
            public static bool postcode = false;
        }

        public myAccountDetails()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnHome();
            }
        }

        private void ReturnHome()
        {
            if (UserData.userLevel == "Admin")
            {
                new AdminHomeForm().Show();
            }
            else if (UserData.userLevel == "Coach")
            {
                new coachHomeForm().Show();
            }
            else if (UserData.userLevel == "Player")
            {
                new playerHomeForm().Show();
            }
            this.Hide();          
        }

        private void myAccountDetails_Load(object sender, EventArgs e)
        {
            grpbxPersonalDetails.Text = UserData.username;
            cmbTitle.Text = UserData.title;
            txtFirstName.Text = UserData.firstName;
            txtLastName.Text = UserData.lastName;
            dateOfBirth.Text = UserData.dateOfBirth;
            txtEmailAddress.Text = UserData.emailAddress;
            txtTelephoneNo.Text = UserData.telephoneNumber;
            txtPostcode.Text = UserData.postcode;
        }

        

        private void BtnSaveAccountDetails_Click(object sender, EventArgs e)
        {
            int changesMade = Changes.NoMade;
            if (changesMade == 0)
            {
                if (MessageBox.Show("You have not made any changes, do you want to return to the home screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ReturnHome();
                }
            }
            else if (changesMade > 0)
            {
                if (MessageBox.Show("You have made " + changesMade.ToString() + ", do you wish to save these changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChangeDetails();
                }
            }
        }
        

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTitle.Text != UserData.title && Changes.title == false)
            {
                Changes.NoMade += 1;
                Changes.title = true;
            }
            if (cmbTitle.Text == UserData.title && Changes.title == true)
            {
                Changes.NoMade -= 1;
                Changes.title = false;
            }
            ShowChangesMade();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != UserData.firstName && Changes.firstName == false)
            {
                Changes.NoMade += 1;
                Changes.firstName = true;
            }
            if (txtFirstName.Text == UserData.firstName && Changes.firstName == true)
            {
                Changes.NoMade -= 1;
                Changes.firstName = false;
            }
            ShowChangesMade();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != UserData.lastName && Changes.lastName == false)
            {
                Changes.NoMade += 1;
                Changes.lastName = true;
            }
            if (txtLastName.Text == UserData.lastName && Changes.lastName == true)
            {
                Changes.NoMade -= 1;
                Changes.lastName = false;
            }
            ShowChangesMade();
        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dateOfBirth.Text != UserData.dateOfBirth && Changes.dateOfBirth == false)
            {
                Changes.NoMade += 1;
                Changes.dateOfBirth = true;
            }
            if (dateOfBirth.Text == UserData.dateOfBirth && Changes.dateOfBirth == true)
            {
                Changes.NoMade -= 1;
                Changes.dateOfBirth = false;
            }
            ShowChangesMade();
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text != UserData.emailAddress && Changes.emailAddress == false)
            {
                Changes.NoMade += 1;
                Changes.emailAddress = true;
            }
            if (txtEmailAddress.Text == UserData.emailAddress && Changes.emailAddress == true)
            {
                Changes.NoMade -= 1;
                Changes.emailAddress = false;
            }
            ShowChangesMade();
        }

        private void txtTelephoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTelephoneNo.Text != UserData.telephoneNumber && Changes.telephoneNumber == false)
            {
                Changes.NoMade += 1;
                Changes.telephoneNumber = true;
            }
            if (txtTelephoneNo.Text == UserData.telephoneNumber && Changes.telephoneNumber == true)
            {
                Changes.NoMade -= 1;
                Changes.telephoneNumber = false;
            }
            ShowChangesMade();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostcode.Text != UserData.postcode && Changes.postcode == false)
            {
                Changes.NoMade += 1;
                Changes.postcode = true;
            }
            if (txtPostcode.Text == UserData.postcode && Changes.postcode == true)
            {
                Changes.NoMade -= 1;
                Changes.postcode = false;
            }
            ShowChangesMade();
        }

        private void ShowChangesMade()
        {
            LblChangesMade.Text = Changes.NoMade + " change(s) made.";
        }


        private void ChangeDetails()
        {
            int noOfLines = File.ReadLines("userPersonalDetails.txt").Count();
            string[,] localFile = new string[noOfLines, 8];
            int lineNo = 0;

            StreamReader userPersonalDetailsFile = new StreamReader("userPersonalDetails.txt");
            string individualLine = userPersonalDetailsFile.ReadLine();

            while (null != individualLine)
            {
                string[] section = individualLine.Split('|');

                localFile[lineNo, 0] = section[0];  //Store userID

                if (section[0] == UserData.userID)
                {
                    localFile[lineNo, 1] = cmbTitle.Text;       //Store NEW title
                    localFile[lineNo, 2] = txtFirstName.Text;   //Store NEW first name
                    localFile[lineNo, 3] = txtLastName.Text;        //Store NEW last name
                    localFile[lineNo, 4] = dateOfBirth.Text;        //Store NEW DOB
                    localFile[lineNo, 5] = txtEmailAddress.Text;    //Store NEW email address
                    localFile[lineNo, 6] = txtTelephoneNo.Text; //Store NEW telephone no
                    localFile[lineNo, 7] = txtPostcode.Text;        //Store NEW postcode
                }
                else
                {
                    localFile[lineNo, 1] = section[1];  //Store title
                    localFile[lineNo, 2] = section[2];  //Store first name
                    localFile[lineNo, 3] = section[3];  //Store last name
                    localFile[lineNo, 4] = section[4];  //Store DOB
                    localFile[lineNo, 5] = section[5];  //Store email address
                    localFile[lineNo, 6] = section[6];  //Store telephone no
                    localFile[lineNo, 7] = section[7];  //Store postcode
                }

                lineNo++;
                individualLine = userPersonalDetailsFile.ReadLine();
            }
            userPersonalDetailsFile.Close();


            string[] tempLine = new string[8];
            int i = 0;

            //File.WriteAllText("userPersonalDetails.txt", String.Empty);

            using (System.IO.StreamWriter personalDetailsFile =
            new System.IO.StreamWriter("userPersonalDetails.txt"))
            {
                foreach (string line in localFile)
                {
                    tempLine[i] = line;
                    i++;
                    if (i % 8 == 0)
                    {
                        i = 0;
                        personalDetailsFile.WriteLine(tempLine[0] + "|" + tempLine[1] + "|" + tempLine[2] + "|" + tempLine[3] + "|"
                                                      + tempLine[4] + "|" + tempLine[5] + "|" + tempLine[6] + "|" + tempLine[7] + "|");
                    }

                }
            }

            UserData.title = cmbTitle.Text;
            UserData.firstName = txtFirstName.Text;
            UserData.lastName = txtLastName.Text;
            UserData.dateOfBirth = dateOfBirth.Text;
            UserData.emailAddress = txtEmailAddress.Text;
            UserData.telephoneNumber = txtTelephoneNo.Text;
            UserData.postcode = txtPostcode.Text;

            MessageBox.Show("Your details have been updated.");
            ReturnHome();
        }

        
    }
}
