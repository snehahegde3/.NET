using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Challenge
{
    internal class Boss: Employee
    {
        public string CompanyCar { get; set; }  

        public Boss() { }

        public Boss(string CompanyCar, string name, int salary):base(name, salary, "Boss") {
            this.CompanyCar = CompanyCar;
        }

        public void Lead()
        {
            Console.Write($"{FirstName} is a great leader and is leading the entire operation.");
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName}, the boss is Working.");
        }
    }
}
