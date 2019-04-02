using System.IO;

namespace WelshWanderers.Functions
{
    public class FileWrite
    {
        public static void WriteData(string fileName, string data)
        {
            StreamWriter file = new StreamWriter(fileName + ".txt", true);      //opens file with write access as append
            file.WriteLine(data);   //writes line in file with contents of parameter data
            file.Close();   //closes the file
        }

        public static void RewriteData(string fileName, int recordLength, string[,] localFile)
        {
            string[] tempLine = new string[recordLength];   //sets a temporary line of length equal to the record

            int indexCount = 0; //defines variable to count index at 0
            StreamWriter file = new StreamWriter(fileName + ".txt");    //opens file with write access
            foreach (string line in localFile)  //loops through each line in the array of lines - parameter localFile
            {
                tempLine[indexCount] = line;    //sets the value in the array equal to that line
                ++indexCount;   //incraments index count by 1
                if (indexCount % recordLength == 0) //checks if the remainder of index count/record length is 0
                {
                    string newLine = "";
                    indexCount = 0; //resets index count
                    for (int k = 0; k < recordLength; ++k)  //loops for the length of the record
                    {
                        newLine += tempLine[k] + "|";   //adds item to new line
                    }
                    file.WriteLine(newLine);    //writes new line
                }
            }
            file.Close();   //closes file
        }
    }
}
