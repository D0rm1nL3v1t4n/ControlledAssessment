using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    public class Validation
    {
        public static bool IsTitleValid(string title)
        {
            if ("" != title)
                return true;
            MessageBox.Show("You must select a title.");
            return false;
        }

        public static bool IsFirstNameValid(string firstName)
        {
            if (firstName.Length > 1 && firstName.Length < 21 && !firstName.Contains('|') && firstName.All(Char.IsLetter))
                return true;
            MessageBox.Show("First name must be between 2 and 20 letters");
            return false;
        }

        public static bool IsLastNameValid(string lastName)
        {
            if (lastName.Length > 2 && lastName.Length < 21 && !lastName.Contains('|')) // && lastName.All(Char.IsLetter)
                return true;
            MessageBox.Show("Last name must be between 3 and 20 letters");
            return false;
        }

        public static bool IsDOBValid(DateTime dateOfBirth)
        {
            if (dateOfBirth <= DateTime.Now.AddYears(-5))
                return true;
            MessageBox.Show("Date of birth must be before the following date (5 years back): " + DateTime.Now.AddYears(-5).Date.ToShortDateString() + ".");
            return false;
        }

        public static bool IsEmailAddressValid(string emailAddress)
        {
            Match compare = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Match(emailAddress);
            if (compare.Success && !emailAddress.Contains('|'))
                return true;
            MessageBox.Show("Email address must of a valid format");
            return false;
        }

        public static bool IsTelephoneNumberValid(string telephoneNumber)
        {
            Match compare = new Regex(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})").Match(telephoneNumber);
            if (compare.Success)
                return true;
            MessageBox.Show("Telephone number must be of a valid format");
            return false;
        }

        public static bool IsPostcodeValid(string postcode)
        {
            Match compare = new Regex(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})").Match(postcode);
            if (compare.Success)
                return true;
            MessageBox.Show("Postcode must be of a valid format.");
            return false;
        }

        public static bool IsUsernameValid(string username)
        {
            if (username.Length > 5 && username.Length < 21 && !username.Contains('|') && username.All(Char.IsLetterOrDigit))
            {
                return UsernameNotDuplicate(username);
            }
            MessageBox.Show("Username must be between 6 and 20 letters or digits.");
            return false;
        }

        private static bool UsernameNotDuplicate(string username)
        {
            if (Functions.FileSearch.ReturnSegment("userAccountDetails", username.ToLower(), 1, 0) == null && Functions.FileSearch.ReturnSegment("userJoinRequests", username.ToLower(), 8, 0) == null)
                return true;
            MessageBox.Show("That username is already taken by another user.\nPlease enter a different username to use.");
            return false;
        }

        public static bool IsPasswordValid(string password, string confirmPassword)
        {
            Match compare = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$").Match(password);
            if (password == confirmPassword)
            {
                if (compare.Success && !password.Contains("|"))
                    return true;
                else
                {
                    MessageBox.Show("Password must be between 8 and 20 characters in length and " +
                    "contain at least one of each of the following:\nAn uppercase, lowercase, numerical & special character.");
                }
            }
            else
                MessageBox.Show("Your passwords do not match.");
            return false;
        }
    }
}
