
namespace Lesson29012020_Time
{
    class TimeSpan
    {
        private int interval;
        private readonly int totalTicks;
        public int fromTime;        // 205812   =    20:58:12
        private int toTime;         // 235005   =    23:50:05 

        public TimeSpan(int totalTicks, int interval = 0)
        {
            this.totalTicks = totalTicks;
            this.interval = interval;
        }

        //public string ticksFromTime(Time before)
        //{
        //    return "ticks per second : " + tiks / millisecond + "\n ticks per minute : " + tiks / second + "\n ticks per hour : " + tiks / minute;
        //}

        public void SetInterval(int interval)
        {
            this.interval = interval;
        }
        public int GetInterval()
        {
            return interval;
        }

        //public int TotalTicks()
        //{
        //    return totalTicks;
        //}
    }
}
