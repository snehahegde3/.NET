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

            Console.ReadKey();
        }
    }
}