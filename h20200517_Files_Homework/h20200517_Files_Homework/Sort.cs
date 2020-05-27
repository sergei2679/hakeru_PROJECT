using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace h20200517_Files_Homework
{
    public static class Sort
    {
        //private static readonly FileInfo sourceFile1 = new FileInfo(@"C:\Test\‏‏source1.txt");
        //private static readonly FileInfo sourceFile2 = new FileInfo(@"C:\Test\‏‏source2.txt");
        //private static readonly FileInfo file = new FileInfo(@"C:\Test\‏‏destination.txt");

        public static IEnumerable<int> ReadIntegers(string file)
        {
            using (var stream = File.OpenText(file))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    yield return int.Parse(line);
                }
            }
        }

        public static IEnumerable<int> UnionSorted(IEnumerable<int> first, IEnumerable<int> second)
        {
            var it1 = first.GetEnumerator();
            var it2 = second.GetEnumerator();

            bool it1HasNext = it1.MoveNext();
            bool it2HasNext = it2.MoveNext();
            while (it1HasNext && it2HasNext)
            {
                if (it1.Current > it2.Current)
                {
                    yield return it2.Current;
                    it2HasNext = it2.MoveNext();
                }
                else
                {
                    yield return it1.Current;
                    it1HasNext = it1.MoveNext();
                }
            }

            while (it1.MoveNext())
            {
                yield return it1.Current;
            }


            while (it2.MoveNext())
            {
                yield return it2.Current;
            }
        }

        //public static void MergeFiles(string file1, string file2, string ouputFile)
        //{
        //    var merged = UnionSorted(ReadIntegers(file1), ReadIntegers(file2));
        //    using (var writer = File.AppendText(ouputFile))
        //    {
        //        foreach (var number in merged)
        //        {
        //            writer.WriteLine(number);
        //        }
        //    }
        //}

        public static void Print(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
           
            using (FileStream stream = fileInfo.OpenRead())
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
}
