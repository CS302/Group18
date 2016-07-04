using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string text = "\a";
            Console.WriteLine(text);

            text = "первая\nвторая";
            Console.WriteLine(text);

            text = "первая\r123";
            Console.WriteLine(text);

            //string[] symbols = new string[]{"\\", "|", "-", "/"};
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(symbols[i%4] + "\r");
            //    Thread.Sleep(100);
            //}

            string path = @"C:\Lesson6\1.txt";
            Console.WriteLine(path);

            path = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("наши занятия \"лёгкие\"");
            path = @"первая строка
вторая строка
                третья строка";
            Console.WriteLine(path);*/

            /*string text = "Простая строка";
            Console.WriteLine(text.Length);
            Console.WriteLine(text[text.Length-1]);

            Console.WriteLine(text.CompareTo("Сложная строка"));

            Console.WriteLine(text.Contains("стр"));
            
            Console.WriteLine(text.Insert(0, "Это "));
            Console.WriteLine(text.Insert(8, "!!!"));

            Console.WriteLine(text.Replace("Простая", "Сложная"));

            string data = "6513 123 684 87";
            string[] items = data.Split(' ');
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                sum += int.Parse(items[i]);
            }
            Console.WriteLine(sum);
            text = " строка ";
            text.Trim(' ');

            Console.WriteLine(text.ToUpper());*/

            /*int n = 100000;
            //string data = "";
            StringBuilder data1 = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                data1.Append(i);
            }
            Console.WriteLine(data1);*/

            int x = 10;
            int y = 15;
            string str = "label";

            Console.WriteLine("Координата X = {0}\nКоордината Y = {0}", x);
            string message = string.Format("Координата X = {0}\nКоордината Y = {1}", x, y);

            double price = 99.9999;
            Console.WriteLine("Цена = {0}", price);

            Console.WriteLine("Цена = {0:e}", price); //science

            Console.WriteLine("Цена = {0:c}", price); //commercial

            DateTime date = DateTime.Now;
            Console.WriteLine("{0:HH:mm}", date);
            Console.WriteLine("{0:yyyy.MMM.dd HH:mm}", date);

        }
    }
}
