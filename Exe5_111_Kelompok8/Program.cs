using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_111_Kelompok8
{
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class LinkListQueue
    {
        Node dimas;
        Node vhigar;
        public LinkListQueue()
        {
            dimas = vhigar = null;
        }
        internal void InsertQue(int item)
        {
            Node newNode = new Node(item);

            if(vhigar == null)
            {
                dimas = vhigar = newNode;
            }
            else
            {
                vhigar.next = newNode;
                vhigar = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }
        void DeleteQue()
        {
            if(dimas == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node current = dimas;
            dimas = dimas.next;
            Console.WriteLine("Item deleted is {0}", current.data);
        }
        void DisplayQueue()
        {
            if(dimas == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node current = dimas;

            while(current != null)
            {
                Console.Write(current.data + "  ");
                current = current.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkListQueue myQueue = new LinkListQueue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\n Enter your choice (1-4) : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int item = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                myQueue.InsertQue(item);
                            }
                            break;
                        case '2':
                            {
                                myQueue.DeleteQue();
                            }
                            break;
                        case '3':
                            {
                                myQueue.DisplayQueue();
                            }
                            break;
                    }
                }
            }
        }
    }
}
