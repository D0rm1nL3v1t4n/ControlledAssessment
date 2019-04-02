using System.Linq;
using System.IO;

namespace WelshWanderers.Functions
{
    public class FileDelete
    {
        public static void RemoveLine(string fileName, int recordLength, int lineNumber)
        {
            int fileLength = File.ReadLines(fileName + ".txt").Count(); //counts the number of lines in the file
            string[] data = {""};
            int[] indexData = { 0 };
            string[] searchData = { "" };
            //calls on function to remove the line from the file
            string[,] localFile = Functions.FileRead.StoreLocal(fileName, fileLength, recordLength, lineNumber, "Remove", data, indexData , searchData);
            Functions.FileWrite.RewriteData(fileName, recordLength, localFile); //calls on function to rewrite all the data back to the file
        }
    }
}
