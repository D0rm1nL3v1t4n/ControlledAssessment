using System;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class DeleteUserConfirm : Form
    {
        public static string userID;
        public DeleteUserConfirm(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void DeleteUserConfirm_Load(object sender, EventArgs e)
        {
            LoadDataToDelete(); //calls on function to load the users data
        }

        private void LoadDataToDelete()
        {
            string[] data = GetData();  //calls on function to get all the user's data
            ShowData(data); //calls on function to show the user's data
        }

        private string[] GetData()
        {
            string dataLine = "";
            dataLine += Functions.FileSearch.ReturnLine("userPersonalDetails", userID, 0);  //gets the user's data from the userPersonalDetails file
            dataLine += Functions.FileSearch.ReturnLine("userAccountDetails", userID, 0);   //gets the user's data from the userAccountDetails file
            string[] data = dataLine.Split('|');
            return data;
        }

        private void ShowData(string[] data)
        {
            //shows the user's data in the text boxes
            InputId.Text = data[0];
            InputTitle.Text = data[1];
            InputFirstName.Text = data[2];
            InputLastName.Text = data[3];
            InputDateOfBirth.Text = data[4];
            InputEmailAddress.Text = data[5];
            InputTelephoneNumber.Text = data[6];
            InputPostcode.Text = data[7];
            InputUsername.Text = data[9];
            InputAccessLevel.Text = data[11];
            InputTeam.Text = data[12];
        }

        private void EventNavDeleteUser_Click(object sender, EventArgs e)
        {
            if (ValidInputs())  //checks the admin's inputs are valid
            {
                AlertUser();    //calls on a function to alert the user of their account being deleted
                DeleteUserData();   //delete's the user's data
            }
        }

        private void AlertUser()
        {
            string[] email = { InputEmailAddress.Text };    //sets the email address to be sent to
            string team = "";
            if (InputTeam.Text != null)
                team = ", " + InputTeam.Text;
            //sets the body for the email
            string body = "The following account has been removed from the Welsh Wanderers Waterpolo club system:\n- " + InputFirstName.Text + " " + InputLastName.Text + "\n- " + InputUsername.Text + "\n- " + InputAccessLevel.Text + team + "\n\nFor the following reason:\n" + InputReason.Text + "\n\nWelsh Wanderers.";
            Functions.SendEmail.Email("Account removed from system.", body, email); //sends an email using the Send Email function
        }

        private void DeleteUserData()
        {
            int lineNo = Functions.FileSearch.LineNumber("userAccountDetails", InputId.Text, 0);
            Functions.FileDelete.RemoveLine("userAccountDetails", 5, lineNo);   //removes the user's data from the userAccountDetails file
            Functions.FileDelete.RemoveLine("userPersonalDetails", 8, lineNo);  //removes the user's data from the userPersonalDetails file
        }

        private bool ValidInputs()
        {
            if (ValidReason() == true && ValidName() == true && ValidPassword() == true)
                return true;    //returns true if the validation passes
            return false;   //returns false if the validation fails
        }

        private bool ValidReason()
        {
            if (InputReason.Text != "") //presence check
                return true;    //returns true if validation passes
            MessageBox.Show("Enter a reason for user being deleted from the system.");
            return false;   //returns false if validation fails
        }

        private bool ValidName()
        {
            if (InputName.Text == (InputFirstName.Text.ToLower() + " " + InputLastName.Text.ToLower())) //value check - checks the name of the user to be deleted entered is correct
                return true;    //returns true if validation passes
            MessageBox.Show("Name entered does not match the name of the user.");
            return false;   //returns false if validation fails
        }
        
        private bool ValidPassword()
        {
            //checks the password entered by the admin is correct through the Check Hashes algorithm
            if (Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 2, false), InputPassword.Text) == true)
                return true;    //returns true if validation passes
            MessageBox.Show("Password entered is incorrect.");
            return false;   //returns true if validation fails
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            Close();    //closes this form
        }
    }
}
