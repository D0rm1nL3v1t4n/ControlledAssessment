using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelshWanderers.Functions
{
    class FileDelete
    {
        public static void RemoveLine(string fileName, int recordLength, int lineNumber)
        {
            int fileLength = File.ReadLines(fileName + ".txt").Count();
            string[] data = new string[1] {""};
            string[,] localFile = Functions.FileRead.StoreLocal(fileName, fileLength, recordLength, lineNumber, "Remove", data, 0, "");
            Functions.FileWrite.RewriteData(fileName, recordLength, localFile);
        }
 
    }
}
