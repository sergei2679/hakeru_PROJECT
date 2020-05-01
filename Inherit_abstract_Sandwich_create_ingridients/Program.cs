using System;
using System.Collections.Generic;

namespace Inherit_abstract_Sandwich_create_ingridients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sandwich> sandwiches = new List<Sandwich>();

            sandwiches.Add(new TurkeySandwich());
            sandwiches.Add(new TunaSandwich());

            foreach (var sandwich in sandwiches)
            {
                Console.WriteLine("\nSandwich : " + sandwich.GetType().Name + "");
                Console.WriteLine("----------------------------------------------");

                foreach (var ingrediant in sandwich.Ingredients)
                {
                    Console.WriteLine("ingrediant: " + ingrediant.GetType().Name + "");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
