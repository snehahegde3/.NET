using System.Security.Authentication;

namespace CmdLinePeoject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Provide an argument");
                Console.ReadKey(); 
                return;
            }

            if (args[0] == "help")
            {
                Console.WriteLine("***************** Instructions: ");
                Console.WriteLine("* use one of the following commands followed by 2 numbers *");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to subtract 2 numbers*");

                Console.ReadKey();
                return;
            }

            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please follow the instructions");
                Console.ReadKey();
                return; 
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2); 

            if(!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please follow the instructions");
            }

            float result;
            switch (args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}");
                    break;
                case "sub": 
                    result = Math.Abs(num2- num1);
                    Console.WriteLine($"The difference of {num1} and {num2} is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid arguments, please follow instructions");
                    break;
            }
        }
    }
}