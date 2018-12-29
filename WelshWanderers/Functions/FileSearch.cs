using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelshWanderers.Functions
{
    class FileSearch
    {
        public static string ReturnSegment(string fileName, string searchData, int searchIndex, int returnIndex, bool multiReturn = false)
        {
            StreamReader file = new StreamReader(fileName + ".txt");
            string line = file.ReadLine();
            string multiReturnValue = "";
            while (null != line)
            {
                string[] section = line.Split('|');
                if (section[searchIndex] == searchData)
                {
                    if (multiReturn == false)
                    {
                        file.Close();
                        return section[returnIndex];
                    }
                    else
                        multiReturnValue += section[returnIndex] + "|";
                }
                line = file.ReadLine();
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
