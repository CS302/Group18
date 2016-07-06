using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public class Manager : Worker
    {
        public int ProjectsCount { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Количество проектов: " + ProjectsCount);
            Console.WriteLine();
        }

        public override int GetSalary()
        {
            return ProjectsCount * 2000;
        }

        public Manager(string name, int age, int snn, int projcount)
            : base(name, age, snn)
        {
            this.ProjectsCount = projcount;
        }
    }
}
