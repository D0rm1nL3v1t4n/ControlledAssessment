using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace VisualCSharp.Forms
{
    public partial class ResetPasswordForm : Form
    {
        public class Globals
        {
            public static string generatedCode = "";
            public static string userID = "";
        }
        
        
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void grpbxResetPassword_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEnterUsername_Click(object sender, EventArgs e)
        {
            bool foundUsername = false;
                        
            StreamReader userAccountDetails = new StreamReader("userAccountDetails.txt");
            string accountDetailsLine = userAccountDetails.ReadLine();
            while (null != accountDetailsLine && foundUsername == false)
            {
                if ("" != accountDetailsLine)
                {
                    foundUsername = CheckUsername(accountDetailsLine);
                    Globals.userID = GetUserID(accountDetailsLine);
                }
                accountDetailsLine = userAccountDetails.ReadLine();
            }
            userAccountDetails.Close();


            if (foundUsername == true)
            {
                //Can this be a subroutine?
                StreamReader userPersonalDetails = new StreamReader("userPersonalDetails.txt");
                string personalDetailsLine = userPersonalDetails.ReadLine();
                string userEmailAddress = "";

                while (null != personalDetailsLine && userEmailAddress == "")
                {
                    if ("" != personalDetailsLine)
                    {
                        userEmailAddress = GetEmailAddress(Globals.userID, personalDetailsLine);
                    }
                    personalDetailsLine = userPersonalDetails.ReadLine();
                }
                //Up to here.
                ShowEmailAddress(userEmailAddress);


                GenerateRandomCode();
                SendEmail(userEmailAddress);
                
            }          
            
            else
            {
                MessageBox.Show("ERROR: Username not found.");
            }

        
        }

        private void GenerateRandomCode()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharacters = new char[6];
            var random = new Random();
            for (int i = 0; i < 6; i++)
            {
                stringCharacters[i] = characters[random.Next(characters.Length)];
            }
            Globals.generatedCode = new String(stringCharacters);
        }


        private void SendEmail(string userEmailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("WelshWanderersTest@gmail.com");
                mail.To.Add(userEmailAddress);
                mail.Subject = "Resetting Your Password";
                mail.Body = "Your 6 digit code to change your password:\n\n\n" + Globals.generatedCode + "\n\nWelsh Wanderers water polo club.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("WelshWanderersTest@gmail.com", "TestPassword1!");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email Sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckUsername(string line)
        {
            string[] section = line.Split('|');
            bool success = false;
            if (TxtUsernameSearch.Text.ToLower() == section[1].ToLower())
            {
                success = true;
            }

            return success;
        }

        private string GetUserID(string line)
        {
            string[] section = line.Split('|');
            return section[0];
        }

        private string GetEmailAddress(string userID, string line)
        {
            string[] section = line.Split('|');
            string emailAddress = "";

            if (userID == section[0])
                emailAddress = section[5];

            return emailAddress;
        }

        private void ShowEmailAddress(string emailAddress)
        {
            lblEmailAddressShow.Text = emailAddress;
        }









        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            bool isValidCode = CheckValidCode();
            bool isValidPassword = CheckValidPassword();
            bool isValidConfirm = CheckValidConfirmPassword();

            if (isValidCode == true && isValidPassword == true && isValidConfirm == true)
            {
                int noOfLines = File.ReadLines("userAccountDetails.txt").Count();

                string[,] localFile = new string[noOfLines, 4];
                int lineNo = 0;

                StreamReader userAccountDetailsFile = new StreamReader("userAccountDetails.txt");
                string individualLine = userAccountDetailsFile.ReadLine();
                while (null != individualLine)
                {
                    string[] section = individualLine.Split('|');

                    localFile[lineNo, 0] = section[0];
                    localFile[lineNo, 1] = section[1];

                    if (section[0] == Globals.userID)
                    {
                        localFile[lineNo, 2] = txtNewPassword.Text;
                    }
                    else
                    {
                        localFile[lineNo, 2] = section[2];
                    }

                    localFile[lineNo, 3] = section[3];
                    lineNo++;
                    individualLine = userAccountDetailsFile.ReadLine();
                }
                userAccountDetailsFile.Close();

                string[] tempLine = new string[4];
                int i = 0;

                File.WriteAllText("userAccountDetails.txt", String.Empty);

                using (System.IO.StreamWriter accountDetailsFile =
                new System.IO.StreamWriter("userAccountDetails.txt"))
                {
                    foreach (string line in localFile)
                    {
                        tempLine[i] = line;
                        i++;
                        if (i % 4 == 0)
                        {
                            i = 0;
                            accountDetailsFile.WriteLine(tempLine[0] + "|" + tempLine[1] + "|" + tempLine[2] + "|" + tempLine[3] + "|");
                        }
                        
                    }
                }

                MessageBox.Show("Your password has been changed!");
                ReturnToSignIn();
            }
        }



        private bool CheckID(string line)
        {
            string[] section = line.Split('|');
            bool success = false;
            
            if (Globals.userID == section[0])
            {
                success = true;
            }

            return success;
        }



        private bool CheckValidCode()
        {
            bool isValid = false;

            if (Globals.generatedCode == TxtSixDigitCode.Text)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Code entered is incorrect");
            }

            return isValid;
        }

        private bool CheckValidPassword()
        {
            //Copy password validation over

            bool isValid = true;    //CHANGE TO FALSE

            //if ()
            //{
            //   isValid = true;
            //}
            //else
            //{
            //  MessageBox.Show("ERROR: Password must contain at least one of the following:\nupercase character, lowercase character, a number and a symbol.");
            //}

            return isValid;

        }

        private bool CheckValidConfirmPassword()
        {
            bool isValid = false;

            if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("ERROR: Passwords do not match.");
            }
            return isValid;
        }

        private void BtnCancelResetPassword_Click(object sender, EventArgs e)
        {
            ReturnToSignIn();
        }

        private void ReturnToSignIn()
        {
            new signInForm().Show();
            this.Hide();
        }
    }
}
