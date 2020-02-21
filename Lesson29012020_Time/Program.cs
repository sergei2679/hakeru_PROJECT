using System;

namespace Lesson29012020_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("====== System Object DateTime Now ========================");
            //Time copyTime = new Time(DateTime.Now);
            //Console.WriteLine(copyTime.Hour + ":" + copyTime.Minute + ":" + copyTime.Second);

            Time t1 = new Time(23, 59, 59, 5);
            Time t2 = t1;                         // 2 pointers to object Time

            Console.WriteLine("====== Current Time T1 ========================\n");   // constructor getting parameters // hour,minute,second
            Console.WriteLine(t1.toString());

            //Console.WriteLine("====== Is Equal T1 and T2 ========================");
            //Console.WriteLine("is T1 equal T2 ?  : " t1.Equals(t2));

            Console.WriteLine("====== TIKS COUNT PER HOUR ======== :: " + t2.TiksPerHour() + " ================");
            Console.WriteLine(
                                "\n Hours : " + t2.GetHour() +
                                "\n Minutes : " + t2.GetMinute() +
                                "\n Seconds : " + t2.GetSecond() +
                                "\n Millisecond : " + t2.GetMillisecond());

            // -------------------------------------------------------------
            Diagnostics d = new Diagnostics();
            
            Console.WriteLine("hour by ticks  " + d.HourByTicks(600000000));



            Console.ReadLine();

        }
    }
}
