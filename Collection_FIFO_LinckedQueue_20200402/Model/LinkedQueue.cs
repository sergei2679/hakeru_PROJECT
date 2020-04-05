﻿namespace Collection_FIFO_LinckedQueue_20200402.Model
{
    public class LinkedQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int Count { get; private set; }

        public LinkedQueue(){}
        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new Node<T>(data);
            head = item;
            tail = item;
            Count = 1;

        }
        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Node<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;
        }

        public T Dequeue()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;

            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;

            return data;
        }

        public T Peek()
        {
            return head.Data;
        }
    }
}