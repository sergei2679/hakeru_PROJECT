using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_20200402_Collection_Queue
{
    class QueueBase
    {
        protected static int _capacity;
        public QueueBase()
        {
            _capacity = 0;
        }

        //public int Count()
        //{
        //    return _capacity;
        //}

        //
        // Summary:
        //     Represents a first-in, first-out collection of objects.
        //
        // Type parameters:
        //   T:
        //     Specifies the type of elements in the queue.


        //-----------------------------------------------------------------------------
        // a Queue is a First in First Out (FIFO) collection class.

        // create new Queue to push/add (int) items. / Initializes a new instance

        // input values 
        //Queue queue = new Queue(); //  Simple Queue  / using System.Collections

        // push/add objects to end of Queue<T>    // void Queue<int>.Enqueue(int item)
           //queue.Enqueue(null);
           //queue.Enqueue(123);
            //queue.Enqueue(2);
            //queue.Enqueue(551);
            //queue.Enqueue(1244);
            //-------------------------------------------------------------------------

            // Generic Queue<T>   / 'System.Collections.Generic' namespace
            Queue<int> queueGen = new Queue<int>();

        //int[] arr = new int[4];

        //    for (int i = 0; i<arr.Length; i++)
        //    {
        //        arr[i]=queue.
        //        Console.WriteLine("\nindex: " + i +
        //                          "\nvalue: " + array[i] + 
        //                          "\nhashcode {0}", array[i].GetHashCode());
        //    }

    //------------------------------------------------------------------------------


    // Count items in queue before Dequeue()
    //int countBeforeDequeue = queue.Count;
    //Console.WriteLine("Count before Dequeue {0}", countBeforeDequeue);
            // ----------------------------------------------------------------------------


            // Dequeue method does not just return an item, 
            // it removes the item from the queue and returns it back at the beginning.
            // queue : 3 5 1 2 8 / dequeue 8 / queue 8 3 5 1 2 

            //int itemOneToDequeue = queue.Dequeue();      // int Queue<int>.Enqueue(int item)
            //Console.WriteLine("\n Dequeue item: " + itemOneToDequeue);
            //----------------------------------------------------------------------------------

            //
            //Console.WriteLine("\n instance type: {0}" + queue.GetType());

            //----------------------------------------------------------------------------------


            //int countAfterDequeue = queue.Count;
    //Console.WriteLine("\nItems after Dequeue {0}", countAfterDequeue);

    }
}
