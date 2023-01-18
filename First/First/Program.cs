using System;
//system is used for the Console class 
using System.Diagnostics.CodeAnalysis;
using System.Globalization;


/*conventions: 
 * Class names: Pascal Casing -> PascalCase
 * Method names: Pascal Casing
 * Method arguments: Camel Casing -> CamelCase
 * Variable names: Camel Casing
*/

namespace First
{
    internal class Program
    {
        //constants to be declared here 
        const double PI = Math.PI;
        const int weeks = 52, months = 12;
        const string birthday = "20|10|2000";


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("hello world!");
            Console.WriteLine("it me yaamariyoo");

            int num1 = 10, num2;
            num2 = 20;
            int sum = num1 + num2;

            //converts the int to str by itself 
            Console.WriteLine("num1: " + num1 + " num2: " + num2 + " sum: " + sum);

            double pi = 3.1415;
            double d1 = 5.1;
            Console.WriteLine("pi/d1: " + pi / d1);

            //for floats, we _need_ to add f at the end 
            //theyre rounded off 
            float pif = 3.1415f;
            Console.WriteLine(pi / pif);

            Console.Clear();

            //stringzz
            string name = "Sne";
            string message = name + " hellos";

            Console.WriteLine(message.ToUpper().Length);


            //int and booleans are examples of primitive datatypes 
            //whereas strings are not prmitive, they are classes that have their own attributes and methods

            //withoutnewline  
            //Console.Write() does not add newline at the end 
            //unlike Console.WriteLine()
            Console.Write(name);
            Console.WriteLine(" no new line");
            Console.WriteLine("new line");

            //keeps it open  
            //waits for some input

            //ascii value or single character
            //Console.ReadKey();

            //string 
            //Console.ReadLine();

            string new_name = Console.ReadLine();



            string age = Console.ReadLine();
            //age is in ascii 
            // index in {} of the variable  
            Console.WriteLine("My new names {0} and I am {1} years old", new_name, (int.Parse(age)));

            Console.Beep();

            Console.Clear();

            //conversions
            //explicit conversion 
            float f1 = 31.45f;
            int i1 = (int)f1;
            Console.WriteLine(i1);

            //implicit conversion 
            float f2 = 343.43f;
            double d2 = f2;
            Console.WriteLine(d2);

            //type conversion 
            int i2 = 6789;
            string s1 = i2.ToString();
            Console.WriteLine(s1);
            bool sun = true;
            string sun_ = sun.ToString();
            Console.WriteLine(sun_);


            //string to integer 
            string s2 = "123", s3 = "453";
            int i3 = Int32.Parse(s2) + Int32.Parse(s3); ;
            Console.WriteLine(i3);


            //assignment 
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float f3 = float.Parse(stringForFloat);
            int i4 = int.Parse(stringForInt);
            Console.WriteLine("{0} {1}", f3, i4);

            Console.Clear();


            ////String manipulation 
            //Console.WriteLine("String Concat");
            //Console.WriteLine("Hello I'm " + new_name + " and I'm " + age + " years old");


            //Console.WriteLine("String Formatting");
            //Console.WriteLine("Hello {0}, I Lov ye -{1}", ("sne"), new_name);

            //Console.WriteLine("String interpolation");
            //Console.WriteLine($"Hello {new_name}, I'm not so sure anymore -{"sne"}");

            //Console.WriteLine("verbatim strings");
            //Console.WriteLine(@"Hello 
            //                    there 
            //                    this is all 
            //                    made up 
            //                    of newlines
            //                    \n doesnt have any powers here lol");


            ////string methods
            //Console.WriteLine(new_name.Trim().Substring(1, 2).ToUpper());
            //Console.WriteLine("has s at : " + new_name.ToLower().IndexOf('s'));
            //Console.WriteLine(String.Concat(" ", name, " ", new_name));
            //Console.WriteLine(String.Format("okk {0}", "nise"));


            //Console.Clear();

            //Console.WriteLine("Enter a string : ");
            //string input = Console.ReadLine();

            //Console.WriteLine("Enter the search key : ");
            //string searchKey = Console.ReadLine();
            //Console.WriteLine($"{searchKey} found at {input.IndexOf(searchKey)}th index of {input}");

            //Console.WriteLine();
            //Console.WriteLine("Enter first name : ");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Enter last name : ");
            //string lname = Console.ReadLine();
            //string fullName = String.Concat(fname, "", lname);
            //Console.WriteLine($"Is your full name {fullName} ?");
            //string prompt = Console.ReadLine();
            //if (prompt[0] == 'y' || prompt[0]  == 'Y')
            //{
            //    Console.WriteLine($"Welcome {fullName}");
            //}


            //Console.Clear();

            ////dataTypes 
            //byte byteOne = 100;
            //Console.WriteLine(byteOne);
            //sbyte sByteOne = -100;
            //Console.WriteLine(sByteOne);
            //int intOne = 45675;
            //Console.WriteLine(intOne);
            //uint uintOne = 567890435;
            //Console.WriteLine(uintOne);
            //short shortOne = 4546;
            //Console.WriteLine(shortOne);
            //ushort uShortOne = 34543;
            //Console.WriteLine(uShortOne);
            //long longOne = -5678909876789;
            //Console.WriteLine(longOne);
            //ulong ulongOne = 567890435;
            //Console.WriteLine(ulongOne);
            //float floatOne = -3.54534f;
            //Console.WriteLine(floatOne);
            //double doubleOne = 534.32343;
            //Console.WriteLine(doubleOne);
            //char charOne = 'y';
            //Console.WriteLine(charOne);
            //bool boolOne = false;
            //Console.WriteLine(boolOne);
            //object objectOne = null;
            //Console.WriteLine(objectOne);
            //string stringOne = "ftgyhui";
            //Console.WriteLine(stringOne);
            //decimal decimalOne = 5;
            //Console.WriteLine(decimalOne);

            //Console.Clear();

            const int hairsOnHead = 0;
            Console.WriteLine("Hairs on head = {0}", hairsOnHead);




            

            Console.ReadKey();
        }
    }
} 

