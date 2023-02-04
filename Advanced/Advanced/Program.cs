using System.Globalization;
using System;
using System.Text.RegularExpressions;

namespace Advanced
{
    internal class Program
    {
        struct Game : IEquatable<Game>
        {
            // these can have access modeifiers too 
            public string name;
            public string developer;
            public string releaseDate;
            public double rating; 

            public bool Equals(Game g)
            {
                return name.Equals(g.name) && developer.Equals(g.developer);
            }

            public string Print()
            {
                return $"{name} by {developer} is going to be released on {releaseDate}";
            }

            public Game(string name, string developer)
            {
                this.name = name;
                this.developer = developer;
                this.releaseDate = DateTime.Now.ToString();
                this.rating = 0;
            }

        }

        //Enums are immutable
        enum Day { Mo, Ty, We, Th, Fr, Sa, Su};
        // these are all the possible values the enum called Day can take

        enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};
        static void Main(string[] args)
        {
            Structs();
            Enums();
            Maths();
            Randoms();
            RegularExpressions();
            RegExAssignment();
            Console.ReadKey();
        }

        static void Structs()
        {

            Game game1;
            game1.name = "Monster cake maker";
            game1.developer = "Sne";
            game1.rating = 5;
            game1.releaseDate = "04/02/2023";
            Console.WriteLine(game1.Print());

            Game game2 = new Game("Stick it up your nose", "slok");
            game2.Print();

            Console.WriteLine();
        }

        static public void Enums()
        {
            Day fr = Day.Fr;
            Day birthday = Day.Fr;
            Console.WriteLine(birthday == fr);
            Console.WriteLine("Enums friday is no " + (int)Day.Fr);

            Console.WriteLine();
        }

        static public void Maths()
        {
            Console.WriteLine("Ceiling : " + Math.Ceiling(16.2));
            Console.WriteLine($"Lower of the two numbers is {Math.Min(13, 14)}");

            Console.WriteLine();
        }

        static public void Randoms()
        {
            Random dice = new Random();

            //random contains .Next functions 
            //.Next returns a randome integer, min and max can be specified 

            int tempRandom;
            for(int i = 0; i < 10; i++)
            {
                tempRandom = dice.Next(1, 7);
                Console.WriteLine(tempRandom);
            }

            int fortuneNumber;
            string fortune; 
            for(int i = 0; i < 5; i++)
            {
                fortuneNumber = dice.Next(1, 4);
                fortune = fortuneNumber == 1 ? "Yes" : fortuneNumber == 2 ? "Maybe" : "No";
                Console.WriteLine(fortune);
            }

            Console.WriteLine(); 

        }

        static public void RegularExpressions()
        {
            string pattern = @"\d";
            Regex regx = new Regex(pattern);

            string text = "My number is 34534543";

            MatchCollection matchCollection = Regex.Matches(text, pattern);
            Console.WriteLine($"{matchCollection.Count} matches found");


            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at  {group[0].Index}");
            }

            Console.WriteLine();
        }
        
        static public void RegExAssignment()
        {
            string pattern = @"\d{2,3}";
            string text = File.ReadAllText(@"D:\C#\Advanced\input2.txt");

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);


            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                string matchedString = group[0].Value;
                int matchedInt = Int32.Parse(matchedString);
                char matchedChar = (char)matchedInt;
                Console.Write(matchedChar);
            }


        }

        static public void DatesTimes()
        {

        }

    }
}