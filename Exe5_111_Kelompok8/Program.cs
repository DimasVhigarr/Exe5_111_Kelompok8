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
    }
}
