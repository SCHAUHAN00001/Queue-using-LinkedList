using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue_using_LinkedList
{
    internal class Program
    {
        public class Node
        {
            public int element;
            public Node Next;
            public Node(int e , Node n) 
            {
                element = e;
                Next = n;
            }
        }
        class QueueLnkedList
        {
            Node front;
            Node rear;
            int size;
            public QueueLnkedList()
            {
                front = null;
                rear = null;
                size = 0;

            }
            public int length()
            {
                return size; ;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public void enqueue(int e)
            {
                Node newest = new Node(e, null);
                if (isEmpty())
                {
                    front = newest;
                }
                else
                {
                    rear.Next = newest;
                }
                rear = newest;
                size++;
            }
            public int dequeue()
            {
                if(isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                int e = front.element;
                front = front.Next;
                size--;
                if (isEmpty())
                {
                    rear = null;
                }
                return e;
            }
            public int First()
            {
                if(isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;  
                }
                return front.element;
            }
            public void display()
            {
                Node p = front;
                while(p != null)
                {
                    Console.WriteLine(p.element);
                    p = p.Next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            QueueLnkedList Q = new QueueLnkedList();
            Console.WriteLine("Creating a Queue:  enqueue()");
            Q.enqueue(1);
            Q.enqueue(2);
            Q.enqueue(3);
            Q.enqueue(4);
            Q.enqueue(5);
            Q.enqueue(6);
            Q.display();
            Console.WriteLine("Size:" + Q.length());

            Console.WriteLine();
            Console.WriteLine("Removing first elemnet of Queue (FIFO): dequeue()");
            Q.dequeue();
            Q.display();
            Console.WriteLine("Size:" + Q.length());
            Console.WriteLine();
            Console.WriteLine("Finding First element : First() --> " + Q.First());




            Console.ReadLine();
        }
    }
}
