using System.Collections.Generic;
using System.Linq;


namespace Collection_FIFO_LinckedQueue_20200402.Model
{
    public class EazyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();

        public int Count => items.Count;

        public EazyQueue() { }

        public EazyQueue(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data) 
        {
            /// Summary
            //Insert an element into List<T>
            /// Summary
            items.Insert(0,data);
        }

        public T Dequeue()          // remove element form Queue
        {
            var item = Head;

            //remove the first accurance of a specific object from the List<T>
            items.Remove(item);     // bool List<T> Remove(T item)
            
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
