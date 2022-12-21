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
        Node nama_depan;
        Node nama_belakang;
        public LinkListQueue()
        {
            this.nama_depan = this.nama_belakang = null;
        }
        internal void InsertQue(int item)
        {
            Node newNode = new Node(item);

            if(this.nama_belakang == null)
            {
                this.nama_depan = this.nama_belakang = newNode;
            }
            else
            {
                this.nama_belakang.next = newNode;
                this.nama_belakang = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }
        void DeleteQue()
        {
            if(this.nama_depan == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node current = this.nama_depan;
            this.nama_depan = this.nama_depan.next;
            Console.WriteLine("Item deleted is {0}", current.data);
        }

    }
}
