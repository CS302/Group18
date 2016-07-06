using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public abstract class Worker
    {
        private string name;
        private int age;
        public int snn;

        public static int count;

        public int Snn
        { get { return snn; } set { snn = value; } }

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
            set { name = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("Зарплата: " + GetSalary());
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
                workers[i].Print();
        }

        public abstract int GetSalary();

        public void PayTaxes()
        {

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
            : this(name, age, 0)
        { }

        static Worker()
        {
            count = 0;
        }
    }
}
