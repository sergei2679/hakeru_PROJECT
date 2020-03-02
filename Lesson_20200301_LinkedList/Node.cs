using System;

namespace Lesson_20200301_LinkedList
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public static int GetMin(Node node)
        {
            if (node == null)
                throw new Exception("no items");

            int min = node.Value;

            while (node != null && node.Value % 2 == 0)
            {
                if (node.Value < min)
                    min = node.Value;
                node = node.Next;
            }
            return min;
        }

        public static int GetMax(Node node)
        {
            if (node == null)
                throw new Exception("no items");

            int max = node.Value;

            while (node != null && node.Value % 2 == 0)
            {
                if (node.Value > max)
                    max = node.Value;
                node = node.Next;
            }
            return max;
        }

        public static int GetSum(Node node)
        {
            if (node == null)
                throw new Exception("no items");
            
            int sum = 0;

            while (node != null && node.Value % 2 == 0)
            {
                sum += node.Value;
                node = node.Next;
            }
            return sum;
        }

        public static int GetCount(Node node)
        {
            int count = 0;

            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }

        public static bool IsDuplicated(Node node)
        {
            if (node == null)
                throw new Exception("no items");

            int min = GetMin(node);
            int max = GetMax(node);

            int[] arr = new int[max - min + 1];

            while (node != null)
            {
                arr[node.Value - min]++;
                node = node.Next;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1)
                    return true;
            }

            return false;
        }
    }
}
