using System;
using System.IO;

namespace WelshWanderers.Functions
{
    public class FileSearch
    {
        public static string ReturnSegment(string fileName, string searchData, int searchIndex, int returnIndex, bool multiReturn = false)
        {
            StreamReader file = new StreamReader(fileName + ".txt");    //Reads the file with read access
            string line;
            string multiReturnValue = "";
            while (null != (line = file.ReadLine()))    //Continues reading the file line (record by record) by line as long as the record is not empty
            {
                string[] section = line.Split('|');     //splits the record into individiual components based on the delimiter
                if (section[searchIndex] == searchData)     //Checks if the data in field index n is the same data as that being searched for
                {
                    if (multiReturn == false)   //checks if the multireturn boolean value is false  
                    {
                        file.Close();
                        return section[returnIndex];    //returns the data at the index specified by the user
                    }
                    else
                        multiReturnValue += section[returnIndex] + "|"; //If the search requires all data that accepts the search conditions to be returned, then this is added to a long string
                }                                                       // seperated by the delimiter '|'
            }   
            file.Close();
            if (multiReturn == true)    //checks if the multireturn boolean value is true
                return multiReturnValue;
            return null;
        }

        public static string ReturnLine(string fileName, string searchData, int searchIndex)
        {
            StreamReader file = new StreamReader(fileName + ".txt");    //opens file with read access
            string line = file.ReadLine();  //reads the first line in the file
            while (null != line)    //checks that the line is not empty
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);    //splits the line based on the delimiter removing all empty data
                if (section[searchIndex] == searchData)     //checks if data at index being searched for has the data that is being searched for
                {
                    file.Close();
                    return line;    //returns the record
                }
                line = file.ReadLine(); //reads next line in the file
            }
            file.Close();
            return null;
        }

        public static int LineNumber(string fileName, string searchData, int searchIndex)
        {
            StreamReader file = new StreamReader(fileName + ".txt");    //opens file with read access
            string line = file.ReadLine();  //reads first line
            int lineNo = 1;     //sets the line number to 1 by default
            while (null != line)    //checks if line is empty
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);    //splits the line based on the delimiter removing all empty data
                if (section[searchIndex] == searchData)     //checks if the data at index being searched for has the data that is being searched for
                {
                    file.Close();
                    return lineNo;  //returns the line number
                }
                line = file.ReadLine(); //reads next line in the file
                ++lineNo;   //incraments line count by 1
            }
            file.Close();
            return 0;   //returns 0 if no data found
        }


        public static int GetNextId(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName + ".txt");  //reads all the lines into an array in the file
            string[] lastRecord = lines[lines.Length - 1].Split('|');   //takes the last line and splits it into individual components based on the delimiter
            return Convert.ToInt16(lastRecord[0]) + 1;  //returns the id for that record + 1
        }

        public static string ManyToMany(string fileName, string searchDataA, int searchIndexA, string searchDataB, int searchIndexB)
        {
            StreamReader file = new StreamReader(fileName + ".txt");    //opens file with read access   
            string line = file.ReadLine();  //reads first line in the file
            while (null != line)    //checks if line is empty
            { 
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);    //splts the line into individual components based on the delimiter 
                //checks if the data in both the index specified is the same as the data being searched for
                if (section[searchIndexA] == searchDataA && section[searchIndexB] == searchDataB)   
                {
                    file.Close();
                    return line;    //returns the record
                }
                line = file.ReadLine(); //reads the next line
            }
            file.Close();
            return null;
        }
    }
}
