using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Delegates
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);
        internal class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }



        }
        static void Main(string[] args)
        {
            //Delegates 
            // A delegate is a type
            // that represents references to methods
            // with a particular parameter list and return type.
            // When you instantiate a delegate,
            // you can associate its instance with any method
            // with a compatible signature and return type.
            // You can invoke (or call) the method through the delegate instance.


            Person p1 = new Person("Sne", 22);
            Person p2 = new Person("Slok", 23);
            Person p3 = new Person("DotDot", 1);

            List<Person> people = new List<Person>() { p1, p2, p3 };

            ExistingDelegates();
            OwnDelagates();
            AnonymousFunctions(people);
            Events();

        }

        static void ExistingDelegates()
        {
            List<string> names = new List<string>() { "Sneh", "Slok" };
            Console.WriteLine("Original");
            Display(names);
            names.RemoveAll(Filter);
            Console.WriteLine("After");
            Display(names);
        }

        static void Display(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        static bool Filter(string s)
        {
            return s.Contains("n");
        }

        static void OwnDelagates()
        {
            Person p1 = new Person("Sne", 22);
            Person p2 = new Person("Slok", 23);
            Person p3 = new Person("DotDot", 1);

            List<Person> people = new List<Person>() { p1, p2, p3 };
            List<FilterDelegate> filters = new List<FilterDelegate>() { isNotMinor, isFamily, lovesBooks };
            DisplayPeople("Family grown ups who love books", people, filters);

            Console.WriteLine();

        }

        static void DisplayPeople(string title, List<Person> people, List<FilterDelegate> filters)
        {
            bool temp = true;
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                foreach (FilterDelegate filter in filters)
                {
                    //Console.WriteLine($"{filter} returned {filter(person)}");
                    if (filter(person))
                    {
                        //Console.WriteLine(temp + " " + filter(person));
                        temp = temp && filter(person);
                        //Console.WriteLine(temp);
                    }
                    else
                    {
                        temp = false;
                    }
                }
                if (temp)
                {
                    Console.WriteLine(person.Name + " satisfies all conditions ");
                }
            }
        }

        static bool isNotMinor(Person p)
        {
            return p.Age > 18;
        }

        static bool lovesBooks(Person p)
        {
            if (p.Name.Contains("Dot"))
                return false;
            return true;
        }

        static bool isFamily(Person p)
        {
            string[] family = new string[] { "Sne", "Slok", "DotDot" };
            return family.Contains(p.Name);
        }

        static public void AnonymousFunctions(List<Person> people)
        {
            // Anonymous functions can be made by the delegate keyword
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            // here, we're just assigning a delegate an unnamed function
            List<FilterDelegate> temp = new List<FilterDelegate>();
            temp.Add(filter);
            DisplayPeople("Non minors", people, temp);
            Console.WriteLine();
            DisplayPeople("Smort", people, new List<FilterDelegate>() { delegate (Person p) { return true; } });
        }

        static public void LambdaFunctions(List<Person> people)
        {
            // another way to create anonymous methods
            DisplayPeople("People with A in their names: ", people, new List<FilterDelegate>() { (p) => { return p.Name.Contains("A"); } });
            DisplayPeople("22 year olds: ", people, new List<FilterDelegate>() { (p) => p.Age == 22 });

        }

        static public void Events()
        {

        }

        

        
    }
}