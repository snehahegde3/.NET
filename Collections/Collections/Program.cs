using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Collections
{
    internal class Program
    {
        //each collection is a class
        static void Main(string[] args)
        {
            ArrayLists();
            Lists();
            HashTables();
            Dictionaries();
            Stack();
            Queue();
            Console.ReadKey();
        }

        class Point
        {
            public int x { get; set; }
            public int y { get; set; }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Point GetPoint()
            {
                return new Point(x, y);
            }

        }

        class Student
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public int marks { get; set; }

            public Student(int ID, string Name, int marks)
            {
                this.ID = ID;
                this.Name = Name;
                this.marks = marks;
            }


        }

        class Employee
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }
            
            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;

                }
            }

            public Employee(string role, string name, int age, float rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = rate;
            }
        }

        class Order
        {
            public int ID { get; set; }
            public long Amount { get; set; }

            public Order(int id, long amount)
            {
                this.ID=id;
                this.Amount = amount;
            }
        }

        public static void ArraylistDisplay(ArrayList arrlist)
        {
            foreach (var i in arrlist)
            {
                
                if (i is System.Int32[])
                {
                    //the object is of the type System.Int32[]

                    //convert it into an enumerable to use foreach
                    IEnumerable arr = i as IEnumerable;
                    foreach (int j in arr)
                    {
                        Console.Write(j + " ");
                    };
                }
                else if (i is System.String[]) {
                    IEnumerable str = i as IEnumerable;
                    foreach (string j in str)
                    {
                        Console.Write(j + " ");
                    }
                }
                else {
                    Console.Write(i + " ");
                }


            }
            Console.WriteLine();
        }
        public static void ArrayLists()
        {
            //Non-Generic
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(10);
            arrayList1.Add(10);
            arrayList1.Add(65.6);
            arrayList1.Add("Hello");
            int[] arr = new int[] { 1, 2, 4 };
            string[] strArr = new string[] { "sne", "hegde" };
            arrayList1.Add(arr);
            arrayList1.Add(strArr);
            ArraylistDisplay(arrayList1);


            //removes the first 10 from the arraylist
            arrayList1.Remove(10);
            ArraylistDisplay(arrayList1);

            //removes the element at the specified index
            arrayList1.RemoveAt(0);
            ArraylistDisplay(arrayList1);

            arrayList1.Insert(1, 100);
            ArraylistDisplay(arrayList1);


        }

        public static void Lists()
        {
            //Generic collection
            List<int> newList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45 };
            newList.Add(50);
            newList.Remove(50);
            List<int> smolList = new List<int> { 1, 2, 3, 5 };
            newList.AddRange(smolList);
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
            newList.RemoveAt(1);
            Console.WriteLine();
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }

            List<Point> points = new List<Point>();
            Point p1 = new Point(1, 2), p2 = new Point(3, 4), p3 = new Point(5, 6); 

            Console.WriteLine();


        }

        

        public static void HashTables()
        {
            //key - value
            //Non-Generic
            Hashtable students = new Hashtable(); 
            Student[] studentArray = new Student[] { new Student(1, "sne", 91), new Student(2, "Slok", 87) };
            foreach (Student s in studentArray)
            {
                if (!students.ContainsKey(s.ID))
                {
                    students.Add(s.ID, s);
                }

            }
            //accessed by entry.Key and .Value
            foreach(DictionaryEntry entry in students)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine(temp.ID + " " +temp.Name + " " + temp.marks);
            }

            //a simplified version of this is 
            foreach(Student temp in students.Values)
            {
                Console.WriteLine(temp.ID + " " + temp.Name + " " + temp.marks);
            }

            string? new_str = null;
        }
        public static void Dictionaries()
        {
            // key - value
            //Generic 
            Employee[] employees =
            {
                new Employee("CTO", "Sneha", 22, 500),
                new Employee("CEO", "Shlok", 24, 550),
                new Employee("Chairkat", "DotDot", 2, 200),
            };
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach(Employee employee in employees)
            {
                employeeDictionary.Add(employee.Role, employee);
            }


            foreach(var i in employeeDictionary)
            {
                Console.WriteLine($"{i.Value.Rate}, {i.Key}, {i.Value.Name}");
            }


            Employee CEO = null;
            //TryGetValue checks if there is a value, returns a bool like TryParse
            if(employeeDictionary.TryGetValue("CTO", out CEO))
            {
                Console.WriteLine("CEO found" + " " + CEO.Name);
            }
            else
            {
                Console.WriteLine("were in need of a CEO. Please apply");
            }

            //can use ElementAt when using a for loop 


            KeyValuePair<string, Employee> entryCTO = employeeDictionary.ElementAt(1);
            //2nd element in the dictionary that is a key-value pair


            //Remove returns a boolean whether it was successful or not
            employeeDictionary.Remove(entryCTO.Key);

            foreach (var i in employeeDictionary)
            {
                Console.WriteLine($"{i.Value.Rate}, {i.Key}, {i.Value.Name}");
            }

            Console.WriteLine();
        }

        public static void Stack()
        {
            //LIFO

            //web browser back button 
            //reversing data
            //undo/redo 

            //Push(Object), Object Pop(), Object Peek() //(only top)

            //Generic

            Stack<int> stak = new Stack<int>();

            stak.Push(1);
            stak.Push(2); 
            stak.Push(3);   
            Console.WriteLine(stak.Peek()); 
            foreach(int i in stak)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); 
            if (stak.Count > 0)
            {
                int temp = stak.Pop();
                Console.Write(temp + " ");
            }
            Console.WriteLine();

            foreach (int i in stak)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            while(stak.Count > 0)
            {
                stak.Pop();
            }
            Console.WriteLine(stak.Count);

            reverse();

            static void reverse()
            {
                int[] new_arr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Stack<int> stack = new Stack<int>();
                foreach(var i in new_arr)
                {
                    stack.Push(i);
                }

                while(stack.Count>0)
                {
                    Console.Write($"{stack.Pop()} ");
                }

                Console.WriteLine();

            } 
        }



        public static void Queue()
        {
            //FIFO

            //IO requests
            //Web requests
            //Video games 

            //Enqueue(Object), Object Dequeue(), Object Peek()

            //Generic

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach(var i in queue)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine(queue.Dequeue());
            queue.Dequeue();

            foreach(var i in queue)
            {
                Console.WriteLine(i + " " + queue.Count + " ");
            }

            Console.WriteLine();


            var new_q = RecievedOrders();
            foreach(var i in new_q)
            {
                Console.WriteLine($"{i.ID}, {i.Amount}");
            }

            static Queue<Order> RecievedOrders()
            {
                Queue<Order> order_q = new Queue<Order>();
                order_q.Enqueue(new Order(1, 10));
                order_q.Enqueue(new Order(2, 20));
                order_q.Enqueue(new Order(3, 20));
                return order_q;
            }
            

        }
    }


    
}
