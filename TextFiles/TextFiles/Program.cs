using System.Text;
using System.IO;

namespace TextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Text files: Reading: ");

            string text = System.IO.File.ReadAllText(@"D:\C#\TextFiles\Assets\TextFile.txt");

            Console.WriteLine($"Text file contains the following text:\n{text}");

            string[] lines = System.IO.File.ReadAllLines(@"D:\C#\TextFiles\Assets\TextFile.txt");
            int num = 0;
            foreach(string line in lines)
            {
                Console.WriteLine($"Line {num++} : {line}");
            }

            Console.WriteLine("Writing:");

            string[] linesToBeWritten = { 
                "in the middle of the night", 
                "we danced around the kitchen", 
                "in the refrigerator light", "down the stairs", 
                "you were there", 
                "you remember it all toooo welllll!",
                "ye thats it."
            };

            
            // method 1
            //File.AppendAllLines(path, lines);
            File.AppendAllLines("D:\\C#\\TextFiles\\Assets\\TextFile.txt", linesToBeWritten);

            string fileName, input;
            Console.WriteLine("Please enter name of the file to be written into");
            fileName = Console.ReadLine();
            Console.WriteLine("Enter the text");
            input = Console.ReadLine();

            //method 2
            File.WriteAllText(@"D:\C#\TextFiles\Assets\" + fileName + ".txt", input);

            //method 3
            string[] lines_s = { "Hey there. I am the third", "master of the third", "temple. It is the second biggest", "temple located in the third presinct" };
            using(StreamWriter file = new StreamWriter(@"D:\C#\TextFiles\Assets\TextFileNew.txt")) { 
                foreach(string line in lines_s)
                {
                    if (line.Contains("Third") || line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}