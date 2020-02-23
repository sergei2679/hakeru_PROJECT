using System;

namespace HOME_virtual_override_inheritance         // Dynamic Polymorphism  must to use inheritance
{
    class Program
    {
        class University
        {
            protected int UiD;
            protected string UName;

            virtual public void Info()
            {
                Console.WriteLine("University ID = " + UiD);
                Console.WriteLine("University Name = " + UName);
            }
        }

        class Department : University       //   inheritance for overriding method
        {
            protected int DiD;
            protected string DName;
            public Department(int UiD, string UName, int DiD, string DName)
            {
                base.UiD = UiD;
                base.UName = UName;
                this.DiD = DiD;
                this.DName = DName;
            }

            override public void Info()         //  for overriding method  must to use inheritance
            {
                base.Info();
                Console.WriteLine("Department ID = " + DiD);
                Console.WriteLine("Department Name = " + DName);
            }
        }

        static void Main(string[] args)
        {
            //    אין צורך לקרוא למחלקה כי היא לבד לא מממשת כלום

            //University uni = new University();     
            //uni.Info();         
            
            // -----------------------------------------------

            //   UNIVERSITY  חייב לשלוח פרטי  DEPARTMENT כדי להתקיים בקונסטרקטור של מחלקה 
            //   UNIVERSITY תלוי ב DEPARTMENT

            Department dp = new Department(433, "Tel-Aviv university", 11, "Finances department");
            dp.Info();

            Console.ReadKey();
        }
    }
}