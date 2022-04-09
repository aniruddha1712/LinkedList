using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MyLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into LinkedList",newNode.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Insert(int index, int data)
        {
            Node newNode = new Node(data);
            if (index < 0)
            {
                Console.WriteLine("Invaid index position");
            }
            else if (index == 0)
            {
                AddFirst(data);
            }
            else
            {
                Node temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
                Console.WriteLine("{0} is inserted at index position {1}",data,index);
            }
        }
        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
                Console.WriteLine("\nFirst element deleted");
            }
        }
        public int PopLast()
        {
            Node temp = this.head;
            if (this.head == null) 
            {
                Console.WriteLine("LinkedList id empty");
                return 0;
            }
            if (this.head.next == null) 
            {
                this.head = null;
                return 0;
            }
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            int delNode = temp.next.data;
            temp.next = null;
            return delNode;
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
