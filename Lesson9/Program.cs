using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static Queue<int> queue;
        static object block = new object();
        static void Main(string[] args)
        {
            #region Запуск отдельных потоков
            /*Func<int, int, int> workItem = GetNumbers;
            IAsyncResult ires = workItem.BeginInvoke(10, 20, null, null);
            
            while (Console.ReadLine() != "exit")
            {   }

            int sum = workItem.EndInvoke(ires);
            Console.WriteLine(sum);*/
            
            #endregion

            #region Параллелизм
            //queue = new Queue<int>();
            //for (int i = 1; i < 100; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //Action<int> workItem = CalcQueItem;
            //workItem.BeginInvoke(1, null, null);
            //workItem.BeginInvoke(2, null, null);

            //Console.ReadLine(); 
            #endregion

            ParameterizedThreadStart start = Test;
            Thread thread1 = new Thread(start);
            thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.Normal;
            thread1.Name = "Первый поток";
            thread1.Start(new int[] { 10, 20 });

            while (Console.ReadLine() != "exit")
            {   }
            
        }

        static void Test(object obj)
        {
            int[] array = (int[])obj;
            int a = array[0];
            int b = array[1];
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        static void CalcQueItem(int id)
        {
            while (queue.Count != 0)
            {
                int number;

                lock (block)
                {
                    number = queue.Dequeue();
                }
                number *= number;
                Console.WriteLine("{0} - {1}", id, number);
            }
            
        }

        

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            return sum;
        }

        
    }
}
