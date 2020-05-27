using System;
using System.IO;

namespace h20200517_Files_Homework
{
    class Program
    {

        static void Main(string[] args)
        {

            // סעיף 1 עד 6
            Homework.WriteRandom();
            Homework.ReadArrayIntegers();

            Homework.AppendIneger(25);
            Homework.AppendIneger(41);
            Homework.AppendIneger(15);
            Homework.AppendIneger(67);
            //Console.WriteLine("----- after append ----------");
            Homework.ReadArrayIntegers();

            Console.WriteLine("\n---- count duplicated -----");
            Console.WriteLine(Homework.CountDuplicated(25));

            Console.WriteLine("\n---- count even -----");
            Console.WriteLine(Homework.CountEven());

            //Console.WriteLine("---- count odd -----");
            //Console.WriteLine(Homework.CountOdd());

            Console.WriteLine("\n---- if sorted -----");
            Console.WriteLine(Homework.IsSorted());


            //סעיף 7
            Console.WriteLine("\n---- random sorted -----");
            Homework.WriteRandomSorted();
            Homework.ReadArrayIntegers();

            //----------------------------------------------------

            Console.WriteLine();

            Homework.ReadMax();
            Homework.ReadMin();
            

            Console.ReadLine();
        }

        
    }

}
