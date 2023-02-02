using System;

namespace Polymorphism
{
	internal abstract class Shape
	{
		// we cant create or instantiate objects from an abstract class
		public string Name { get; set; }

		public Shape(string name)
		{
			Name = name;
		}
		public virtual void GetInfo()
		{
			Console.WriteLine($"\nThis is a {Name}");
		}

		//abstract method 
		public abstract double Volume(); 
		
	}
}
