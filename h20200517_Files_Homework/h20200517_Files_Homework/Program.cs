using System;
using System.IO;

namespace h20200517_Files_Homework
{
    class Program
    {
        public static readonly FileInfo file = new FileInfo(@"C:\Test\myFile.dat");
        //private static string file1 = @"C:\Test\‏‏source1";
        //private static string file2 = @"C:\Test\‏‏source2";
        //private static FileInfo mergedFile = new FileInfo(@"C:\Test\‏‏destination.txt");

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


            //------------------------- Merge ------------------------------------

         

            Console.ReadLine();
        }

        
    }

    public static class ExtensionMethods
    {
        public static byte[] GetBytes(this string s)
        {
            return System.Text.ASCIIEncoding.UTF8.GetBytes(s);
        }
        public static void Write(this string s, FileInfo file)
        {
            byte[] sBytes = System.Text.ASCIIEncoding.UTF8.GetBytes(s);
            using (Stream stream = file.OpenWrite())
            {
                stream.Write(sBytes, 0, sBytes.Length);
            }
        }
        public static void Write(this string s, string file)
        {
            s.Write(new FileInfo(file));
        }

        public static void Print(this FileInfo fileMerged)
        {
            //FileInfo fileInfo = new FileInfo(path);

            using (Stream stream = fileMerged.OpenRead())
            {
                byte[] buffer = new byte[5];
                int actuallyRead = stream.Read(buffer, 0, buffer.Length);
                string s = System.Text.ASCIIEncoding.UTF8.GetString(buffer, 0, actuallyRead);
                Console.WriteLine(s);
                actuallyRead = stream.Read(buffer, 0, buffer.Length);
                s = System.Text.ASCIIEncoding.UTF8.GetString(buffer, 0, actuallyRead);
                Console.WriteLine(s);
                Console.WriteLine(actuallyRead);

            }
        }
    }

    //public interface IWritable
    //{
    //    public void Write(Stream stream);
    //}

}
