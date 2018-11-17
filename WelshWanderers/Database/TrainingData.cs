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
        public static int timeH = -1;
        public static int timeM = -1;
        public static int duration = -1;
        public static string date = "";

        public void ClearTrainingData()
        {
            id = -1;
            team = "";
            timeH = -1;
            timeM = -1;
            duration = -1;
            date = "";
        }
    }
}
