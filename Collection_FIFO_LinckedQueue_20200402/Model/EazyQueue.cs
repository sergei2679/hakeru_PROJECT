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
        public EazyQueue() 
        { }

        public EazyQueue(T data)
        {
            items.Add(data);
        }


        public void Enqueue(T data) 
        {
            //Insert an element into List<T> in specific index pos
            //Enqueue allways insert to head (pos 0)
            items.Insert(0,data);       
        }
        
        
        //Removes and returns an item from the beginning of the queue.
        public T Dequeue()
        {
            var item = Head;

            //remove element form the Queue           
            //remove the first accurance of a specific object from the List<T>
            items.Remove(item); //bool List<T> Remove(T item)
            
            return item;
        }



        //Returns an first item from the queue
        public T Peek()
        {
            return Head;
        }
    }
}
