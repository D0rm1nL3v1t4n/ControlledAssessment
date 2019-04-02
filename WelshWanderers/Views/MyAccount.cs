using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        //sets variables for counting the number of changes and boolean variables which data variables have been changed
        private class Changes
        {
            public static int count = 0;
            public static bool title = false;
            public static bool firstName = false;
            public static bool lastName = false;
            public static bool dateOfBirth = false;
            public static bool emailAddress = false;
            public static bool telephoneNumber = false;
            public static bool postcode = false;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            ShowDetails();  //calls on function to show the data in the text boxes
        }

        private void ShowDetails()
        {
            //loads data into text boxes
            InputTitle.Text = Database.UserData.title;
            InputFirstName.Text = Database.UserData.firstName;
            InputLastName.Text = Database.UserData.lastName;
            InputDateOfBirth.Text = Database.UserData.dateOfBirth;
            InputEmailAddress.Text = Database.UserData.emailAddress;
            InputTelephoneNumber.Text = Database.UserData.telephoneNumber;
            InputPostcode.Text = Database.UserData.postcode;
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {
                //Message box with Yes No buttons to check if the user wants to save their n number of changes
                if (MessageBox.Show("You have made " + Changes.count.ToString() + " changes, do you wish to save these changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //checks all inputs are still valid
                    bool allValid = Functions.Validation.IsTitleValid(InputTitle.Text) && Functions.Validation.IsFirstNameValid(InputFirstName.Text) && Functions.Validation.IsLastNameValid(InputLastName.Text)
                        && Functions.Validation.IsDOBValid(InputDateOfBirth.Value) && Functions.Validation.IsEmailAddressValid(InputEmailAddress.Text) && Functions.Validation.IsTelephoneNumberValid(InputTelephoneNumber.Text)
                        && Functions.Validation.IsPostcodeValid(InputPostcode.Text);
                    if (allValid)
                    {
                        ChangeDetails();    //changes user's details
                        if (Application.OpenForms["ChangePassword"] != null)    //checks if Change Password form is open
                            Application.OpenForms["ChangePassword"].Close();    //closes Change Password form if open
                        NavToHome();    //navigation to Home form
                    }
                }
            }
            else
                MessageBox.Show("You have not made any changes to save.");
        }

        private void ChangeDetails()
        {
            string[] newData = { InputTitle.Text, InputFirstName.Text, InputLastName.Text, InputDateOfBirth.Text, InputEmailAddress.Text, InputTelephoneNumber.Text, InputPostcode.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.UserData.id.ToString() };
            Functions.FileEdit.EditLine("userPersonalDetails", 8,    newData, searchIndex, searchData); //changes the user's details
            UpdateDetails();    //calls on function to update UserData in database
            MessageBox.Show("Your details have been updated.");
        }

        private void UpdateDetails()
        {
            //updates UserData variables in database
            Database.UserData.title = InputTitle.Text;
            Database.UserData.firstName = InputFirstName.Text;
            Database.UserData.lastName = InputLastName.Text;
            Database.UserData.dateOfBirth = InputDateOfBirth.Text;
            Database.UserData.emailAddress = InputEmailAddress.Text;
            Database.UserData.telephoneNumber = InputTelephoneNumber.Text;
            Database.UserData.postcode = InputPostcode.Text;
        }

        private void ShowChangesMade()
        {
            LabelChangesMade.Text = Changes.count + " change(s) made."; //shows the number of changes the user has made
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ChangePassword"] != null)    //checks if Change Password form is open
                Application.OpenForms["ChangePassword"].Close();    //closes Change Password form if open
            if (Changes.count > 0)  //checks if any changes have been made
            {
                //Message box with Yes No buttons asking the user if they want to exit even though there are unsaved changes
                if (MessageBox.Show("There are " + Changes.count.ToString() + " unsaved changes, are you sure you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NavToHome();    //navigation Home
                }
                return;
            }
            NavToHome();    //navigation Home
        }

        private void NavToHome()
        {
            new Home().Show();  //shows Home form
            Close();    //closes this form
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)  //checks if changed data not equal to original data => change made
            {
                ++Changes.count;    //increments changes made count
                ShowChangesMade();  //calls on function to show changes made to data
                return true;    //return true as change has been made
            }
            else if (inputData == databaseValue && changedVal == true)  //checks if changed data equal to original data => change not made
            {
                --Changes.count;    //decrease changes made count by 1
                ShowChangesMade();  //calls on function to show changes changes made to data
                return false;   //returns false as change has not been made to oringinal data
            }
            return changedVal;  //no change to state of data change
        }

        private void InputTitle_SelectedIndexChanged(object sender, EventArgs e)
        {   //checks if title has been changed from original data
            Changes.title = DetailsChanged(InputTitle.Text, Database.UserData.title, Changes.title);    
        }

        private void InputFirstName_TextChanged(object sender, EventArgs e)
        {   //checks if first name has been changed from original data
            Changes.firstName = DetailsChanged(InputFirstName.Text, Database.UserData.firstName, Changes.firstName);    
        }

        private void InputLastName_TextChanged(object sender, EventArgs e) 
        {   //checks if last name has been changed from original data
            Changes.lastName = DetailsChanged(InputLastName.Text, Database.UserData.lastName, Changes.lastName);
        }

        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e) 
        {   //checks if date of birth has been changed from original data
            Changes.dateOfBirth = DetailsChanged(InputDateOfBirth.Text, Database.UserData.dateOfBirth, Changes.dateOfBirth);
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e) 
        {   //checks if email address has been changed from original data
            Changes.emailAddress = DetailsChanged(InputEmailAddress.Text, Database.UserData.emailAddress, Changes.emailAddress);
        }

        private void InputTelephoneNumber_TextChanged(object sender, EventArgs e)
        {   //checks if telephone number has been changed from original data
            Changes.telephoneNumber = DetailsChanged(InputTelephoneNumber.Text, Database.UserData.telephoneNumber, Changes.telephoneNumber);
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        {   //checks if postocde has been changed from original data
            Changes.postcode = DetailsChanged(InputPostcode.Text, Database.UserData.postcode, Changes.postcode);
        }

        private void EventNavChangePassword_Click(object sender, EventArgs e)
        {   //checks if Change Password form is already open
            if (Application.OpenForms["ChangePassword"] == null)
                new Views.ChangePassword().Show();  //shows Change Password form if its not already open
            else
                MessageBox.Show("Change password form is already open.");   //alerts user Change Password form is already open
        }
    }
}
