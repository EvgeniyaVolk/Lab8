using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Папка/File.txt";
            /*Проверяем, существует ли файл, если нет, то создаем его*/
            if (!File.Exists(path))
            {
                File.Create(path);
            }
           
            /*Записываем в файл 10 случайных чисел)*/
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                array[i] = random.Next(0, 50);
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(array[i]);
                sw.Close();
                }
           
            /*Считываем файл и расчитываем сумму*/
            float sum = 0;
            string[] temp;
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine().Split();
                foreach (string s in temp)
                {
                    if (s!=null)
                    {
                        sum += float.Parse(s);
                    }
                }
            }
            sr.Close();
            Console.WriteLine(sum.ToString());          
            Console.ReadKey();



        }
    }
}
