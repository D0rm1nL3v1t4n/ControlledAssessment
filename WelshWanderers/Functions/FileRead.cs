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
            skippedLine = false;
            int lineCount = 0;
            string[,] localFile;
            if (operation == "Remove")
                localFile = new string[fileLength - 1, recordLength];
            else
                localFile = new string[fileLength, recordLength];
            StreamReader file = new StreamReader(fileName + ".txt");
            string line = file.ReadLine();
            while (null != line)
            {
                string[] section = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (operation == "Remove")
                    RemoveFunc(lineNumber, lineCount, recordLength, localFile, section);
                else if (operation == "Change")
                    ChangeFunc(lineCount, recordLength, data, localFile, section, searchIndex, searchData);
                
                ++lineCount;
                line = file.ReadLine();
            }
            file.Close();
            return localFile;
        }


        private static void RemoveFunc(int lineNumber, int lineCount, int recordLength, string[,] localFile, string[] section)
        {
            if (lineCount + 1 == lineNumber)
            {
                skippedLine = true;
            }
            else
            {
                for (int j = 0; j < recordLength; ++j)
                {
                    if (skippedLine == true)
                        localFile[lineCount - 1, j] = section[j];
                    else
                        localFile[lineCount, j] = section[j];
                }
            }
        }


        private static void ChangeFunc(int lineCount, int recordLength, string[] data, string[,] localFile, string[] section, int[] searchIndex, string[] searchData)
        {
            //// Compares for one-to-one function & many-to-many function.
            //if (searchIndex.Length == 1 && )
            //{
            //    //One to one
            //}
            //else if (searchIndex.Length == 2)
            //{
            //    //Many to many
            //}


            if ((section[searchIndex[0]] == searchData[0] && section[searchIndex[1]] == searchData[1]) || (section[searchIndex[0]] == searchData[0] && searchData[1] == null))
            {
                localFile[lineCount, 0] = section[0];
                for (int i = 1; i < recordLength; ++i)
                {
                    localFile[lineCount, i] = data[i-1];
                }
            }
            else
            {
                for (int j = 0; j < recordLength; ++j)
                {
                    localFile[lineCount, j] = section[j];
                }
            }
        }
    }
}
