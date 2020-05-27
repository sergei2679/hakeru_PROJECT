using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace h20200517_Files_Homework
{
    class Homework
    {
        public static readonly FileInfo file = new FileInfo(@"C:\Test\myFile.dat");

        // סעיף 1
        public static void WriteRandom()
        {
            if (file.Exists)
                file.Delete();

            Random random = new Random();

            using (Stream stream = file.OpenWrite())
            {
                for (int i = 0; i < 10; i++)           //  10 iteration = 10 integers
                {
                    //int x = random.Next();          // range from minValue(-2147483648) to maxValue(2147483647) integer
                    int x = random.Next(1, 250);      //  range from 1 to 250 integer randomaly
                    byte[] xBytes = BitConverter.GetBytes(x);
                    stream.Write(xBytes, 0, 4);
                }
            }
            Console.WriteLine("Writing done succesfully");
        }

        // סעיף 2
        public static void ReadMax()
        {
            int max = int.MinValue;
            using (Stream stream = file.OpenRead())      // Stream is abstract class
            {
                byte[] xBytes = new byte[4];
                int actuallyRead;

                while ((actuallyRead = stream.Read(xBytes, 0, 4)) == 4)
                {
                    int x = BitConverter.ToInt32(xBytes);
                    if (x > max)
                        max = x;
                }
            }
            Console.WriteLine("max is: " + max);
        }

        public static void ReadMin()
        {
            int min = int.MaxValue;
            using (Stream stream = file.OpenRead())
            {
                byte[] xBytes = new byte[4];
                int actuallyRead;

                while ((actuallyRead = stream.Read(xBytes, 0, 4)) == 4)
                {
                    int x = BitConverter.ToInt32(xBytes);
                    if (x < min)
                        min = x;
                }
            }
            Console.WriteLine("min is: " + min);
        }


        //reading an array of integers from a file
        public static void ReadArrayIntegers()
        {
            List<int> integersFromFile = new List<int>();
            using (Stream stream = file.OpenRead())      // Stream is abstract class
            {
                byte[] xBytes = new byte[4];
                while ((stream.Read(xBytes, 0, 4)) == 4)
                {
                    int x = BitConverter.ToInt32(xBytes, 0);
                    integersFromFile.Add(x);
                }
            }
            integersFromFile.ForEach((x) => Console.WriteLine(x));
        }


        // Appending ineger to a file
        public static void AppendIneger(int x)
        {
            byte[] xBytes = BitConverter.GetBytes(x);

            using (Stream stream = file.Open(FileMode.Append))
            {
                stream.Write(xBytes);
            }
        }

        //Count duplicated integers         // סעיף 3
        public static int CountDuplicated(int x)
        {
            int count = 0;

            using (Stream stream = file.OpenRead())      // Stream is abstract class
            {
                byte[] xBytes = new byte[4];
                while ((stream.Read(xBytes, 0, 4)) == 4)
                {
                    if (x == BitConverter.ToInt32(xBytes, 0))
                        count++;
                }
            }
            return count;
        }

        // סעיף 4
        public static int CountEven()
        {
            int count = 0;
            using (Stream stream = file.OpenRead())
            {
                byte[] xBytes = new byte[4];
                while ((stream.Read(xBytes, 0, 4)) == 4)
                {
                    int x = BitConverter.ToInt32(xBytes, 0);
                    if (x % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        
        //public static int CountOdd()
        //{
        //    int count = 0;
        //    using (Stream stream = file.OpenRead())
        //    {
        //        byte[] xBytes = new byte[4];
        //        while ((stream.Read(xBytes, 0, 4)) == 4)
        //        {
        //            int x = BitConverter.ToInt32(xBytes, 0);
        //            if (x % 2 != 0)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}

        // סעיף 6
        public static bool IsSorted()
        {
            bool sorted = false;
            int current;
            int prev = int.MinValue;

            using (Stream stream = file.OpenRead())
            {
                byte[] xBytes = new byte[4];

                while ((stream.Read(xBytes, 0, 4)) == 4)
                {
                    current = BitConverter.ToInt32(xBytes, 0);

                    if (current >= prev)
                    {
                        sorted = true;
                    }
                    else
                    {
                        sorted = false;
                        break;
                    }
                    prev = current;
                }
            }
            return sorted;
        }

        // סעיף 7
        public static void WriteRandomSorted()
        {
            if (file.Exists)
                file.Delete();

            int max = int.MinValue;
            Random random = new Random();

            using (Stream stream = file.OpenWrite())
            {
                for (int i = 0; i < 20; i++)
                {
                    int x = random.Next(1, 1000);     //  range from 1 to 1000 integer randomaly

                    if (x >= max)
                    {
                        max = x;
                        byte[] xBytes = BitConverter.GetBytes(x);
                        stream.Write(xBytes, 0, 4);
                    }
                }
            }
            Console.WriteLine("Writing sorted random done succesfully");
        }

     
    }
}
