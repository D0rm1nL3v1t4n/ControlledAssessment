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
        public static int timeH = -1;
        public static int timeM = -1;
        public static string addressLineA = "";
        public static string addressLineB = "";
        public static string postcode = "";

        public void ClearMatchData()
        {
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
