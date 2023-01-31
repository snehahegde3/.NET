using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Challenge
{
    internal class Trainee: Employee
    {
        protected string WorkingHours;
        protected string SchoolHours; 

        public Trainee() {  }

        public Trainee(string workingHours, string schoolHours, string name, int salary) : base(name, salary, "Trainee")
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{FirstName}, the trainee is learning as much as they can. Give them a break");
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} is at school from {SchoolHours} and working from {WorkingHours}");
        }
    }

}
