using System;
using HierarchieAngestellter;

namespace BibliothekVerwendenAngestllter
{
    class Program
    {
        static void Main(string[] args)
        {
            Angestellter[] angestellte = new Angestellter[4];
            Manager manager = new Manager();
            angestellte[0] = manager;
            angestellte[1] = new Sekretär();
            angestellte[2] = new Lagerarbeiter();
            angestellte[3] = new Verkäufer();

            foreach (var item in angestellte)
            {
                item.Gehaltauszahlen();
            }
        }
    }
}
