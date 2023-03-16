using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Arrays
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            var res = GitHelper.GetShortCommitSha();
            Console.WriteLine($"{res[0]}, {res[1]}");
            GitHelper.Lib2GitHelper();
            Arrays();
            Console.WriteLine();
            ForEach();
            Console.WriteLine();
            ForEach_Switch_Challenge();
            Console.WriteLine();
            MultiDimensionalArrays();

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

        public static void MultiDimensionalArrays()
        {
            string[,] matrix; 
            int[, , ] threeD;
            int[, ,] arr3D = new int[, ,] 
            {
                { 
                    { 0, 1, 6 },
                    { 2, 3, 7 } 
                },
                {   { 4, 5, 8 },
                    { 9, 10, 11 } 
                }
            };

            Console.WriteLine("First element: " + arr3D[0, 0, 0] + " Rank: " + arr3D.Rank);


            ////foreach does not work for multidimensional arrays 
            //foreach(dynamic i in arr2D)
            //{
            //    foreach(dynamic j in i)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //var is the same as auto in c++

            //how does THIS WORK ???

            
            foreach(var i in arr3D) 
            {
                Console.WriteLine(i);
            }
            
            //wHAT? HOW?
            foreach (dynamic i in arr3D)
            {
                Console.WriteLine(i);
            }

            //ooo apparently it goes from the top left to bottom right 
            //what kinda vood00 shit 

            /*
             * VAR
             * The type of the variable is decided by the compiler at compile time
             * The variable of this type should be initialized at the time of declaration. So that the compiler will decide the type of the variable according to the value it initialized.
             * 
             * DYNAMIC
             * The type of the variable is decided by the compiler at run time.
             * The variable of this type need not be initialized at the time of declaration. Because the compiler does not know the type of the variable at compile time
             * 
             */

            //GetLength(dimension)
            for(int i = 0; i < arr3D.GetLength(0); i++)
            {
                //outer loop
                for(int j = 0; j < arr3D.GetLength(1); j++)
                {
                    //rows 
                    for(int k = 0; k < arr3D.GetLength(2); k++)
                    {
                        //columns 
                        arr3D[i, j, k] += 10;
                        Console.WriteLine($"{i}, {j}, {k}, {arr3D[i, j, k]}");
                    }
                }
            }

            int[,] arr2D = new int[,]
            {
                {1, 2, 3 },
                { 4, 5, 6 },
                {7, 8, 9 }
            };

            for(int i = 0; i < arr2D.GetLength(0); i++)
            {
                Console.WriteLine(arr2D[i, arr2D.GetLength(0)-i-1]);
            }

        }
    }
}
