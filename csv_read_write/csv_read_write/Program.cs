using System;

namespace csv_read_write
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = @"C:\";
            string directory = "Test";
            string filename = "DataExport.csv";
            string filePath = root + directory + "\\" + filename;

            FileManager fm = new FileManager(filePath);
            fm.ReadWrite.Write();
            fm.ReadWrite.Read();
           


            Console.ReadLine();

        }
    }
}
