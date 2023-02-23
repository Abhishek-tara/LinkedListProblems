namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Problems");

            Console.WriteLine("\nCreating Linked List by Adding 30 and 56 to 70");

            LinkedList linked = new LinkedList();
            linked.Add(70);
            linked.Add(30);
            linked.Add(56);

            linked.Display();
        }
    }
}
