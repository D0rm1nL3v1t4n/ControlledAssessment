using System.Windows.Forms;

namespace Testing
{
    public class SendEmail
    {
        public static void TestSendEmail()
        {
            string[] emails = { "12nabramovich@stanwell.org", "nimrodabramovich2001@gmail.com" };
            WelshWanderers.Functions.SendEmail.Email("This is the subject", "This is the body.\n\nThe body is multiline.", emails);
            if (MessageBox.Show("Email has been sent. Check your inbox. \n\nHave you recieved both emails?", "Email Testing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                TestResult.TestPass();
            else
                TestResult.TestFail("Send email");
        }
    }
}
