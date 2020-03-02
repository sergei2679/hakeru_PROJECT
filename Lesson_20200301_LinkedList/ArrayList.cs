using System;
using System.Text;

namespace Lesson_20200301_LinkedList
{
    public class ArrayList
    {
        private int[] arr;
        private int count;

        public ArrayList()
        {
            arr = new int[10];
            count = 0;
        }
        public void Add(int x)
        {
            MakeRoom();
            arr[count++] = x;
        }
        private void MakeRoom()
        {
            if (count == arr.Length)
            {
                int[] temp = new int[count * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
        }
        public void Add(int index, int x)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");

            MakeRoom();

            for (int i = count; i > index; i--)
                arr[i] = arr[i - 1];

            arr[index] = x;
            count++;
        }
        public int Get(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of bounds");

            return arr[index];
        }
        public void Set(int index, int x)
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
        public int IndexOf(int x)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        public int[] ToArray()
        {
            int[] temp = new int[count];

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

            if (!(obj is ArrayList))
                return false;

            ArrayList other = (ArrayList)obj;

            if (this.count != other.count)
                return false;

            for (int i = 0; i < count; i++)
            {
                if (this.arr[i] != other.arr[i])
                    return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            int result = 0;

            arr.GetHashCode();

            for (int i = 0; i < count; i++)
            {
                result = result ^ arr[i];
            }
            return result;
        }
    }
}