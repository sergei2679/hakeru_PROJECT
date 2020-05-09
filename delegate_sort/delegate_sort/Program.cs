using System;

namespace delegate_sort
{
    public delegate int CompareDeleg(int a, int b);
    public delegate string CompareDeleg1(int a, int b);
    class Program
    {
        static int[] arr;

        //מיון עולה
        static int CompareAsc(int x, int y)
        {
            return x - y;
        }

        //מיון יורד
        static int CompareDesc(int x, int y)
        {
            return y - x;
        }

        static void Sort(CompareDeleg compareMethod)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (compareMethod(arr[i], arr[j]) > 0)
                        Swap(i, j);
        }

        static void PrintArray()
        {
            Console.Write("{");

            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            if (arr.Length > arr.Length-1)
            {
                Console.Write(arr[arr.Length - 1]);
            }
           
            Console.WriteLine("}");
        }

        private static void Swap(int i, int j) 
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void Main(string[] args)
        {
            arr = new int[] { 123, 200, -63, 2, 7612, -13, 8 };
            Console.WriteLine("Original numbers");
            PrintArray();

            Sort(new CompareDeleg(CompareAsc));
            Console.WriteLine("\nAscending order");
            PrintArray();

            Sort(new CompareDeleg(CompareDesc));
            Console.WriteLine("\nDescending order");
            PrintArray();


            Console.ReadLine();
        }
    }
}
