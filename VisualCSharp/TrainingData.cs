namespace VisualCSharp
{
    class TrainingData
    {
        public static string trainingID = "";
        public static string trainingType = "";
        public static string startTimeHour = "";
        public static string startTimeMin = "";
        public static string finishTimeHour = "";
        public static string finishTimeMin = "";
        public static string date = "";

        public void ClearTrainingData()
        {
            trainingID = "";
            trainingType = "";
            startTimeHour = "";
            startTimeMin = "";
            finishTimeHour = "";
            finishTimeMin = "";
            date = "";
        }
    }
}
