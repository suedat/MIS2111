using System;
namespace Week_4
{
	public class Color
	{
        public int red;
        public int green;
        public int blue;

        public Color()
        {
            this.red = 130;
            this.green = 130;
            this.blue = 130;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public Color(int red)
        {
            this.red = red;
            this.green = 0;
            this.blue = 0;
        }
    }
}

