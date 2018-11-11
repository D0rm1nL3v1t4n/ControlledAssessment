using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    class ValidPassword
    {
        public static bool IsPasswordValid(string password, string confirmPassword)
        {
            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$");
            Match compare = passwordRegex.Match(password);
            if (password == confirmPassword)
            {
                if (compare.Success && !password.Contains("|"))
                    return true;
                else
                    MessageBox.Show("Password must be between 8 and 20 characters in length and " +
                        "contain at least one of each of the following:\nAn uppercase, lowercase, numerical & special character.");
            }
            else
                MessageBox.Show("Your passwords do not match.");
            return false;
        }
    }
}
