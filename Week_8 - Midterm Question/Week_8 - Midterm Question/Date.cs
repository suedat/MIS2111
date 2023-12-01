using System;
namespace Questions
{
	internal class Date
	{
		private int year;
		private Months month;
		private int day;

		public Date(int year, Months month, int day)
		{
			if (day >= 1 && day <= 31)
			{
				this.day = day;
			}
			else
			{
				this.day = 1;
			}

			if (year >= 1980 && year <= 2030)
			{
				this.year = year;
			}
			else
			{
				this.year = 2023;
			}
			this.month = month;
		}


		public int getYear()
		{
			return year;
		}

        public Months getMonth()
        {
            return this.month;
        }
        public int getDay()
        {
            return this.day;
        }

        public int diff()
		{
			return ((this.year - 1970) * 12 * 30) + ((int)this.month - 30) + this.day;
		}
	}
}

