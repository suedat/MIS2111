using System;
namespace Week_6
{
	public class Animal
	{
		public Animal()
		{
			Console.WriteLine("Animal Class instantiated");
		}

		public void Breathe()
		{
			Console.WriteLine("Breathing");
		}

		public virtual void Eat() //only in the first definition
		{
			Console.WriteLine("Eating fast");
		}
	}
}

