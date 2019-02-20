using System;

namespace Testing
{
    class Validation
    {
        public static void TestValidation()
        {
            Title();
            FirstName();
            LastName();
            DateOfBirth();
            EmailAddress();
            TelephoneNumber();
            Postcode();
            Username();
            Password();
        }

        private static void Title()
        {
            bool tests = WelshWanderers.Functions.Validation.IsTitleValid(null) == false && WelshWanderers.Functions.Validation.IsTitleValid("Mr") == true && WelshWanderers.Functions.Validation.IsTitleValid("Miss") == true;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Title");
        }

        private static void FirstName()
        {
            bool tests = WelshWanderers.Functions.Validation.IsFirstNameValid("") == false && WelshWanderers.Functions.Validation.IsFirstNameValid("Bobby|") == false
                && WelshWanderers.Functions.Validation.IsFirstNameValid("qwertyuioplkmjnbhgvcf") == false && WelshWanderers.Functions.Validation.IsFirstNameValid("abc672") == false
                && WelshWanderers.Functions.Validation.IsFirstNameValid("John;)") == false && WelshWanderers.Functions.Validation.IsFirstNameValid("Joé") == true
                && WelshWanderers.Functions.Validation.IsFirstNameValid("Jo") == true && WelshWanderers.Functions.Validation.IsFirstNameValid("qwertyuioplkjhgfdsaz") == true;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - First name");
        }

        private static void LastName()
        {
            bool tests = WelshWanderers.Functions.Validation.IsLastNameValid("") == false && WelshWanderers.Functions.Validation.IsLastNameValid("|Howard|") == false
                && WelshWanderers.Functions.Validation.IsLastNameValid("qwertyuioplkmjnbhgvcf") == false && WelshWanderers.Functions.Validation.IsLastNameValid("9284") == false
                && WelshWanderers.Functions.Validation.IsLastNameValid("Evans)") == false && WelshWanderers.Functions.Validation.IsLastNameValid("Olé") == true
                && WelshWanderers.Functions.Validation.IsLastNameValid("Job") == true && WelshWanderers.Functions.Validation.IsLastNameValid("qwertyuioplkjhgfdsaz") == true;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Last name");
        }

        private static void DateOfBirth()
        {
            bool tests = WelshWanderers.Functions.Validation.IsDOBValid(DateTime.Now.AddYears(-5).AddDays(1)) == false && WelshWanderers.Functions.Validation.IsDOBValid(DateTime.Now.AddYears(100)) == false
                && WelshWanderers.Functions.Validation.IsDOBValid(DateTime.Now.AddYears(-5)) == true && WelshWanderers.Functions.Validation.IsDOBValid(DateTime.Now.AddYears(-40)) == true;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Date of birth");
        }

        private static void EmailAddress()
        {
            bool tests = WelshWanderers.Functions.Validation.IsEmailAddressValid("12nabramovich@stanwell.org") == true && WelshWanderers.Functions.Validation.IsEmailAddressValid("nimrodabramovich2001@gmail.com") == true
                && WelshWanderers.Functions.Validation.IsEmailAddressValid("^&%$@gmail.com") == false && WelshWanderers.Functions.Validation.IsEmailAddressValid("JoeThomas.com") == false
                && WelshWanderers.Functions.Validation.IsEmailAddressValid("William|Evans05") == false;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Email address");
        }

        private static void TelephoneNumber()
        {
            bool tests = WelshWanderers.Functions.Validation.IsTelephoneNumberValid("07538504384") == true && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("0753-850-4384") == true
                && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("0753 850 4384") == true && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("abc def ghij") == false
                && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("!£$ %^& */'") == false && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("") == false
                && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("123456") == false && WelshWanderers.Functions.Validation.IsTelephoneNumberValid("0123456789123456") == false;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Telephone number");
        }

        private static void Postcode()
        {
            bool tests = WelshWanderers.Functions.Validation.IsPostcodeValid("CF64 2XL") == true && WelshWanderers.Functions.Validation.IsPostcodeValid("CF15 1BC") == true
                && WelshWanderers.Functions.Validation.IsPostcodeValid("W2 1JB") == true && WelshWanderers.Functions.Validation.IsPostcodeValid("SW1A 1AA") == true
                && WelshWanderers.Functions.Validation.IsPostcodeValid("DE12 8HJ") == true && WelshWanderers.Functions.Validation.IsPostcodeValid("ABCD EFG") == false
                && WelshWanderers.Functions.Validation.IsPostcodeValid("1234 567") == false && WelshWanderers.Functions.Validation.IsPostcodeValid("^&(* !£$") == false
                && WelshWanderers.Functions.Validation.IsPostcodeValid("CF642 9PEN") == false && WelshWanderers.Functions.Validation.IsPostcodeValid("") == false;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Postcode");
        }

        private static void Username()
        {
            bool tests = WelshWanderers.Functions.Validation.IsUsernameValid("testuser1") == true && WelshWanderers.Functions.Validation.IsUsernameValid("Anthony Rocks") == true
                && WelshWanderers.Functions.Validation.IsUsernameValid("Abcdef") == true && WelshWanderers.Functions.Validation.IsUsernameValid("qwertyuiop1234567890") == true
                && WelshWanderers.Functions.Validation.IsUsernameValid("John$Davis!") == false && WelshWanderers.Functions.Validation.IsUsernameValid("Joe|Thomas") == false
                && WelshWanderers.Functions.Validation.IsUsernameValid("User1") == false && WelshWanderers.Functions.Validation.IsUsernameValid("qazwsxedcrfvtgbyhnujm") == false;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Username");
        }

        private static void Password()
        {
            bool tests = WelshWanderers.Functions.Validation.IsPasswordValid("Abcdef8*", "Abcdef8*") == true && WelshWanderers.Functions.Validation.IsPasswordValid("PklhfYyhBuanisj729&^", "PklhfYyhBuanisj729&^") == true
                && WelshWanderers.Functions.Validation.IsPasswordValid("Password1!", "Password1!") == true && WelshWanderers.Functions.Validation.IsPasswordValid("Password1234|", "Password1234|") == false
                && WelshWanderers.Functions.Validation.IsPasswordValid("1234567890", "1234567890") == false && WelshWanderers.Functions.Validation.IsPasswordValid("qwerty", "qwerty") == false
                && WelshWanderers.Functions.Validation.IsPasswordValid("1 like writing passwords", "1 like writing passwords") == false && WelshWanderers.Functions.Validation.IsPasswordValid("Password1!", "Password123!") == false;
            if (tests)
                TestResult.TestPass();
            else
                TestResult.TestFail("Validation - Password");
        }
    }
}
