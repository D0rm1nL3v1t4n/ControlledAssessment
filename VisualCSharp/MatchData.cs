using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharp
{
    class MatchData
    {
        public static string matchID = "";
        public static string matchType = "";
        public static string opponent = "";
        public static string teamType = "";
        public static string dateAndTime = "";
        public static string addressLine1 = "";
        public static string addressLine2 = "";
        public static string postcode = "";

        public void ClearMatchData()
        {
            matchID = "";
            matchType = "";
            opponent = "";
            teamType = "";
            dateAndTime = "";
            addressLine1 = "";
            addressLine2 = "";
            postcode = "";
        }
    
    }

    
}
