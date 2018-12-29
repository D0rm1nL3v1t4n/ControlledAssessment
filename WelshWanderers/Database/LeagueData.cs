using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshWanderers.Database
{
    class LeagueData
    {
        public static int id = -1;
        public static string name = "";
        public static string fileName = "";
        public static string team = "";

        public void ClearLeagueData()
        {
            id = -1;
            name = "";
            fileName = "";
            team = "";
        }
    }
}
