﻿namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Problems");

            Console.WriteLine("\nInserting 30 between 56 and 70\n");

            LinkedList linked = new LinkedList();
            linked.Add(56);
            linked.Add(30);
            linked.Add(40);
            linked.Add(70);
            linked.Display();

            //Console.WriteLine("\n------------Deleting first element--------------");
            //linked.Pop();
            //Console.WriteLine("After Poping First element..");



            //Console.WriteLine("\n------------Deleting last node--------------");
            //linked.PopLast();
            //linked.Display();

            //Console.WriteLine("\n------------finding node in linked list --------------");
            //linked.Search(30);

            //Console.WriteLine("\n------------Insert 40 after 30 --------------");
            //linked.InsertAfter(30, 40);
            //linked.Display();


            //Console.WriteLine("\n------------Deleting 40 From Linked list --------------");
            linked.DeleteValue(40);
            linked.Display();
            linked.Size();

        }
    }
}
