using System;
using System.Collections;
using System.Net.NetworkInformation;

namespace Loops
{
    internal class Program
    {
        //Theres a foreach loop !!! for arrays
        //runs until there is data
        static void Main(string[] args)
        {

            //While();
            //For();
            AvgProg();

            Console.ReadKey();
        }
        public static void While()
        {
            int counter = 0;
            string text = Console.ReadLine(), moreText = "";
            while(true)
            {
                Console.Write("Enter text : ");
                moreText = Console.ReadLine();
                if (moreText.Equals(""))
                {
                    Console.WriteLine("Nothing entered. Exiting ... ");
                    break;
                }
                text += moreText;
                counter++;
                Console.WriteLine($"Text is {text}, {counter} have viewed it");
            }
        }
        public static void For()
        {
            for(int i=0; i<10; i++) {
                if (i == 5)
                {
                    Console.WriteLine("midway there");
                }
                if (i == 6)
                {
                    continue;
                }
                Console.WriteLine($"Looped {i} times");

            }
        }
        public static void AvgProg()
        {
            int marks, sumMarks = 0, avgMarks = 0, count = 0;
            string strMarks;
            Console.WriteLine("Note: Enter -1 to get the final average and exit.");
            while (true)
            {
                
                Console.Write("Enter Marks : ");
                strMarks = Console.ReadLine();
                bool isInt = int.TryParse(strMarks, out marks);
                if (isInt)
                {
                   
                    if(marks == -1)
                    {
                        Console.WriteLine($"Class average is {avgMarks}. Exiting program ... ");
                        sumMarks = 0;
                        avgMarks = 0;
                        count = 0;
                        break;
                    }
                    else if(marks<0 || marks>20)
                    {
                        avgMarks = sumMarks / count;
                        Console.WriteLine($"Invalid entry. Marks should be between 0 and 20. Please try again...\n Current avg score is {avgMarks}");
                        continue;
                    }
                    
                    sumMarks += marks;
                    count++;
                    avgMarks = sumMarks/count;

                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting ... ");
                    break;
                }
            }
            
        }
    }
}
