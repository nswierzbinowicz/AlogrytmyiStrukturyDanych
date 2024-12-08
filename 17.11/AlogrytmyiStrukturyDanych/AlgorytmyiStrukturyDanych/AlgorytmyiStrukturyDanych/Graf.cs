using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyiStrukturyDanych
{
    internal class Graf
    {
        List<NodeG> nodes = new List<NodeG>();
        List<Edge> edges = new List<Edge>();

        void Add(Edge k)
        {

        }
        Element[] AlgorytmDijkstry(NodeG start)
        {
            var tabelka = this.przygotujTabelke(start); //do zrobienia w domu
            var zbS = new List<NodeG>();
            return tabelka;
        }

        List<Edge> ZnajdzNajmniejszyDystans(List<Element> tabelka, List<NodeG> zbS)
        {
            var wynik = tabelka.Where(e => !zbS.Contains(e.wezel)).OrderBy(e => e.dystans).First();
            var a = this.edges.Where(k => k.start == wynik.wezel && !zbS.Contains(k.end)).ToList();
            return a;
        }

        Element[] przygotujTabelke(NodeG start)
        {   
            var tabela = new Element[this.nodes.Count];
            for(NodeG node in this.nodes)
            {
                tabela.
            }
            return tabela;
        }
    }
}

