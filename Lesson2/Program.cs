using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Условия 1

            //int a = 0;
            //Console.WriteLine("Введите число: ");
            //a = Int32.Parse(Console.ReadLine());

            //// Обычное условие без дополнительных ветвей кода
            //if (a < 0)
            //{
            //    Console.WriteLine(" Вы ввели отрицательное число. ");
            //}

            //// Условие с блоком else
            //if (a > 0)
            //{
            //    Console.WriteLine(" Вы ввели положительное число. ");
            //}
            //else
            //{
            //    Console.WriteLine(" Вы ввели отрицательное число или ноль. ");
            //}

            //// Условие с блоками else if и else
            //if (a > 0)
            //{
            //    Console.WriteLine(" Вы ввели положительное число. ");
            //}
            //else if (a < 0)
            //{
            //    Console.WriteLine(" Вы ввели отрицательное число. "); 
            //}
            //else
            //{
            //    Console.WriteLine(" Вы ввели ноль. ");
            //}            

            #endregion

            #region Условия 2

            //bool var1 = true, var2 = false;

            //if (var1 & var2)
            //    Console.WriteLine("Данный текст не выведется");
            //if (!(var1 & var2))
            //    Console.WriteLine("!(var1 & var2) = true");
            //if (var1 | var2)
            //    Console.WriteLine("var1 | var2 = true");
            //if (var1 ^ var2)
            //    Console.WriteLine("var1 ^ var2 = true");

            #endregion

            #region Тернарный оператор

            //int b = 0, c = -4;

            //b = (c >= 0) ? c : c * c;   // b = 16

            //Console.WriteLine("b = " + b);    

            #endregion

            #region switch

            //Console.WriteLine("Введите язык (C#, VB или C++)");
            //string s = Console.ReadLine();

            //switch (s)
            //{
            //    case "C#":
            //        Console.WriteLine("Вы выбрали язык C#");
            //        break;
            //    case "VB":
            //        Console.WriteLine("Вы выбрали язык Visual Basic");
            //        break;
            //    case "C++":
            //        Console.WriteLine("Вы выбрали язык С++");
            //        break;
            //    default:
            //        Console.WriteLine("Такой язык я не знаю");
            //        break;
            //}

            #endregion

            #region while & do while

            //int i = 10;

            //while (i > 0)
            //{
            //    Console.WriteLine("i = " + i);
            //    i--;
            //}

            //i = 10;
            //do
            //{
            //    Console.WriteLine("i = " + i);
            //    i--;
            //} while (i > 0);

            #endregion

            #region for

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("i = " + i);
            //}

            #endregion

            #region break, continue

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("i = " + i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("i = " + i);
            //}

            #endregion

            #region Одномерные массивы

            //int[] intArray;
            //intArray = new int[10];
            //intArray = new int[4] { 1, 2, 3, 4 };
            //int[] intArray1 = { 1, 2, 3, 4 };

            //for (int i = 0; i < 4; i++)
            //{
            //    intArray[i] = i * i;
            //}

            #endregion

            #region Двумерные массивы

            //int[,] intArray = new int[4, 4];
            //int[,] intArray1 = 
            //{ 
            //    {1,2,3}, 
            //    {4,5,6}, 
            //    {7,8,9}
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(intArray1[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Рваные массивы

            //Random rand = new Random();
            //int[][] intJaggedArray = new int[5][];
            //for (int i = 0; i < 5; i++)
            //{
            //    intJaggedArray[i] = new int[6];  
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        intJaggedArray[i][j] = rand.Next(1, 100);
            //        Console.Write(intJaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(intJaggedArray.GetUpperBound(0));

            #endregion

            #region Методы

            //PrintArray();
            Console.WriteLine("Сложение чисел.");
            Console.WriteLine("Введите первое слагаемое: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое: ");
            int b = int.Parse(Console.ReadLine());
            int c = SumTwoNumbers(a, b);
            Console.WriteLine("Сумма = " + c);

            #endregion

            Console.ReadLine();
        }

        static void PrintArray()
        {
            int[] intArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Печатаем массив:");
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write(intArray2[i] + " ");
            }
        }

        static int SumTwoNumbers(int a, int b)
        {
            int c = 0;
            c = a + b;
            return c;
        }
        static double SumTwoNumbers(double a, double b)
        {
            double c = 0;
            c = a + b;
            return c;
        }
    }
}