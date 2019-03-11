using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

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
            ShowDetails();
        }

        private void ShowDetails()
        {
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
            if (Changes.count > 0)
            {
                if (MessageBox.Show("You have made " + Changes.count.ToString() + " changes, do you wish to save these changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool allValid = Functions.Validation.IsTitleValid(InputTitle.Text) && Functions.Validation.IsFirstNameValid(InputFirstName.Text) && Functions.Validation.IsLastNameValid(InputLastName.Text)
                        && Functions.Validation.IsDOBValid(InputDateOfBirth.Value) && Functions.Validation.IsEmailAddressValid(InputEmailAddress.Text) && Functions.Validation.IsTelephoneNumberValid(InputTelephoneNumber.Text)
                        && Functions.Validation.IsPostcodeValid(InputPostcode.Text);
                    if (allValid)
                    {
                        ChangeDetails();
                        if (Application.OpenForms["ChangePassword"] == null)
                            NavToHome();
                        else
                            MessageBox.Show("Cannot save as Change password form is open.\nTo save, close down the open Change password form.");
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
            Functions.FileEdit.EditLine("userPersonalDetails", 8, newData, searchIndex, searchData);
            UpdateDetails();
            MessageBox.Show("Your details have been updated.");
        }

        private void UpdateDetails()
        {
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
            LabelChangesMade.Text = Changes.count + " change(s) made.";
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ChangePassword"] == null)
            {
                if (Changes.count > 0)
                {
                    if (MessageBox.Show("There are " + Changes.count.ToString() + " unsaved changes, are you sure you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        NavToHome();
                    }
                    return;
                }
                NavToHome();
            }
            else
                MessageBox.Show("Change Password form is open.\nClose it down before exiting.");

        }

        private void NavToHome()
        {
            new Home().Show();
            Close();
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;
                ShowChangesMade();
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;
                ShowChangesMade();
                return false;
            }
            return changedVal;
        }

        private void InputTitle_SelectedIndexChanged(object sender, EventArgs e) 
        {
            Changes.title = DetailsChanged(InputTitle.Text, Database.UserData.title, Changes.title);
        }

        private void InputFirstName_TextChanged(object sender, EventArgs e) 
        { 
            Changes.firstName = DetailsChanged(InputFirstName.Text, Database.UserData.firstName, Changes.firstName);
        }

        private void InputLastName_TextChanged(object sender, EventArgs e) 
        { 
            Changes.lastName = DetailsChanged(InputLastName.Text, Database.UserData.lastName, Changes.lastName);
        }

        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e) 
        {
            Changes.dateOfBirth = DetailsChanged(InputDateOfBirth.Text, Database.UserData.dateOfBirth, Changes.dateOfBirth);
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e) 
        { 
            Changes.emailAddress = DetailsChanged(InputEmailAddress.Text, Database.UserData.emailAddress, Changes.emailAddress);
        }

        private void InputTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            Changes.telephoneNumber = DetailsChanged(InputTelephoneNumber.Text, Database.UserData.telephoneNumber, Changes.telephoneNumber);
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        { 
            Changes.postcode = DetailsChanged(InputPostcode.Text, Database.UserData.postcode, Changes.postcode);
        }

        private void EventNavChangePassword_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ChangePassword"] == null)
                new Views.ChangePassword().Show();
            else
                MessageBox.Show("Change password form is already open.");
        }
    }
}
