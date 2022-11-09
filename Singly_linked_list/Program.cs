using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    class Node
        {
        public int noMhs;
        public string nama;
        public Node next;
        }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote()/*Method untuk menambahkan sebuah Node kedalam list*/
        {
            int nim;
            string nm;
            Console.WriteL("\nMasukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;
            
            if (START == null || nim <= STARAT.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
            }
        }
    }
    
}
