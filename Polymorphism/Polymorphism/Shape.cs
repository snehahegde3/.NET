using System;

namespace Polymorphism
{
	internal abstract class Shape
	{
		// we cant create or instantiate objects from an abstract class
		public string Name { get; set; }
		public virtual void GetInfo()
		{
			Console.WriteLine($"\nThis is a {Name}");
		}

		
	}
}
