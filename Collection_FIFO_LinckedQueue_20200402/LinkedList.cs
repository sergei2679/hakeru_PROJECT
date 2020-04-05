using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_20200402_Collection_Queue
{
    public class LinkedList<T> : IList<T>
    {
        private readonly Node<T> anchor;
        private Node<T> last;
        private int count;

       //private Node<T> pos;

        public LinkedList(int[] array)
        {
            anchor = new Node<T>(default(T));
            last = anchor;
            count = 0;
            //pos = T[array];
        }

        public void Add(T x)
        {
            last.Next = new Node<T>(x);
            last = last.Next;
            /*
            Node last = anchor;
            while (last.Next != null)
                last = last.Next;
            last.Next = new Node(x);
            */
            count++;
        }

        public void Add(int index, T x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            Node<T> theOneBefore = anchor;
            for (int i = 0; i < index; i++)
            {
                theOneBefore = theOneBefore.Next;
            }
            Node<T> node = new Node<T>(x);
            node.Next = theOneBefore.Next;
            theOneBefore.Next = node;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            Node<T> node = anchor;
            for (int i = 0; i <= index; i++)
            {
                node = node.Next;
            }
            return node.Data;
        }

        public void Set(int index, T x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            Node<T> node = anchor;
            for (int i = 0; i <= index; i++)
            {
                node = node.Next;
            }
            node.Data = x;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            Node<T> theOneBefore = anchor;
            for (int i = 0; i < index; i++)
            {
                theOneBefore = theOneBefore.Next;
            }
            theOneBefore.Next = theOneBefore.Next.Next;
            if (index == count - 1)
            {
                last = theOneBefore;
            }
            count--;
        }

        public int Count()
        {
            return count;
        }

        public int IndexOf(T x)
        {
            Node<T> node = anchor.Next;
            int index = 0;
            while (node != null)
            {
                if (node.Data.Equals(x))
                    return index;
                node = node.Next;
                index++;
            }
            return -1;
        }


        public T[] ToArray()
        {
            T[] temp = new T[count];
            Node<T> node = anchor;
            for (int i = 0; i < count; i++)
            {
                node = node.Next;
                temp[i] = node.Data;
            }
            return temp;
        }

        public void Clear()
        {
            anchor.Next = null;
            last = anchor;
            count = 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            Node<T> node = anchor;
            for (int i = 0; i < count - 1; i++)
            {
                node = node.Next;
                stringBuilder.Append(node.Data + ", ");
            }
            if (count > 0)
                stringBuilder.Append(node.Data.ToString());
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            if (!(obj is LinkedList<T>))
                return false;
            LinkedList<T> other = (LinkedList<T>)obj;
            if (this.count != other.count)
                return false;

            Node<T> n1 = this.anchor;
            Node<T> n2 = other.anchor;
            for (int i = 0; i < this.count; i++)
            {
                n1 = n1.Next;
                n2 = n2.Next;
                if (!n1.Data.Equals(n2.Data))
                    return false;
            }

            /*
            for (int i = 0; i < this.count; i++)
            {
                if (this.Get(i) != other.Get(i))
                    return false;
            }
            */
            return true;
        }

        public override int GetHashCode()
        {
            int result = 0;
            Node<T> node = anchor;
            for (int i = 0; i < count; i++)
            {
                node = node.Next;
                result = result.GetHashCode() ^ node.Data.GetHashCode();
            }
            return result;
        }


        /*
        public object Current
        {
            get
            {
                return pos.Value;
            }
        }
        public bool MoveNext()
        {
            pos = pos.Next;
            return pos != null;
        }
        public void Reset()
        {
            pos = anchor;
        }
        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }
        */

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = anchor;
            while (node.Next != null)
            {
                node = node.Next;
                yield return node.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> node = anchor;
            while (node.Next != null)
            {
                node = node.Next;
                yield return node.Data;
            }
        }

    }
}
