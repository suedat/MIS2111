using System;
namespace Week_2
{
	//All class names should start with upper case
	internal class Player
	{
        /*public float x;
		public float y;
		public float z;*/

        //public variable names start with Uppercase
        //private variables start with Lowercase

        private float x;
		private float y;
		private float z;

		public static int playerQty;
        //stored in static memory

        public Player() //Constructor
                        //Constructour name should always be the same name with class
        {
            this.x = 7.0f;
			this.y = 7.0f;
			this.z = 7.0f;
			Player.playerQty += 1;
            Console.WriteLine("Default constructor");
        }
		public Player(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 10.0f;
            Console.WriteLine("Constructor with two arguments");
        }

        public Player(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Player.playerQty += 1;
            Console.WriteLine("Constructor with three arguments");
        }
        public Player(float x, float y, float z, string message)
        {
            this.x = x;
            this.y = y;
            this.z = z;
			Player.playerQty += 1;
			Console.WriteLine("Constructor with four arguments");
			Console.WriteLine(message);
        }

        public void Report()
		{
			Console.WriteLine($"Cordinates of the player:");
            Console.WriteLine($"x: {this.x}");
            Console.WriteLine($"y: {this.y}");
            Console.WriteLine($"z: {this.z}");
        }

		public float GetX()
		{
			return this.x;
		}

        public float GetY()
        {
            return this.y;
        }

        public float GetZ()
        {
            return this.z;
        }

		public void Deconstruct(out float x, out float y, out float z)
		{
			x = this.x;
			y = this.y;
			z = this.z;
		}
 
        public static void FirstStaticMethod() //Static method
        {
            Console.WriteLine("Hello from static method");
        }

    }
}

