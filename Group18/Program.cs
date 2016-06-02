using System;

namespace Lesson1
{
    class Program
    {
        //msdn.com
        static void Main(string[] args)
        {
            /*int number; //объявление
            number = 10; //инициализация
            Console.WriteLine(number);


            int number2 = 100;
            Console.WriteLine(number2);

            number = 10 + 15 * 23;
            number = 10 - number;
            Console.WriteLine(number);

            number = 56 % 10;
            Console.WriteLine(number);
            int x = 56;
            double number3 = (double)x / 10;
            Math.Pow(10, 2); //10^2
            Console.WriteLine(number3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string text = "6853";
            int y = int.Parse(text) + 10;
            Console.WriteLine(y);*/


            /*string input = Console.ReadLine();
            int x = int.Parse(input);
            x = x + 10;
            Console.WriteLine();
            Console.WriteLine(x);

            char symbol = 'A';

            Console.WriteLine("a" + "b" + "c");

            Console.WriteLine('a' + 'b' + 'c');
            
            bool flag = true;
            flag = false && true;
            Console.WriteLine(!flag);


            int z = 10;
            z *= 2;
            Console.WriteLine(z);*/

            int day = 1;
            int month = 6;
            int year = 2016;

            DateTime date = new DateTime(2016, 6, 1);
            Console.WriteLine(date.DayOfWeek);

            int x;
            Int32 y; //alias

            DayOfWeek d = DayOfWeek.Friday;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Жёлтенький");
        }
    }
}
