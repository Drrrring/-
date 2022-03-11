namespace Test1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Data = t;
            Next = null;
        }
    }
}