using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List<int>();
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Reverse();
            list.Insert(1, 45);


            Console.WriteLine(list.Count);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }*/

            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] extensions = ".exe.pdf.cs.txt.txt.cs.exe".Split('.');
            for (int i = 0; i < extensions.Length; i++)
            {
                if (!dict.ContainsKey(extensions[i]))
                {
                    dict.Add(extensions[i], 1);
                }
                else
                {
                    dict[extensions[i]] += 1;
                }
            }

            /*Stack<int> stack = new Stack<int>(); //LIFO
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack) //стек не опустошится
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var x = 10;
            x = 10 + 15;
            //x = "qwerty"; ошибка компиляции

            
            while (stack.Count != 0) //стек опустошится
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*Queue<int> queue = new Queue<int>(); //FIFO
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);

            Console.WriteLine(queue.Peek());


            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());*/

            Point<string, double> p = new Point<string, double>("qwerty", 800000);
            p.Print();
        }
    }

    class Point<T, M>
    {
        T x;
        M y;

        public Point(T x, M y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}", x, y);
        }
    }
}
