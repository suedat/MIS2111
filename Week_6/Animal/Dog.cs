using System;
namespace Week_6
{
	public class Dog : Animal
	{
		public Dog()
		{
			Console.WriteLine("Dog class inrantiated");
		}

		public void Bark()
		{
			Console.WriteLine("Woof Woof");
		}

		public void Run()
		{
			Console.WriteLine("Dog is running");
		}

		/*new public void Eat()
		{
			Console.WriteLine("Dog is eating");
		}*/

		public override void Eat() 
		{
			Console.WriteLine("Dog is eating");
		}
	}

}