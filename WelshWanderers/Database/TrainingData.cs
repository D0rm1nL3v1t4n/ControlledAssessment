namespace WelshWanderers.Database
{
    class TrainingData
    {   //Local data stored for the Training's data - this will be the data for a training that is being transferred between two forms
        public static int id = -1;
        public static string team = "";
        public static int timeH = -1;
        public static int timeM = -1;
        public static int duration = -1;
        public static string date = "";

        public void ClearTrainingData()
        {   //resets the variables to the original data
            id = -1;
            team = "";
            timeH = -1;
            timeM = -1;
            duration = -1;
            date = "";
        }
    }
}
