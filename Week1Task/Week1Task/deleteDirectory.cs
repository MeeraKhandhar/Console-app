using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Task
{
    class deleteDirectory
    {
       /* public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the path of the directory you want to delete: ");
                string path = Console.ReadLine();
                DeleteDirectory(path);
                Console.Write("Do you want to delete another directory (yes/no)? ");
                string choice = Console.ReadLine();
                if (!choice.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

        static void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path, true);
                    Console.WriteLine("Directory successfully deleted");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error while deleting directory: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }
        }*/
    }
}

