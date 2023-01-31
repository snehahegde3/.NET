using System;
using System.Collections;

namespace Inheritance___Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList employees = new ArrayList();
            employees.Add(new Trainee("10-4", "8-10", "Sneha Hegde", 100000));
            employees.Add(new Boss("Benz", "Nandan Chaitra", 200000));
            employees.Add(new Employee("Bebhav Soni", 150000, "Engineer"));
            Console.WriteLine(employees.Count + " Employees");

            foreach(Employee i in employees)
            {
                i.Work();
            }

            foreach(Employee i in employees)
            {
                i.Pause();
            }

            foreach(dynamic i in employees)
            {
                if(i.Type == "Trainee")
                {
                    i.Learn();
                }
                else if(i.Type == "Boss")
                {
                    i.Lead();
                }
            }

            Console.ReadKey();
        }
    }
}
