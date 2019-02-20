using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelshWanderers.Functions
{
    public class FileWrite
    {
        public static void WriteData(string fileName, string data)
        {
            StreamWriter file = new StreamWriter(fileName + ".txt", true);
            file.WriteLine(data);
            file.Close();
        }


        public static void RewriteData(string fileName, int recordLength, string[,] localFile)
        {
            string[] tempLine = new string[recordLength];

            int indexCount = 0;
            StreamWriter file = new StreamWriter(fileName + ".txt");
            foreach (string line in localFile)
            {
                tempLine[indexCount] = line;
                ++indexCount;
                if (indexCount % recordLength == 0)
                {
                    string newLine = "";
                    indexCount = 0;
                    for (int k = 0; k < recordLength; ++k)
                    {
                        newLine += tempLine[k] + "|";
                    }
                    file.WriteLine(newLine);
                }
            }
            file.Close();
        }

    }
}
