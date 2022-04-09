using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program\n");

            MyLinkedList linkedList = new MyLinkedList();
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. Add element at last position \n2. Add element at first position " +
                "\n3. Add element at last position using Append method\n4. Insert element at perticular position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Add elements into Linkedlist using AddLast Method:");
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    Console.WriteLine("Add elements into Linkedlist using AddFirst Method:");
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 3:
                    Console.WriteLine("Add elements into Linkedlist using Append Method:");
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 4:
                    Console.WriteLine("insert element at particular position:");
                    linkedList.Append(56);
                    linkedList.Append(70);
                    linkedList.Insert(1, 30);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }

            Console.ReadLine();
        }   
    }
}
