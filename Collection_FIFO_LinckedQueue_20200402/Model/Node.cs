namespace Collection_FIFO_LinckedQueue_20200402.Model
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        
        public Node(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
