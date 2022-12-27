using System;
using System.Reflection.Metadata.Ecma335;

namespace Arrays
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            Arrays();
            Console.WriteLine();
            ForEach();
            Console.WriteLine();
            ForEach_Switch_Challenge();


            Console.ReadKey();
        }

        public static void Arrays()
        {
            //dataType[] arrayName = new dataType[amountOfEntries];

            int[] grades = new int[10];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = i;
                Console.Write(i.ToString());
            }
            
            

        }
        public static void ForEach()
        {
            string[] grades = new string[] { "A", "B", "C", "D", "S"};
            //foreach loop 
            //the datatype if the type of the elements in the array 
            foreach (string k in grades)
            {
                Console.Write($"{k} ");
            }
        }

        public static void ForEach_Switch_Challenge()
        {
            bool isValid = true;
            Console.Write("Enter input value: ");
            string input = Console.ReadLine();
            Console.Write("Press\n1 for String\n2 for Integer\n3 for Boolean\nEnter data type: ");
            string dataType = Console.ReadLine();
            //or could use Convert.ToInt32(Console.Readline()) to get int cases 
            switch (dataType)
            {
                case "1": 
                    foreach(char i in input)
                    {
                        if (!Char.IsLetter(i))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    break;
                case "2":
                    foreach (char i in input)
                    {
                        if (!Char.IsNumber(i))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    break;
                case "3":
                    if (input != "true" && input != "false")
                    {
                        isValid= false;
                    }
                    
                    break;
                default: isValid = false;
                    Console.WriteLine("Invalid option selected."); 
                    break;
            }
            if(isValid )
            {
                string dataTypeString = dataType == "1" ? "String" : dataType == "2" ? "Integer" : "Boolean";
                Console.WriteLine($"You chose {dataTypeString} input with value {input}");
            }
            else
            {
                Console.WriteLine("Invalid input and data type");
            }
            

        }
    }
}
