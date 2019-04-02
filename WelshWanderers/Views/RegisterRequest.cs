using System;
using System.Windows.Forms;

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

        //sets variables to check if changes have been made to the inputs the user can make as boolean values all set as false by default
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

            public static void ResetChanges()   //function to reset the boolean values for the changes made back to all false
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
            NavToSignIn();  //Navigation to Sign Inform
        }

        private void NavToSignIn()
        {
            new SignIn().Show();    //shows Sign In form
            Close();    //closes this form
        }

        private void EventNavRegisterRequest_Click(object sender, EventArgs e)
        {
            if (emailConfirmedWith == InputEmailAddress.Text)   //checks if the email address the user confirmed with is the same as that in the text box
            {
                if (CheckValidation())  //checks if the data entered by the user is valid
                {
                    if (generatedCode == InputCode.Text)    //checks if the code entered by the user is correct
                    {   
                        WriteRequestData(); //calls on function to write the registration request data
                        EmailRegistrationRequest(); //emails the user to confirm their registration request
                        MessageBox.Show("Your registration request has been made.");    
                        NavToSignIn();  //navigation to Sign In form
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
            bool title = CheckTitle();  //validation for Title
            bool firstName = CheckFirstName();  //validation for First Name
            bool lastName = CheckLastName();    //validation for Last Name
            bool dob = CheckDOB();  //validation for Date of Birth
            bool emailAddress = CheckEmailAddress();    //validation for Email Address
            bool telephoneNumber = CheckTelephoneNumber();  //validation for Telephone number
            bool postcode = CheckPostcode();    //validation for Postcode
            bool username = CheckUsername();    //validation for Username
            bool password = CheckPassword();    //validation for Password
            return title && firstName && lastName && dob && emailAddress && telephoneNumber && postcode && username && password;
        }

        private bool CheckTitle()
        {
            if (Changes.title)  //checks if validation needs to be checked again
                return Functions.Validation.IsTitleValid(InputTitle.Text);  //calls on function for validation for Title
            return true;    //returns true if changes not made
        }

        private bool CheckFirstName()
        {
            if (Changes.firstName)  //check if validation needs to be checked again
                return Functions.Validation.IsFirstNameValid(InputFirstName.Text);  //calls on function for validation for First Name
            return true;    //returns true if changes not made
        }

        private bool CheckLastName()
        {
            if (Changes.lastName)   //check if validation needs to be checked again
                return Functions.Validation.IsLastNameValid(InputLastName.Text);    //calls on function for validation for Last Name
            return true;    //returns true if changes not made
        }

        private bool CheckDOB()
        {
            if (Changes.dateOfBirth)    //check if validation needs to be checked again
                return Functions.Validation.IsDOBValid(InputDateOfBirth.Value); //calls on function for validation for Date of Birth
            return true;    //returns true if changes not made
        }

        private bool CheckEmailAddress()
        {
            if (Changes.emailAddress)   //check if validation needs to be checked again
                return Functions.Validation.IsEmailAddressValid(InputEmailAddress.Text);    //calls on function for validation for Email Address
            return true;    //returns true if changes not made
        }

        private bool CheckTelephoneNumber()
        {
            if (Changes.telephoneNumber)    //check if validation needs to be checked again
                return Functions.Validation.IsTelephoneNumberValid(InputTelephoneNumber.Text);  //calls on function for validation for Telephone Number
            return true;    //returns true if changes not made
        }

        private bool CheckPostcode()
        {   
            if (Changes.postcode)   //check if validation needs to be checked again
                return Functions.Validation.IsPostcodeValid(InputPostcode.Text);    //calls on function for validation for Postcode
            return true;    //returns true if changes not made
        }

        private bool CheckUsername()
        {
            if (Changes.username)   //check if validation needs to be checked again
                return Functions.Validation.IsUsernameValid(InputUsername.Text);    //calls on function for validation for Username
            return true;    //returns true if changes not made
        }

        private bool CheckPassword()
        {
            if (Changes.password || Changes.confirmPassword)    //check if validation needs to be checked again
                return Functions.Validation.IsPasswordValid(InputPassword.Text, InputConfirmPassword.Text); //calls on function for validation for Password
            return true;    //returns true if changes not made
        }

        private void WriteRequestData()
        {   //Writes data to file for the record for this user's registration request
            Functions.FileWrite.WriteData("userJoinRequests", "0" + "|" + InputTitle.Text + "|" + InputFirstName.Text + "|" + InputLastName.Text + "|" + InputDateOfBirth.Text
                 + "|" + InputEmailAddress.Text + "|" + InputTelephoneNumber.Text + "|" + InputPostcode.Text + "|" + InputUsername.Text.ToLower() + "|" + Functions.HashAlgorithm.HashPassword(InputPassword.Text) + "|" + InputTeam.Text + "|");
        }


        private void EventShowHelp_Click(object sender, EventArgs e)
        {   //Message box to display information to the user
            MessageBox.Show("Registration Request: After making a request, a club admin must accept your request to grant you access to the system.\n"
                + "Before you can make your registration, you must confirm your email address. You will recieve an 8 digit code to the email you have given.\n"
                + "You will be notified by email about your request, and any further updates regarding your request.");
        }

        private void EmailRegistrationRequest()
        {
            string body = "This is an email to confirm your registration request (username: " + InputUsername.Text + ") to the Welsh Wanderers system.\n\nYour request must be accepted for you to be able to use the system.\nYou will get a confirmation email regarding your request once it has been processed.\n\n\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request", body, recipient); //sends email to confirm registration request of the user
        }

        private void EventSendCode_Click(object sender, EventArgs e)
        {
            if (CheckValidation())  //calls on function to check if inputs are valid
            {
                SendCodeEmail();    //calls on function to send a random confirmation code to the user
                ChangeControls();   //calls on function to show and hide different controls
            }   
        }

        private void ChangeControls()
        {
            EventNavRegisterRequest.Enabled = true; //enables the Register Request button
            EventSendCode.Hide();   //Hides the send code button
            //shows these controls
            LabelCode.Show();   
            InputCode.Show();
            EventResend.Show();
        }

        private void SendCodeEmail()
        {
            Changes.ResetChanges();     //resets the changes made by the user
            emailConfirmedWith = InputEmailAddress.Text;
            generatedCode = Functions.RandomCode.GenerateCode(8);   //calls on function to generate a random code of 8 characters long
            string[] email = { InputEmailAddress.Text };
            string body = "You have been sent the following code:\n\n" + generatedCode + "\n\nEnter this code into the system to confirm your email address.\n\n\nWelshWanderers";
            Functions.SendEmail.Email("Email Confirmation", body, email);   //sends the email containing the random code
        }

        private void EventResend_Click(object sender, EventArgs e)
        {
            SendCodeEmail();    //calls on function to send the email with the confirmation code
        }

        private void InputCode_TextChanged(object sender, EventArgs e)
        {
            if (InputCode.TextLength == 8)  //checks if the length of code entered is of the correct value
                EventNavRegisterRequest.Enabled = true;     //allows the user to click the Register Reequest button
            else
                EventNavRegisterRequest.Enabled = false;    //prevents the user from being able to click the Register Request button
        }

        private void InputTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changes.title = true;   //sets the value to true ==> this has been changed since last validation check
        }

        private void InputFirstName_TextChanged(object sender, EventArgs e)
        {
            Changes.firstName = true;   //sets the value to true ==> this has been changed since last validation check
        }

        private void InputLastName_TextChanged(object sender, EventArgs e)
        {
            Changes.lastName = true;    //sets the value to true ==> this has been changed since last validation check
        }

        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            Changes.dateOfBirth = true; //sets the value to true ==> this has been changed since last validation check
        }

        private void InputEmailAddress_TextChanged(object sender, EventArgs e)
        {
            Changes.emailAddress = true;    //sets the value to true ==> this has been changed since last validation check
        }

        private void InputTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            Changes.telephoneNumber = true; //sets the value to true ==> this has been changed since last validation check
        }

        private void InputPostcode_TextChanged(object sender, EventArgs e)
        {
            Changes.postcode = true;    //sets the value to true ==> this has been changed since last validation check
        }

        private void InputUsername_TextChanged(object sender, EventArgs e)
        {
            Changes.username = true;    //sets the value to true ==> this has been changed since last validation check
        }

        private void InputPassword_TextChanged(object sender, EventArgs e)
        {
            Changes.password = true;    //sets the value to true ==> this has been changed since last validation check
        }

        private void InputConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Changes.confirmPassword = true; //sets the value to true ==> this has been changed since last validation check
        }
    }
}
