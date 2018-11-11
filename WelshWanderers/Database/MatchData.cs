using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshWanderers.Database
{
    class MatchData
    {
        public static int id = -1;
        public static string league = "";
        public static string opponent = "";
        public static string team = "";
        public static string date = "";
        public static int timeHour = -1;
        public static int timeMin = -1;
        public static string addressLine1 = "";
        public static string addressLine2 = "";
        public static string postcode = "";

        public void ClearMatchData()
        {
            id = -1;
            league = "";
            opponent = "";
            team = "";
            date = "";
            timeHour = -1;
            timeMin = -1;
            addressLine1 = "";
            addressLine2 = "";
            postcode = "";
        }
    }
}
