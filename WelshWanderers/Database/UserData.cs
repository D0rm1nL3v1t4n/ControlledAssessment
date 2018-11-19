using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshWanderers.Database
{
    class UserData
    {
        public static int id = -1;
        public static string title = "";
        public static string firstName = "";
        public static string lastName = "";
        public static string dateOfBirth = "";
        public static string emailAddress = "";
        public static string telephoneNumber = "";
        public static string postcode = "";
        public static string username = "";
        public static string accessLevel = "";
        public static string team = "";

        public void ClearUserData()
        {
            id = -1;
            title = "";
            firstName = "";
            lastName = "";
            dateOfBirth = "";
            emailAddress = "";
            postcode = "";
            username = "";
            accessLevel = "";
            team = "";
        }
    }
}
