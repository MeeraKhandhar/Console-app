using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Task
{
    class createFile
    {
       /* public static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create a file? (yes/no)");
            string response = Console.ReadLine();
            while (response == "yes")
            {
                Console.Write("Enter the path of the directory you want to create the file in: ");
                string directoryPath = Console.ReadLine();
                Console.Write("Enter the name of the file you want to create: ");
                string fileName = Console.ReadLine();
                CreateFile(directoryPath, fileName);
                Console.WriteLine("File created");
                Console.WriteLine("Do you want to create another file? (yes/no)");
                response = Console.ReadLine();
            }
        }

        static void CreateFile(string directoryPath, string fileName)
        {
            if (Directory.Exists(directoryPath))
            {
                try
                {
                    string filePath = Path.Combine(directoryPath, fileName);
                    File.Create(filePath).Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error while creating file: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }*/
    }
}


