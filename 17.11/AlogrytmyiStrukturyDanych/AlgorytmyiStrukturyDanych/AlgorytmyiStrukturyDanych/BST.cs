using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyiStrukturyDanych
{
    internal class BST
    {
        public NodeT root;
    }
    public NodeT znajdzRodzica(NodeT dziecko)
    {
        var rodzic = this.root;
        while (true)
        {
            if (dziecko.data < rodzic.data)
            {
                if (rodzic.lewa == null)
                {
                    return rodzic;
                }
                else
                {
                    rodzic = rodzic.lewa;
                }
            }
            if (dziecko.data >= rodzic.data)
            {
                if (rodzc.prawa == null)
                {
                    return rodzic;
                }
                else
                {
                    rodzic = rodzic.prawa;
                }
            }
        }
     
    }
    public void Add(int liczba)
    {
        var dziecko = new NodeT(liczba);
        if(this.root == null)
        {
            this.root = dziecko;
        }
        else
        {
            var rodzic = this.znajdzRodzica(dziecko);
            dziecko.rodzic = rodzic;
            if(dziecko.data < rodzic.data)
            {
                rodzic.lewa = dziecko;
            }
            else
            {
                rodzic.prawa = dziecko;
            }
        }

    }
}
