using System;
using System.Linq;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////object or instance
            //string fname, lname, ecolor, agestr;
            //int age;
            //Console.Write("Enter firstname: ");
            //fname = Console.ReadLine();
            //Console.Write("Enter lastname: ");
            //lname = Console.ReadLine();
            //Console.Write("Enter age: ");
            //agestr = Console.ReadLine();
            //int.TryParse(agestr, out age);
            //Console.Write("Enter eyecolor: ");
            //ecolor = Console.ReadLine();
            //if(verifier(fname, lname, age, ecolor))
            //{
            //    Human new_human = new Human(fname, lname, age, ecolor);
            //    new_human.Introduce();

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Make sure the first name, last name and eye color are strings made up of only english alphabets and age is a valid integer between 18 and 65.\nExiting... ");
            //    throw new Exception("Format error: Make sure the inputs match the format specified");
            //}
            //Box new_box = new Box();
            //new_box.SetDimension(100, 100, 100);
            //new_box.Height = 200;
            //int[] new_arr = new_box.GetDimensions();
            //string[] dims = { "length", "height", "width" };
            //for(int i = 0; i < new_arr.Length; i++)
            //{
            //    Console.WriteLine(dims[i] + " : " + new_arr[i]);
            //}
            //new_box.DisplayInfo();

            Members new_member = new Members("sneh", "developer", true);
            new_member.Introduce();
            Console.ReadKey();
            
        }

        static bool verifier(string firstName, string lastName, int age, string eyeColor)
        {
            bool firstBool = firstName.All(Char.IsLetter);
            bool lastBool = lastName.All(Char.IsLetter);
            bool validAge = age > 18 && age < 66;
            bool eyeValid = eyeColor.All(Char.IsLetter);
            return firstBool && lastBool && validAge && eyeValid;
        }
    }
}
