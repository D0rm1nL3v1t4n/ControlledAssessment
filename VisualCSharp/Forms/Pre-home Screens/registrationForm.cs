using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace VisualCSharp.Forms
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new signInForm().Show();
            this.Hide();
        }

        private void btnRegisterRequest_Click(object sender, EventArgs e)
        {
            //Validate all neccessary inputs
            //Store all details in Requests file with Request ID


            //Title: Not null
            //First name: Not null & < 20
            //Last name: Not null & < 30
            //Email address: Not null & < 30 & look for @
            //Telephone: > 7 & < 10
            //Postcode: Postcode format

            //Username: > 6 & < 20
            //Password: Contain {Uppercase & Symbol & Number} & > 6 & < 20
            //Confirm Password: Equal to Password
            //Security Question: Not Null & < 50
            //Answer: Not Null & < 20          

            bool isRegisterValid = false;

            bool isTitleValid = CheckValidTitle();
            bool isFirstNameValid = CheckValidFirstName();
            bool isLastNameValid = CheckValidLastName();
            bool isEmailAddressValid = CheckValidEmailAddress();
            bool isTelephoneNumberValid = CheckValidTelephoneNumber();
            bool isPostcodeValid = CheckValidPostcode();
            bool isUsernameValid = CheckValidUsername();
            bool isPasswordValid = CheckValidPassword();
            bool isPasswordConfirmValid = CheckValidConfirmPassword();
            
            if (isTitleValid == true && isFirstNameValid == true && isLastNameValid == true 
                && isEmailAddressValid == true && isTelephoneNumberValid == true && isPostcodeValid == true
                && isUsernameValid == true && isPasswordValid == true && isPasswordConfirmValid == true)
            {
                isRegisterValid = true;
            }


            if (isRegisterValid == true)
            {
                StoreData();
                MessageBox.Show("Registration successful.");
                this.Hide();
                new signInForm().Show();
            }

        }

        private void StoreData()
        {
            int id = File.ReadAllLines("userAccountDetails.txt").Count() + 1;

            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter("userPersonalDetails.txt", true))
            {
                file.WriteLine(id + "|" + cmbTitle.Text + "|" + txtFirstName.Text + "|"
                    + txtLastName.Text + "|" + dateOfBirth.Text + "|" + txtEmailAddress.Text + "|"
                    + txtTelephoneNo.Text + "|" + txtPostcode.Text + "|");
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("userAccountDetails.txt", true))
            {
                file.WriteLine(id + "|" + TxtUsername.Text + "|"
                    + TxtPassword.Text + "|" + cmbAccessLevel.Text);
            }
        }


        private bool CheckValidTitle()
        {
            bool isValid = false;
            if (cmbTitle.Text != "")
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: You must select a title.");
            }
            return isValid;
        }

        private bool CheckValidFirstName()
        {
            bool isValid = false;
            if (txtFirstName.TextLength > 0 && !txtFirstName.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: You must enter a first name.");
            }
            return isValid;
        }

        private bool CheckValidLastName()
        {
            bool isValid = false;
            if (txtLastName.TextLength > 0 && !txtLastName.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: You must enter a last name.");
            }
            return isValid;
        }

        private bool CheckValidEmailAddress()
        {
            Regex emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match compare = emailRegex.Match(txtEmailAddress.Text);
            bool isValid = false;
            if (compare.Success && !txtEmailAddress.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: You must enter a valid email address.");
            }
            return isValid;
        }

        private bool CheckValidTelephoneNumber()  
        {
            Regex telephoneRegex = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
            Match compare = telephoneRegex.Match(txtTelephoneNo.Text);
            bool isValid = false;
            if (compare.Success && !txtTelephoneNo.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Telephone number must be at least 8 characters long.");
            }
            return isValid;
        }

        private bool CheckValidPostcode()
        {
            Regex postcodeRegex = new Regex("(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})");
            Match compare = postcodeRegex.Match(txtPostcode.Text);
            bool isValid = false;
            if (compare.Success && !txtPostcode.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Must enter a postcode of valid format.");
            }
            return isValid;
        }

        private bool CheckValidUsername()
        {
            bool isValid = false;
            if (TxtUsername.TextLength > 5 && !TxtUsername.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Username must be at least 6 characters long.");
            }
            return isValid;
        }

        private bool CheckValidPassword()
        {
            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$");
            Match compare = passwordRegex.Match(TxtPassword.Text);
            bool isValid = false;
            if (compare.Success && !TxtPassword.Text.Contains("|"))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Password must be of the following format:\n" +
                                "Contain at least one uppercase character,\n" +
                                "Contain at least one lowercase character,\n" +
                                "Contain at least one numerical character,\n" +
                                "Contain at least one special character,\n" +
                                "Be at least 8 and at most 20 characters in length.");
            }
            
            return isValid;
        }

        private bool CheckValidConfirmPassword()
        {
            bool isValid = false;
            if (TxtPassword.Text == TxtPasswordConfirm.Text)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Your passwords do not match.");
            }
            return isValid;
        }


        private void BtnRegisterHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Request: After making a request, wait until your registration is accepted. You will be notified by email.\n\n" +
                "Personal Details: This information is required to be stored by the club for all players & coaches.\n\n" +
                "Account Details: This information is to be used to sign into the system, or reset your password if requried.\n\n\n" +
                "You cannot use the symbol '|' in any of the inputs.");
        }
    }
}
