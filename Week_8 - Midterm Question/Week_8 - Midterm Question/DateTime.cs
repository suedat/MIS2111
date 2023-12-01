using System;
namespace Questions
{
	internal class DateTime: Date
	{
		//DateTime is Date, DateTime has Time 

		private Time time;

        public DateTime(int year, Months month, int day, Time time) : base(year, month, day)
			//in Date things in private so we can't get them with this.  . Base do that
		{
			this.time = time;
		}

		public int Diff(DateTime other)
		{
			int minFromYears = (this.getYear() - other.getYear()) * 12 * 30 * 24 * 60;
			int minFromMonths = (this.getMonth() - other.getMonth()) * 30 * 24 * 60;
            int minFromDays = (this.getDay() - other.getDay()) * 24 * 60;
			int minFromHours = (this.time.getHour() - other.time.getHour()) * 60;
			int minFromMins = this.time.getMinute() - other.time.getMinute();

			return minFromYears + minFromMonths + minFromDays + minFromHours + minFromMins;
        }
	}
}

