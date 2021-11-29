using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = "D:/Папка";*/
            string[] path = Directory.GetDirectories("D:/Папка", "*", SearchOption.AllDirectories);
            foreach (string  item in path)
            {
                Console.WriteLine(item);
            }
            string[] file = Directory.GetFiles("D:/Папка", "*.*", SearchOption.AllDirectories);
            foreach (string item in file)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
