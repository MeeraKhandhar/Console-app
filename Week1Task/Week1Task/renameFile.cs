using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Task
{
    class renameFile
    {
        /*public static void Main(string[] args)
        {
            Console.WriteLine("Do you want to rename a file? (yes/no)");
                string response = Console.ReadLine();
                while (response == "yes")
                {
                    Console.Write("Enter the path of the file you want to rename: ");
                    string oldFilePath = Console.ReadLine();
                    Console.Write("Enter the new name for the file: ");
                    string newFileName = Console.ReadLine();
                    RenameFile(oldFilePath, newFileName);
                    Console.WriteLine("Do you want to rename another file? (yes/no)");
                    response = Console.ReadLine();
                }
        }

        static void RenameFile(string oldFilePath, string newFileName)
        {
            if (File.Exists(oldFilePath))
            {
                try
                {
                    string newFilePath = Path.Combine(Path.GetDirectoryName(oldFilePath), newFileName);
                    File.Move(oldFilePath, newFilePath);
                    Console.WriteLine("File renamed");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error while renaming file: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }*/
    }
}



    
