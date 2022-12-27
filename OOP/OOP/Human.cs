using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        private string firstName;

        private string lastName;

        //public
        //accessible from outside
        public int age;
        private string eyeColor;

        //constructor

        //default
        public Human(){}

        //parameterised
        public Human(string firstName = "", string lastName = "", int age = 18, string eyeColor = "")
        {
            //this used to avoid ambiguity
            //this points to this object and not the local variable 
            
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1);
            this.firstName = firstName;
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1);
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;

        }


        

        //public method
        public void Introduce()
        {
            Console.WriteLine($"Hello, I'm {firstName} {lastName}. I'm a {age} year old with {eyeColor} eyes");
        }
    }
}
