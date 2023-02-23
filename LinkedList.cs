using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;

        internal void Append(int data)
        {
            Node node = new Node(data);

            //Checking if head is pointing to null value or not
            if (this.head == null)
            {
                //If head is pointing to null then add the entered element as first element
                this.head = node;
            }
            else
            {
                //Declared temporary node temp pointing head
                Node temp = head;

                //while we dont't get next value of node as null
                while (temp.next != null)
                {
                    //temp is moving to next node
                    temp = temp.next;
                }
                //assigning next of last element (here temp) to newly added "node"
                temp.next = node;
            }
            Console.WriteLine(node.data + " appended to the Linked List");
        }

        public void Add(int data)
        {
            Node node = new Node(data);

            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;

                while(temp.next != null) 
                { 
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Added to linked list ", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}
