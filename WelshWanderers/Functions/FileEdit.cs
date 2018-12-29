using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WelshWanderers.Functions
{
    class FileEdit
    {
        public static void EditLine(string fileName, int recordLength, string[] data, int[] searchIndex, string[] searchData)
        {
            int fileLength = File.ReadLines(fileName + ".txt").Count();
            string[,] localFile = Functions.FileRead.StoreLocal(fileName, fileLength, recordLength, 0, "Change", data, searchIndex, searchData);
            Functions.FileWrite.RewriteData(fileName, recordLength, localFile);        
        }       
    }
}
