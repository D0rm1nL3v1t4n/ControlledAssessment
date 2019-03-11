using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WelshWanderers
{
    public partial class RegisterRequest : Form
    {
        public RegisterRequest()
        {
            InitializeComponent();
        }

        private static string generatedCode = "";
        private static string emailConfirmedWith = "";

        private class Changes
        {
            public static bool title = true;
            public static bool firstName = true;
            public static bool lastName = true;
            public static bool emailAddress = true;
            public static bool dateOfBirth = true;
            public static bool telephoneNumber = true;
            public static bool postcode = true;
            public static bool username = true;
            public static bool password = true;
            public static bool confirmPassword = true;

            public static void ResetChanges()
            {
                title = false;
                firstName = false;
                lastName = false;
                emailAddress = false;
                dateOfBirth = false;
                telephoneNumber = false;
                postcode = false;
                username = false;
                password = false;
                confirmPassword = false;
            }

        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToSignIn();
        }

        private void NavToSignIn()
        {
            new SignIn().Show();
            Close();
        }

        private void EventNavRegisterRequest_Click(object sender, EventArgs e)
        {
            if (emailConfirmedWith == InputEmailAddress.Text)
            {
                if (CheckValidation())
                {
                    if (generatedCode == InputCode.Text)
                    {
                        WriteRequestData();
                        EmailRegistrationRequest();
                        MessageBox.Show("Your registration request has been made.");
                        NavToSignIn();
                    }
                    else
                        MessageBox.Show("The code entered is incorrect.");
                }
                else
                {
                    MessageBox.Show("All details entered must be valid before making a registration request.");
                }
            }
            else
                MessageBox.Show("You have changed the email that you have confirmed with the code. Please resend the code to this new email before continuing to confirm this, new email.");
        }

        private bool CheckValidation()
        {
            bool title = CheckTitle();
            bool firstName = CheckFirstName();
            bool lastName = CheckLastName();
            bool dob = CheckDOB();
            bool emailAddress = CheckEmailAddress();
            bool telephoneNumber = CheckTelephoneNumber();
            bool postcode = CheckPostcode();
            bool username = CheckUsername();
            bool password = CheckPassword();
            return title && firstName && lastName && dob && emailAddress && telephoneNumber && postcode && username && password;
        }

        private bool CheckTitle()
        {
            if (Changes.title)
                return Functions.Validation.IsTitleValid(InputTitle.Text);
            return true;
        }

        private bool CheckFirstName()
        {
            if (Changes.firstName)
                return Functions.Validation.IsFirstNameValid(InputFirstName.Text);
            return true;
        }

        private bool CheckLastName()
        {
            if (Changes.lastName)
                return Functions.Validation.IsLastNameValid(InputLastName.Text);
            return true;
        }

        private bool CheckDOB()
        {
            if (Changes.dateOfBirth)
                return Functions.Validation.IsDOBValid(InputDateOfBirth.Value);
            return true;
        }

        private bool CheckEmailAddress()
        {
            if (Changes.emailAddress)
                return Functions.Validation.IsEmailAddressValid(InputEmailAddress.Text);
            return true;
        }

        private bool CheckTelephoneNumber()
        {
            if (Changes.telephoneNumber)
                return Functions.Validation.IsTelephoneNumberValid(InputTelephoneNumber.Text);
            return true;
        }

        private bool CheckPostcode()
        {
            if (Changes.postcode)
                return Functions.Validation.IsPostcodeValid(InputPostcode.Text);
            return true;
        }

        private bool CheckUsername()
        {
            if (Changes.username)
                return Functions.Validation.IsUsernameValid(InputUsername.Text);
            return true;
        }

        private bool CheckPassword()
        {
            if (Changes.password || Changes.confirmPassword)
                return Functions.Validation.IsPasswordValid(InputPassword.Text, InputConfirmPassword.Text);
            return true;
        }


        private void WriteRequestData()
        {
            Functions.FileWrite.WriteData("userJoinRequests", "0" + "|" + InputTitle.Text + "|" + InputFirstName.Text + "|" + InputLastName.Text + "|" + InputDateOfBirth.Text
                 + "|" + InputEmailAddress.Text + "|" + InputTelephoneNumber.Text + "|" + InputPostcode.Text + "|" + InputUsername.Text.ToLower() + "|" + Functions.HashAlgorithm.HashPassword(InputPassword.Text) + "|" + InputTeam.Text + "|");
        }


        private void EventShowHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Request: After making a request, a club admin must accept your request to grant you access to the system.\n"
                + "Before you can make your registration, you must confirm your email address. You will recieve an 8 digit code to the email you have given.\n"
                + "You will be notified by email about your request, and any further updates regarding your request.");
        }

        private void EmailRegistrationRequest()
        {
            string body = "This is an email to confirm your registration request (username: " + InputUsername.Text + ") to the Welsh Wanderers system.\n\nYour request must be accepted for you to be able to use the system.\nYou will get a confirmation email regarding your request once it has been processed.\n\n\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request", body, recipient);
        }

        private void EventSendCode_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                SendCodeEmail();
                ChangeControls();
            }   
        }

        private void ChangeControls()
        {
            EventNavRegisterRequest.Enabled = true;
            EventSendCode.Hide();
            LabelCode.Show();
            InputCode.Show();
            EventResend.Show();
        }

        private void SendCodeEmail()
        {
            Changes.ResetChanges();
            emailConfirmedWith = InputEmailAddress.Text;
            generatedCode = Functions.RandomCode.GenerateCode(8);
            string[] email = { InputEmailAddress.Text };
            string body = "You have been sent the following code:\n\n" + generatedCode + "\n\nEnter this code into the system to confirm your email address.\n\n\nWelshWanderers";
            Functions.SendEmail.Email("Email Confirmation", body, email);
        }

        private void EventResend_Click(object sender, EventArgs e)
        {
            SendCodeEmail();
        }

        private void InputCode_TextChanged(object sender, EventArgs e)
        {
            if (InputCode.TextLength == 8)
                EventNavRegisterRequest.Enabled = true;
            else
                EventNavRegisterRequest.Enabled = false;
        }

        private void InputTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changes.title = true;
        }

        private void InputFirstName_TextChanged(object sender, EventArgs e)
        {
            Changes.firstName = true;
        }

        private void InputLastName_TextChanged(object sender, EventArgs e)
        {
            Changes.lastName = true;
        }

        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            Changes.dateOfBirth = true;
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e)
        {
            Changes.emailAddress = true;
        }

        private void InputTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            Changes.telephoneNumber = true;
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        {
            Changes.postcode = true;
        }

        private void InputUsername_TextChanged(object sender, EventArgs e)
        {
            Changes.username = true;
        }

        private void InputPassword_TextChanged(object sender, EventArgs e)
        {
            Changes.password = true;
        }

        private void InputConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Changes.confirmPassword = true;
        }
    }
}
