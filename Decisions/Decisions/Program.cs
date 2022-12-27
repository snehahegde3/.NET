using System;
using System.Globalization;

namespace Decisions
{
    internal class Program
    {
        static int highScore = 0;
        static string? highScorePlayer = null;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string? new_string = Console.ReadLine();

            ////skipping if elses 


            ////TryParse(): to convert string with int to int 

            //int parsedValu; 

            //bool done = int.TryParse(new_string, out parsedValu);
            //if(done)
            //{
            //    Console.WriteLine("Parse successful. value: " + parsedValu);

            //}
            //else
            //{
            //    Console.WriteLine("Parsing failure");
            //    parsedValu = 0;
            //}


            //HighScoreGame();

            Ternary();

            Console.ReadKey();



        }

        public static void HighScoreGame()
        {
            int input = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter 1 to enter details");
                string inputStr = Console.ReadLine();
                if (int.TryParse(inputStr, out input))
                {
                    input = int.Parse(inputStr);
                    if (input == 1)
                    {
                        Console.WriteLine("Enter name: ");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter score: ");
                        string scoreStr = Console.ReadLine();
                        bool scoreInt = int.TryParse(scoreStr, out int score);
                        if (scoreInt)
                        {
                            HighScorePlayer(score, playerName);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please try again");

                        }
                    
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Exiting...");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"{highScorePlayer} wins!!! with {highScore} points");
                        Console.ForegroundColor = ConsoleColor.White;
                        input = 0;
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Exiting...");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{highScorePlayer} wins!!! with {highScore} points");
                    Console.ForegroundColor = ConsoleColor.White;
                    input = 0;
                    break;
                }
                
                Console.ReadKey();
                Console.Clear();


            } while (input == 1);
        }

        public static void HighScorePlayer(int score, string playerName)
        {
            if (score > highScore)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine($"New highscore is {highScore}");
                Console.WriteLine($"New highscore holder is {highScorePlayer}");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Old highscore is {highScore}");
                Console.WriteLine($"Old highscore holder is {highScorePlayer}");
            }

        }

        public static void Ternary()
        {
            ////ternary operators
            //string why;
            //why = "y" == "Y" ? "why" : "x" == "X" ? "ex" : "z" == "Z" ? "zee" : "wee";
            //Console.WriteLine(why);

            Console.Write("Enter measured temperature : ");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int temp))
            {
                temp = int.Parse(input);
                string output = temp <= 15 ? "It is too cold here 🥶" : temp > 16 && temp <= 28 ? "It is ok ✅" : "It is hot here 🥵";
                Console.ForegroundColor = output.Equals("it is too cold here") ? ConsoleColor.Blue : output.Equals("it is ok") ? ConsoleColor.Green : ConsoleColor.Red;
                
                Console.WriteLine(output);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Invalid input temperature");
            }



        }

        
    }
}
