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
                 + "|" + InputEmailAddress.Text + "|" + InputTelephoneNumber.Text + "|" + InputPostcode.Text + "|" + InputUsername.Text + "|" + InputPassword.Text + "|" + InputTeam.Text + "|");
        }

        private int ValidTitle()
        {
            if (null != InputTitle.Text)
                return 0;
            MessageBox.Show("You must select a title.");
            return 1;
        }

        private int ValidFirstName()
        {
            if (InputFirstName.Text.Length > 0 && InputFirstName.Text.Length < 21 && !InputFirstName.Text.Contains('|'))
                return 0;
            MessageBox.Show("First name must be between 5 and 20 characters.");
            return 1;
        }

        private int ValidLastName()
        {
            if (InputLastName.Text.Length > 0 && InputLastName.Text.Length < 21 && !InputLastName.Text.Contains('|'))
                return 0;
            MessageBox.Show("Last name must be between 5 and 20 characters.");
            return 1;
        }

        private int ValidDateOfBirth()
        {
            if (InputDateOfBirth.Value <= DateTime.Now)
                return 0;
            MessageBox.Show("Hey Doc, pretty sure we ain't time travelling yet - Marty.");
            return 1;
        }

        private int ValidEmailAddress()
        {
            Regex emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match compare = emailRegex.Match(InputEmailAddress.Text);
            if (compare.Success && !InputEmailAddress.Text.Contains('|'))
                return 0;
            MessageBox.Show("Email address must of a valid format");
            return 1;
        }

        private int ValidTelephoneNumber()
        {
            Regex telephoneRegex = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})");
            Match compare = telephoneRegex.Match(InputTelephoneNumber.Text);
            if (compare.Success)
                return 0;
            MessageBox.Show("Telephone number must be of a valid format");
            return 1;
        }

        private int ValidPostcode()
        {
            Regex postcodeRegex = new Regex(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})");
            Match compare = postcodeRegex.Match(InputPostcode.Text);
            if (compare.Success)
                return 0;
            MessageBox.Show("Postcode must be of a valid format.");
            return 1;
        }

        private int ValidUsername()
        {
            if (InputUsername.TextLength > 5 && InputUsername.Text.Length < 21 && !InputUsername.Text.Contains('|'))
                return 0;
            MessageBox.Show("Username must be between 6 and 20 characters.");
            return 1;
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
            int allValid = ValidTitle() + ValidFirstName() + ValidLastName() + ValidDateOfBirth() + ValidEmailAddress() + ValidTelephoneNumber() + ValidPostcode() + ValidUsername();
            if (allValid == 0 && Functions.ValidPassword.IsPasswordValid(InputPassword.Text, InputConfirmPassword.Text) == true)
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
            generatedCode = Functions.RandomCode.GenerateCode(8);
            string[] email = { InputEmailAddress.Text };
            string body = "You have been sent the following code:\n\n" + generatedCode + "\n\nEnter this code into the system to confirm your email address.\n\n\nWelshWanderers";
            Functions.SendEmail.Email("Email Confirmation", body, email);
        }

        private void EventResend_Click(object sender, EventArgs e)
        {
            SendCodeEmail();
            emailDifferent = false;
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e)
        {
            emailDifferent = true;
        }

    }
}
