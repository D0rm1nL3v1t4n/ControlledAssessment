namespace WelshWanderers.Database
{
    class LeagueData
    {   //Local data stored for the League's data - this will be the data for a league that is being transferred between two forms
        public static int id = -1;
        public static string name = "";
        public static string team = "";

        public void ClearLeagueData()
        {   //resets the variables to the original data
            id = -1;
            name = "";
            team = "";
        }
    }
}
