using System;
using home_20200402_Collection_Queue.Model;


namespace home_20200402_Collection_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------

            //input values
            int[] queueItems = new int[] { 1, 2, 3, 4, 5 };

            //LinkedList<T> linkedList = new LinkedList<int>(Values);
            //------------------------------------------------------------


            var eazyQueue = new EazyQueue<int>();

            Console.WriteLine("\n===================== Enqueue =============");

            for (int i = 0; i < queueItems.Length; i++)
            {
                eazyQueue.Enqueue(queueItems[i]);
                Console.WriteLine("item" + (i + 1) + ": " + queueItems[i]);
            }

            int count=eazyQueue.Count;
            Console.WriteLine("\n  origin queue count: " + count);

            //-------------------------------------------------------------------------------------



            Console.WriteLine("\n\n==================== Dequeue ===========");         

            Console.WriteLine(eazyQueue.Dequeue());  // remove/dequeue 1
            Console.WriteLine(eazyQueue.Dequeue());  //       /dequeue 2 
            Console.WriteLine(eazyQueue.Dequeue());  //       /dequeue 3

            Console.WriteLine("peek {0}", eazyQueue.Peek());        //see 4
            Console.WriteLine(eazyQueue.Dequeue());           //dequeue 4

            Console.WriteLine("peek {0}", eazyQueue.Peek());        //see 5
            //Console.WriteLine(eazyQueue.Dequeue());

           ;
            Console.WriteLine("\n  after dequeue count: " + eazyQueue.Count);


            Console.ReadLine();

            //--------------------------------------------------------------------------------------

            //Stack<int> stack = new Stack<int>();

            //HashSet<int> hashSet = new HashSet<int>();

            //--------------------------------------------------------------

            //Console.WriteLine("\nItems after Dequeue {0}", countAfterDequeue);

            Console.ReadLine();
        }

    }
}
