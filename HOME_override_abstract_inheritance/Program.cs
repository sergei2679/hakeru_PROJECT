using System;

namespace HOME_override_abstract_inheritance
{
    class Program
    {
        public static void Main()       //  public class for every 
        {
            FullTimeEmployee f = new FullTimeEmployee()
            {
                ID = 123,
                Fname = "fullTime",
                Lname = "time",
                AnnualSalary = 70000
            };

            Console.WriteLine("Full Time Employee Salary = " + f.GetMonthlySalary());

            ContractEmployee c = new ContractEmployee()
            {
                ID = 105,
                Fname = "contract",
                Lname = "cont",
                HourlyPay = 80,
                TotalHoursWorked = 300
            };

            Console.WriteLine("Full Time Employee Salary = " + c.GetMonthlySalary());

            
            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}
