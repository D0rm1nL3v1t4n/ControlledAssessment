namespace WelshWanderers.Database
{
    class UserData
    {   //Local data stored for the User's data - this will be the data for the user that is currently signed in to the system
        public static int id = -1;
        public static string title = "";
        public static string firstName = "";
        public static string lastName = "";
        public static string dateOfBirth = "";
        public static string emailAddress = "";
        public static string telephoneNumber = "";
        public static string postcode = "";
        public static string username = "";
        public static string accessLevel = "";
        public static string team = "";

        public void ClearUserData()
        {   //resets the variables to the original data
            id = -1;
            title = "";
            firstName = "";
            lastName = "";
            dateOfBirth = "";
            emailAddress = "";
            postcode = "";
            username = "";
            accessLevel = "";
            team = "";
        }
    }
}
