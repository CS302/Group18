using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[4];
            workers[0] = new Worker("Vasya", 29, 643554);
            workers[1] = new Worker("Petya", 25, 6123456);
            workers[2] = new Worker("John", 32);
            workers[3] = new Worker("Ivan", 28, 48653);

            Worker.PrintWorkers(workers);
            
            Console.WriteLine(Worker.count);
            
        }
    }
    
    class Worker
    {
        private string name;
        private int age;
        public int snn;

        public static int count;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Неверно задан возраст!!!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
        }
        
        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
                workers[i].Print();
        }

        /// <summary>
        /// Базовый конструктор для работника
        /// </summary>
        /// <param name="name">Имя работника</param>
        /// <param name="age">Возраст работника</param>
        /// <param name="snn">ИНН работника</param>
        public Worker(string name, int age, int snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            count++;
        }

        public Worker(string name, int age)
            :this(name, age, 0)
        {   }

        static Worker()
        {
            count = 0;
        }
    }
}
