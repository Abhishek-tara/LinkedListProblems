namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Problems");

            LinkedList linked = new LinkedList();
            linked.Add(10);
            linked.Add(20);
            linked.Add(30);
            linked.Add(50);

            linked.Display();
        }
    }
}
