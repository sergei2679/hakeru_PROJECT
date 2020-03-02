using System;

namespace Lesson_20200301_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n1 = new Node(200);
            //Node n2 = new Node(900);
            //Node n3 = new Node(400);
            //Node n4 = new Node(100);

            //n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;

            //Console.WriteLine("max = " + Node.GetMax(n1));
            //Console.WriteLine("min = " + Node.GetMin(n1));

            //Console.WriteLine("sum = " + Node.GetSum(n1));
            //Console.WriteLine("count = " + Node.GetCount(n1));
            //Console.WriteLine("if duplicated = " + Node.IsDuplicated(n1));

           

            LinkedList list = new LinkedList();

            list.Add(23);
            list.Add(2);
            list.Add(103);
            list.Add(123);

            Console.WriteLine(list.ToString());

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Count : " + list.Count());

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Sum : " + list.Sum());

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("IndexOf 103 : " + list.IndexOf(103));

            Console.WriteLine("--------------------------------------");

            //Console.WriteLine("To Array : " + list.ToArray());


            Console.ReadLine();
        }

        

    }
}
