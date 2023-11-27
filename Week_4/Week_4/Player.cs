using System;
using Week_4.Enum;
namespace Week_4
{
	public class Player
	{
		public string name;
		public int id;
		//public int level; //level can have 3 values 1,2,3
		public Level level;
		public Player()
		{
			this.name = string.Empty;
			this.id = default(int);
			//this.level = 1;
			this.level = Level.Level1;
		}

		public Player(string name, int id, Level level)
		{
			this.name = name;
			this.id = id;
			//this.level = level;
			this.level = level;
		}

		public void Report()
		{
			Console.WriteLine($"Player name: {this.name}");
            Console.WriteLine($"Player ID: {this.id}");
            //Console.WriteLine($"Player Level: {this.level}");
            Console.WriteLine($"Player level is: {this.level}");
        }
	}
}

