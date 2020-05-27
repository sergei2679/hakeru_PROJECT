using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace h20200517_Files_Homework
{
    public static class FileManager
    {
        //public static readonly FileInfo file = new FileInfo(@"C:\Users\Elad\Desktop\myfile.txt");
        public static readonly FileInfo fileDat = new FileInfo(@"C:\Test\myFile.dat");


        //writing a string to a file
        public static void Example1()
        {
            string s = "hello";
            s.Write(fileDat);
            Console.WriteLine("file written successfully");
        }


        //writing an integer to a file
        public static void Example3()
        {
            int x = 1234;
            byte[] xBytes = BitConverter.GetBytes(x);
            using (Stream stream = fileDat.OpenWrite())
            {
                stream.Write(xBytes, 0, xBytes.Length);
            }
            Console.WriteLine("integer written succesfully.");
        }


        //reading an integer from a file
        public static void Example4()
        {
            byte[] xBytes = new byte[4];
            using (Stream stream = fileDat.OpenRead())
            {
                int actuallyRead = stream.Read(xBytes, 0, 4);
                if (actuallyRead != 4)
                    throw new Exception("I expected four bytes but found only " + actuallyRead + " bytes.");
            }
            int x = BitConverter.ToInt32(xBytes, 0);
            Console.WriteLine("x: " + x);
        }

        //writing an array of strings to a file
        public static void Example5()
        {
            string[] arr = {
                "sunday",
                "monday",
                "tuesday",
                "wednesday",
                "thursday",
                "friday",
                "saturday"
            };
           
            //assume strings in the array are no longer than 255.
            using (Stream stream = fileDat.OpenWrite())
            {
                foreach (string s in arr)
                {
                    byte[] sBytes = ASCIIEncoding.UTF8.GetBytes(s);
                    stream.WriteByte((byte)sBytes.Length);
                    stream.Write(sBytes, 0, sBytes.Length);
                }
            }
            Console.WriteLine("string array written succesfully");
        }


        //reading an array of strings from a file
        public static void Example6()
        {
            byte[] buffer = new byte[256];
            List<string> stringsFromFile = new List<string>();
            int stringLength;
            int actuallyRead;
            using (Stream stream = fileDat.OpenRead())
            {
                while ((stringLength = stream.ReadByte()) != -1)
                {
                    actuallyRead = stream.Read(buffer, 0, stringLength);
                    string s = ASCIIEncoding.UTF8.GetString(buffer, 0, stringLength);
                    if (actuallyRead != stringLength)
                        throw new Exception("expected " + stringLength + " bytes but found..");
                    stringsFromFile.Add(s);
                }
            }
            stringsFromFile.ForEach((s) => Console.WriteLine(s));
        }

        //writing an array of integers to a file
        public static void Example7()
        {
            int[] arr = new int[100];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            using (Stream stream = fileDat.OpenWrite())
            {
                byte[] xBytes;
                for (int i = 0; i < arr.Length; i++)
                {
                    xBytes = BitConverter.GetBytes(arr[i]);
                    stream.Write(xBytes, 0, 4);
                }
            }
            Console.WriteLine("array of integers written successfully.");
        }


        //reading an array of integers from a file
        public static void Example8()
        {
            List<int> integersFromFile = new List<int>();
            using (Stream stream = fileDat.OpenRead())
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

       
        //Appending data to existing file.
        public static void Example14()
        {
            if (fileDat.Exists)
                fileDat.Delete();

            using (Stream stream = fileDat.OpenWrite())
            {
                string s1 = "hello";
                stream.Write(s1.GetBytes());

            }
            using (Stream stream = fileDat.Open(FileMode.Append))
            {
                string s2 = " world";
                stream.Write(s2.GetBytes());
            }
            
        }

    }
}
