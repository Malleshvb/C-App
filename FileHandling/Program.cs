using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = ConfigurationManager.AppSettings["file_new"];

            StreamWriter streamWriter = new StreamWriter(filepath, true);
            Console.Write("Provide some input:");
            string data = Console.ReadLine();
            streamWriter.WriteLine($"{DateTime.Now}:{data}");
            streamWriter.Close();

            StreamReader read = new StreamReader(filepath);
            string content = read.ReadToEnd();
            Console.WriteLine("----file Content--- ");
            Console.WriteLine(content);
        }
        public static void ShowDirecties()
        {
            foreach(DirectoryInfo info in new DirectoryInfo(@"C:\").GetDirectories())
            {
                Console.WriteLine(info.Name);
            }
        }
    }
}
