using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyiStrukturyDanych
{
    internal class List
    {
        public NodeL head;
        public NodeL tail;
        public int count;

        public void AddFirst(int liczba)
        {
            var tmp = new NodeL(2);
            tmp.n = this.head;
            this.head.p = tmp;
            this.head = tmp;
            this.count++;
        }
        public void AddLast(int liczba)
        {
            var tmp = new NodeL(7); //(1)
            tmp.p = this.tail; //(2)
            this.tail.n = tmp; //(3)
            this.tail = tmp; //(4)
            this.count++; //5
        }
        public void RemoveLast()
        {
            this.tail = this.tail.p;
            this.tail.n = null
            this.count--;
        }
        public void RemoveFirst()
        {
            this.head = this.head.n;
            this.head.p = null
            this.count--;
        }
    }
}