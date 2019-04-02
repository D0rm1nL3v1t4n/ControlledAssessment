namespace WelshWanderers.Database
{
    class EmailData
    {   //Local data stored for the Email's data - this will be the data for a email that is being transferred between two forms
        public static string body = "";
        public static string subject = "";
        public static string[] recipients;

        public void ClearEmailData()
        {   //resets the variables to the original data
            body = "";
            subject = "";
        }
    }
}