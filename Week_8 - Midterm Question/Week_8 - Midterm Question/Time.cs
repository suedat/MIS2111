namespace Questions;

internal class Time
{
    private int hour;
    private int minute;

    public Time()
    {
        this.hour = 0;
        this.minute = 0;
    }

    public Time(int hour, Months month, int minute)
    {
        if (hour < 0)
        {
            this.hour = 0;
        }
        else if (hour > 24)
        {
            this.hour = 24;
        }
        else
        {
            this.hour = hour;
        }

        if (minute < 0)
        {
            this.minute = 0;
        }
        else if (minute > 60)
        {
            this.hour = 60;
        }
        else
        {
            this.minute = minute;
        }
    }

        public int getHour()
        {
            return this.hour;
        }

        public int getMinute()
        {
            return this.minute;
        }

        public int diff()
        {
            return (this.hour * 60) + this.minute;
        }
    }
