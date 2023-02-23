namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Problems");

            Console.WriteLine("\nCreate Linked List by Appending 30 and 56 to 70\n");

            LinkedList linked = new LinkedList();
            linked.Append(56);
            linked.Append(30);
            linked.Append(70);

            linked.Display();
        }
    }
}
