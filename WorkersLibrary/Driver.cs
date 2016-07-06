using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public class Driver : Worker
    {
        public string CarType { get; set; }
        public int Hours { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + CarType);
            Console.WriteLine("Количество часов: " + Hours);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return Hours * 500;
        }

        public Driver(string name, int age, int snn, string cartype, int hours)
            : base(name, age, snn)
        {
            this.CarType = cartype;
            this.Hours = hours;
        }
    }
}
