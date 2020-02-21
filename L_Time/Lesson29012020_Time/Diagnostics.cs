
namespace Lesson29012020_Time
{
    class Diagnostics
    {
        long totalTicks;
        const long hourTicks = 360000000000;
        const int minuteTicks = 600000000;
        const int secondTicks = 10000000;


        public Diagnostics(int ticks = 0)
        {
            totalTicks = ticks;
        }

        public long GetTotalTicks()
        {
            return totalTicks;
        }
        public int HourByTicks(int ticks)
        {
            int hour = 0;
            while (ticks > 0)
            {
                hour = ticks - 600000000;
            }

            return hour;
        }
    }
}
