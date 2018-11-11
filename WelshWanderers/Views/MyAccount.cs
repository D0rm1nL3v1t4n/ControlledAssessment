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

        public static int changesMade = 0;
        public static bool title = false;
        public static bool firstName = false;
        public static bool lastName = false;
        public static bool dateOfBirth = false;
        public static bool emailAddress = false;
        public static bool telephoneNumber = false;
        public static bool postcode = false;

        private void MyAccount_Load(object sender, EventArgs e) => ShowDetails();

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
            if (changesMade == 0)
            {
                if (MessageBox.Show("You have not made any changes, do you want to return to the home screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToHome();
                }
            }
            else if (changesMade > 0)
            {
                if (MessageBox.Show("You have made " + changesMade.ToString() + ", confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChangeDetails();
                }
            }
        }

        private void ChangeDetails()
        {
            string[] newData = { InputTitle.Text, InputFirstName.Text, InputLastName.Text, InputDateOfBirth.Text, InputEmailAddress.Text, InputTelephoneNumber.Text, InputPostcode.Text };
            Functions.FileEdit.EditLine("userPersonalDetails", 8, newData, 0, Database.UserData.id.ToString());
            UpdateDetails();
            MessageBox.Show("Your details have been updated.");
            NavToHome();
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

        private void ShowChangesMade() => LabelChangesMade.Text = changesMade + " change(s)\nmade.";

        private void NavHome_Click(object sender, EventArgs e) => NavToHome();

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++changesMade;
                ShowChangesMade();
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --changesMade;
                ShowChangesMade();
                return false;
            }

            if (changedVal == true)
                return true;
            else
                return false;

        }

        private void InputTitle_SelectedIndexChanged(object sender, EventArgs e) => title = DetailsChanged(InputTitle.Text, Database.UserData.title, title);

        private void InputFirstName_TextChanged(object sender, EventArgs e) => firstName = DetailsChanged(InputFirstName.Text, Database.UserData.firstName, firstName);

        private void InputLastName_TextChanged(object sender, EventArgs e) => lastName = DetailsChanged(InputLastName.Text, Database.UserData.lastName, lastName);

        private void InputDateOfBirth_ValueChanged(object sender, EventArgs e) => dateOfBirth = DetailsChanged(InputDateOfBirth.Text, Database.UserData.dateOfBirth, dateOfBirth);

        private void InputEmailAddress_TextChanged(object sender, EventArgs e) => emailAddress = DetailsChanged(InputEmailAddress.Text, Database.UserData.emailAddress, emailAddress);

        private void InputTelephoneNumber_TextChanged(object sender, EventArgs e) => telephoneNumber = DetailsChanged(InputTelephoneNumber.Text, Database.UserData.telephoneNumber, telephoneNumber);

        private void InputPostcode_TextChanged(object sender, EventArgs e) => postcode = DetailsChanged(InputPostcode.Text, Database.UserData.postcode, postcode);
    }
}
