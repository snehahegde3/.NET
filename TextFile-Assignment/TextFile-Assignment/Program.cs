using System.Diagnostics.Tracing;
using System.IO;

namespace TextFile_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input_lines = File.ReadAllLines(@"D:\C#\TextFile-Assignment\Assets\input.txt");
            
            foreach(string line in input_lines)
            {
                if (line.Contains("split"))
                {
                    string[] words = line.Split(' ');
                    using (StreamWriter output = new StreamWriter(@"D:\C#\TextFile-Assignment\Assets\output.txt", append: true))
                    {
                        if (words.Length > 4)
                        {
                                Console.Write(words[4] + " ");
                                output.WriteLine(words[4]);

                        }

                    }
                }
                
            }

            Console.ReadKey();
                
        }
    }
}