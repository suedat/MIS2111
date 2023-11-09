using System;
namespace Week_6
{
	public class Bird : Animal
	{
		public Bird()
		{
			Console.WriteLine("Bird class is instantiated");
		}

		public void Tweet()
		{
			Console.WriteLine("Cik Cik");
		}

		public void Fly()
		{
			Console.WriteLine("Bird is flying");
		}
	}
}

