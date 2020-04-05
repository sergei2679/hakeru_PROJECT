using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_20200402_Collection_Queue
{
    class ArrayList<T> : IList<T>
    {
        private T[] arr;
        private int count;

        //private int pos;


        public ArrayList()
        {

            arr = new T[10];
            count = 0;
        }



        public void Add(T x)
        {
            MakeRoom();
            arr[count++] = x;
        }


        private void MakeRoom()
        {
            if (count == arr.Length)
            {
                T[] temp = new T[count * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
        }

        public void Add(int index, T x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            MakeRoom();
            for (int i = count; i > index; i--)
                arr[i] = arr[i - 1];
            arr[index] = x;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            return arr[index];
        }

        public void Set(int index, T x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            arr[index] = x;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
        }

        public int Count()
        {
            return count;
        }

        public int IndexOf(T x)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i].Equals(x))
                    return i;
            }
            return -1;
        }


        public T[] ToArray()
        {
            T[] temp = new T[count];
            for (int i = 0; i < count; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        public void Clear()
        {
            count = 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            for (int i = 0; i < count - 1; i++)
            {
                stringBuilder.Append(arr[i] + ",");
            }
            if (count > 0)
                stringBuilder.Append(arr[count - 1]);
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            if (!(obj is ArrayList<T>))
                return false;
            ArrayList<T> other = (ArrayList<T>)obj;
            if (this.count != other.count)
                return false;
            for (int i = 0; i < count; i++)
            {
                if (!this.arr[i].Equals(other.arr[i]))
                    return false;
            }
            return true;


        }



        public override int GetHashCode()
        {
            int result = 0;
            //arr.GetHashCode();
            for (int i = 0; i < count; i++)
            {
                result = result.GetHashCode() ^ arr[i].GetHashCode();
            }

            return result;
        }


        /*
        public object Current
        {
            get
            {
                return arr[pos];
            }
        }
        public bool MoveNext()
        {
            Console.WriteLine("in MoveNext");
            pos++;
            return pos < count ;
        }
        
        public void Reset()
        {
            pos = -1;
            Console.WriteLine("in Reset");
        }
        
        //IEnumerable has the method GetEnumerator, so it can produce an IEnumerator.
        //IEnumerator has MoveNext,Reset and Current
        
        //This method is part of the interface IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            Reset();
            return this;
        }
        */


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }
    }
}
