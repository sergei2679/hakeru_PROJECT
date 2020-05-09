using System;
using System.Threading;

namespace H_Threads_Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

            Thread evenThread = new Thread(Even);
            Thread oddThread = new Thread(Odd);

            //oddThread.Start(arr);

            oddThread.Start(); // start can be empty and can get 1 parameter object
            evenThread.Start();

            oddThread.Join();
            evenThread.Join();

            Console.WriteLine("\nPrinting done!!!");

            // ---------------------------------------------------


            Console.ReadLine();
        }

        //static void Odd(object arr)
        //{
        //    int toIndex = 5;
        //    int[] array = (int[])arr;

        //    for (int i = 0; i < toIndex; i++)
        //    {
        //        //if (arr[i] % 2 == 0)
        //            Console.WriteLine("found odd {0}", array[i]);
        //        Thread.Sleep(1000);

        //    }
        //}

        //static void Even(object arr)
        //{
        //    int fromIndex = 5;
        //    int[] array = (int[])arr;

        //    for (int i = fromIndex; i < array.Length; i++)
        //    {
        //        //if (arr[i] % 2 != 0)
        //            Console.WriteLine("found even {0}", array[i]);
        //        Thread.Sleep(1000);
        //    }
        //}


        //-----------------------------------------------------------------------------

        static void Odd()
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("found odd {0}", i);
                Thread.Sleep(1000);

            }
        }

        static void Even()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("found even {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}
