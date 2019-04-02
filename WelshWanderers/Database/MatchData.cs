namespace WelshWanderers.Database
{
    class MatchData
    {   //Local data stored for the Matches's data - this will be the data for a match that is being transferred between two forms
        public static int id = -1;
        public static string league = "";
        public static string opponent = "";
        public static string team = "";
        public static string date = "";
        public static int timeH = -1;
        public static int timeM = -1;
        public static string addressLineA = "";
        public static string addressLineB = "";
        public static string postcode = "";

        public void ClearMatchData()
        {   //resets the variables to the original data
            id = -1;
            league = "";
            opponent = "";
            team = "";
            date = "";
            timeH = -1;
            timeM = -1;
            addressLineA = "";
            addressLineB = "";
            postcode = "";
        }
    }
}
