using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            do
            {
                Console.WriteLine("Path:");
                path = Console.ReadLine();
            } while (!Directory.Exists(path));

            foreach (var item in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                if (new FileInfo(item).Length > 100 * 1024 * 1024)
                {
                    Console.WriteLine(item + " is over size 100 MB.");
                }
            }
            Console.WriteLine("End.");

            Console.ReadLine();
        }
    }
}
