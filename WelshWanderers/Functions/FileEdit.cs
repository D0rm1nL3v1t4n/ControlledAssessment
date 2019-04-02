using System.Linq;
using System.IO;

namespace WelshWanderers.Functions
{
    public class FileEdit
    {
        public static void EditLine(string fileName, int recordLength, string[] data, int[] searchIndex, string[] searchData)
        {
            int fileLength = File.ReadLines(fileName + ".txt").Count(); //counts the number of lines in the file
            //calls on function to edit the line in the file
            string[,] localFile = Functions.FileRead.StoreLocal(fileName, fileLength, recordLength, 0, "Change", data, searchIndex, searchData);
            Functions.FileWrite.RewriteData(fileName, recordLength, localFile);     //calls on function to rewrite the data to the file
        }       
    }
}
