using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Challenge
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Type {  get; set; }
        public string FirstName { get; set; }   
        public int Salary { get; set; }
        public Employee() { }
        public Employee(string name, int salary, string type)
        {
            this.Name = name;
            string firstName = "";
            foreach(var i in name)
            {
                
                if(i!=' ')
                {
                    firstName += i;
                }
                else
                {
                    break;
                }

            }
            this.FirstName= firstName;
            this.Salary= salary;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{Name} is here. You can call her {FirstName}. We wouldnt want you to know she only earns {Salary}";
        }

        public virtual void Work()
        {
            Console.WriteLine($"{FirstName} is working.");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"{FirstName} has taken a break");

        }
    }
}
