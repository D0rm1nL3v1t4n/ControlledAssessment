using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshWanderers.Database
{
    class TrainingData
    {
        public static int id = -1;
        public static string team = "";
        public static int timeHour = -1;
        public static int timeMin = -1;
        public static int duration = -1;
        public static string date = "";

        public void ClearTrainingData()
        {
            id = -1;
            team = "";
            timeHour = -1;
            timeMin = -1;
            duration = -1;
            date = "";
        }
    }
}
