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
        private static bool emailDifferent = false;

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToSignIn();
        }

        private void NavToSignIn()
        {
            new SignIn().Show();
            Hide();
        }

        private void EventNavRegisterRequest_Click(object sender, EventArgs e)
        {
            if (emailDifferent != true)
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
                MessageBox.Show("You have changed the email that you have confirmed with the code. Please resend the code to this new email before continuing to confirm this, new email.");
        }

        private void WriteRequestData()
        {
            Functions.FileWrite.WriteData("userJoinRequests", "0" + "|" + InputTitle.Text + "|" + InputFirstName.Text + "|" + InputLastName.Text + "|" + InputDateOfBirth.Text
                 + "|" + InputEmailAddress.Text + "|" + InputTelephoneNumber.Text + "|" + InputPostcode.Text + "|" + InputUsername.Text + "|" + Functions.HashAlgorithm.HashPassword(InputPassword.Text) + "|" + InputTeam.Text + "|");
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
            bool allValid = Functions.Validation.IsTitleValid(InputTitle.Text) && Functions.Validation.IsFirstNameValid(InputFirstName.Text) && Functions.Validation.IsLastNameValid(InputLastName.Text)
                && Functions.Validation.IsDOBValid(InputDateOfBirth.Value) && Functions.Validation.IsEmailAddressValid(InputEmailAddress.Text) && Functions.Validation.IsTelephoneNumberValid(InputTelephoneNumber.Text)
                && Functions.Validation.IsPostcodeValid(InputPostcode.Text) && Functions.Validation.IsUsernameValid(InputUsername.Text) && Functions.Validation.IsPasswordValid(InputPassword.Text, InputConfirmPassword.Text);
            if (allValid)
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
            emailDifferent = false;
            generatedCode = Functions.RandomCode.GenerateCode(8);
            string[] email = { InputEmailAddress.Text };
            string body = "You have been sent the following code:\n\n" + generatedCode + "\n\nEnter this code into the system to confirm your email address.\n\n\nWelshWanderers";
            Functions.SendEmail.Email("Email Confirmation", body, email);
        }

        private void EventResend_Click(object sender, EventArgs e)
        {
            SendCodeEmail();
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e)
        {
            emailDifferent = true;
        }

    }
}
