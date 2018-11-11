using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharp
{
    class UserData
    {
        public static string title = "";
        public static string firstName = "";
        public static string lastName = "";
        public static string dateOfBirth = "";
        public static string emailAddress = "";
        public static string telephoneNumber = "";
        public static string postcode = "";
        
        public static int userID = -1;
        public static string username = "";
        public static string userLevel = "";

        public void ClearUserData()
        {
            title = "";
            firstName = "";
            lastName = "";
            dateOfBirth = "";
            emailAddress = "";
            postcode = "";
            userID = -1;
            username = "";
            userLevel = "";
        }


    }
}
