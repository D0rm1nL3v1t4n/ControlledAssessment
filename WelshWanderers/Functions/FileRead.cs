using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    class FileRead
    {
        public static bool skippedLine = false;

        public static string[,] StoreLocal(string fileName, int fileLength, int recordLength, int lineNumber, string operation, string[] data, int[] searchIndex, string[] searchData)
        {
            skippedLine = false;    //Sets skipped line to false by default --> Can this be done only for Remove function?
            int lineCount = 0;      
            string[,] localFile;
            if (operation == "Remove")
                localFile = new string[fileLength - 1, recordLength];   //Sets the length of the array to the dimensions of the file after removing the line
            else
                localFile = new string[fileLength, recordLength];   //Sets the length of the array to the length of the file
            
            StreamReader file = new StreamReader(fileName + ".txt");    //Open the file with read access
            string line;
            while (null != (line = file.ReadLine()))    //Continues to read the file line by line while the record has data in it
            {
                string[] section = line.Split('|');     //Splits the line based on the delimiter that is a bar '|'
                if (operation == "Remove")
                    RemoveFunc(lineNumber, lineCount, recordLength, localFile, section);
                else if (operation == "Change")
                    ChangeFunc(lineCount, recordLength, data, localFile, section, searchIndex, searchData);

                ++lineCount;
            }
            file.Close();
            return localFile;
        }


        private static void RemoveFunc(int lineNumber, int lineCount, int recordLength, string[,] localFile, string[] section)
        {
            if (lineCount + 1 == lineNumber)//Checks whether the line that needs to be removed has already been removed.
            {
                skippedLine = true;//If this line has already been removed then the changes this variable to match this
            }
            else
            {
                for (int j = 0; j < recordLength; ++j)
                {
                    if (skippedLine == true)
                        localFile[lineCount - 1, j] = section[j];//If a line has been skipped then moves all records up one line
                    else
                        localFile[lineCount, j] = section[j];//If the line hasn't been skipped then keeps data the same
                }
            }
        }


        private static void ChangeFunc(int lineCount, int recordLength, string[] data, string[,] localFile, string[] section, int[] searchIndex, string[] searchData)
        {
            int counter = 0;//The number of conditions passed in the search
            for (int i = 0; i < searchIndex.Length; ++i)//Searches based on the conditions to change the current line
            {
                if (section[searchIndex[i]] == searchData[i])//If successful then adds 1 to counter
                    counter += 1;
            }

            if (counter == searchIndex.Length) //All conditions for the searches passed as true
            {
                for (int j = 0; j < recordLength; ++j)
                {
                    if (j < searchIndex.Length)//If true then the data does not need to be changed
                        localFile[lineCount, j] = section[j];//Keeps the IDs the same as before
                    else                       //Otherwise the data does need to be changed
                        localFile[lineCount, j] = data[j - searchIndex.Length]; //Changes the data that needs to be changed
                }
            }
            else //None or not all conditions for the searches have passed as true
            {
                for (int k = 0; k < recordLength; ++k)
                {
                    localFile[lineCount, k] = section[k];//Keeps all the data on this line the same as before
                }
            }
        }
    }
}
