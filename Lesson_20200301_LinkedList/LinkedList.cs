using System;

namespace Lesson_20200301_LinkedList
{
    public class LinkedList
    {
        private readonly Node anchor;    //   head
        private int count;

        public LinkedList()
        {
            anchor = new Node(123);
            count = 0;
        }

        public void Add(int x)
        {
            Node newNode = new Node(x);    //  create new int node
            Node current = anchor;         //  set header of list to pointer current

            //if (anchor == null)          //  not need to check if list is empty , it has one item (123)
            //{
            //    anchor = newNode;     //  can't set to readonly field
            //}

            while (current.Next != null)
            {
                current = current.Next;    //
            }
            current.Next = newNode;        // current.next = pointer to new node (x)
            count++;
        }
        
        public void Add(int index, int x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)

                throw new Exception("index out of bounds");

            return 0;
        }

        public void Set(int index, int x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
        }

        public int Count()
        {
            return count;
        }

        public int IndexOf(int x)
        {
            Node current = anchor;

            if (current != null)
            {
                int counter = 1;
                while (current.Next != null && current.Value != x)
                {
                    current = current.Next;
                    counter++;
                }
                if (current.Value == x)
                {
                    return counter;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        public int Sum()
        {
            Node current = anchor;
            int sum = 0;
            while (current != null)
            {
                sum += current.Value;
                current = current.Next;
            }
            return sum;
        }

        public int[] ToArray()
        {
            Node current = anchor;
            int[] arr = new int[count+1];
            int i = 0;

            while (current != null)
            {
                arr[i] = current.Value;
                current = current.Next;
                i++;
            }
            return arr;
        }

        public void Clear()
        {
            count = 0;
        }

        private string ShowNodes()
        {
            Node current = anchor;
            string res = null;

            if (current == null)       
                res = "No more nodes to display \n";
            
            else
            {
                while (current != null)
                {
                    res += "Node : " + current.Value + "\n";
                    current = current.Next;
                }
            }
            return res;
        }

        public override string ToString()
        {
            return ShowNodes();
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
