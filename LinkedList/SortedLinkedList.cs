using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SortedLinkedList
    {
        public Node head;
        public void OrderedLinkedlist(int data)
        {
            Node newNode = new Node(data);
            Node currentNode = this.head, temp = null;
            while (currentNode != null && currentNode.data < newNode.data)
            {
                temp = currentNode;
                currentNode = currentNode.next;
            }
            if (temp == null)
            {
                this.head = newNode;
            }
            else
            {
                temp.next = newNode;
            }
            newNode.next = currentNode;
            Console.WriteLine("{0} is inserted into ordered Linkedlist", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
