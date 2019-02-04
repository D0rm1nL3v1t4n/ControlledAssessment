using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    class FileSearch
    {
        public static string ReturnSegment(string fileName, string searchData, int searchIndex, int returnIndex, bool multiReturn = false)
        {
            StreamReader file = new StreamReader(fileName + ".txt");    //Reads the file with read access
            string line;
            string multiReturnValue = "";
            while (null != (line = file.ReadLine()))    //Continues reading the file line (record by record) by line as long as the record is not empty
            {
                string[] section = line.Split('|');
                if (section[searchIndex] == searchData)     //Checks if the data in field index n is the same data as that being searched for
                {
                    if (multiReturn == false)            
                    {
                        file.Close();
                        return section[returnIndex];
                    }
                    else
                        multiReturnValue += section[returnIndex] + "|"; //If the search requires all data that accepts the search conditions to be returned, then this is added to a long string
                }                                                       // seperated by the delimiter '|'
            }   
            file.Close();
            if (multiReturn == true)
                return multiReturnValue;
            return null;
        }

        public static string ReturnLine(string fileName, string searchData, int searchIndex)
        {
            StreamReader file = new StreamReader(fileName + ".txt");
            string line = file.ReadLine();
            while (null != line)
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (section[searchIndex] == searchData)
                {
                    file.Close();
                    return line;
                }
                line = file.ReadLine();
            }
            file.Close();
            return null;
        }

        public static int LineNumber(string fileName, string searchData, int searchIndex)
        {
            StreamReader file = new StreamReader(fileName + ".txt");
            string line = file.ReadLine();
            int lineNo = 1;
            while (null != line)
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (section[searchIndex] == searchData)
                {
                    file.Close();
                    return lineNo;
                }
                line = file.ReadLine();
                ++lineNo;
            }
            file.Close();
            return 0;
        }


        public static int GetNextId(string fileName)
        {
            StreamReader file = new StreamReader(fileName + ".txt");
            string line;
            int id = 0;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                id = Convert.ToInt16(section[0]);
            }
            file.Close();
            return id + 1;
            
        }

        public static string ManyToMany(string fileName, string searchDataA, int searchIndexA, string searchDataB, int searchIndexB)
        {
            StreamReader file = new StreamReader(fileName + ".txt");
            string line = file.ReadLine();
            while (null != line)
            { 
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (section[searchIndexA] == searchDataA && section[searchIndexB] == searchDataB)
                {
                    file.Close();
                    return line;
                }
                line = file.ReadLine();
            }
            file.Close();
            return null;
        }
    }
}
