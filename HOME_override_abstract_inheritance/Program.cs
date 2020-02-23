using System;

namespace HOME_override_abstract_inheritance
{
    class Program
    {
        public static void Main()       //  public class for every
        {
            // BaseEmployee b;         //  use like pointer
            FullTimeEmployee f1 = new FullTimeEmployee(100, "fulltime100", "time", 57000);
            FullTimeEmployee f2 = new FullTimeEmployee(123, "fulltime123", "time", 70000);
                                                   
            Console.WriteLine("Full Time Employee1 Salary = " + f1.GetMonthlySalary());
            Console.WriteLine("Full Time Employee2 Salary = " + f2.GetMonthlySalary());


            ContractEmployee c = new ContractEmployee(105, "contract", "cont", 80, 300);

            Console.WriteLine("Contract Employee Salary = " + c.GetMonthlySalary());


            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Contract Employee Salary = " + c.GetMonthlySalary());

            
            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}
