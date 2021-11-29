using System;
using System.Collections;

namespace Schnittstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            IDarstellbar[] liste = new IDarstellbar[4];
            liste[0] = new Spieler();
            liste[1] = new Alien();
            liste[2] = new DasHausVomNikolaus();
            liste[3] = new Berg();

            foreach (var item in liste)
            {
                ConsoleDraw(item);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Spieler { punkte = 10 });
            arrayList.Add(new Spieler { punkte = 100 });
            arrayList.Add(new Spieler { punkte = 50 });
            arrayList.Sort();
            arrayList.Reverse();

            foreach (Spieler item in arrayList)
            {
                Console.WriteLine(item.punkte);
            }
        }

        static void ConsoleDraw(IDarstellbar darstellbar)
        {
            darstellbar.zeichnen();
        }
    }
    interface IDarstellbar
    {   
        //Vorgabe einer MEthode, die beim implementieren der SChnittstelle
        //ausprogrammiert werden muss
        void zeichnen(); 
    }

    class Spieler : IDarstellbar, IComparable
    {
        public int punkte;
        public int CompareTo(object obj)
        {
            Spieler spieler2 = (Spieler)obj;
            return this.punkte - spieler2.punkte;
        }

        public void zeichnen()
        {
            Console.WriteLine("Spieler zeichnen");
        }
    }

    class Alien : IDarstellbar
    {
        public void zeichnen()
        {
            Console.WriteLine("Alien zeichnen");
        }
    }

    class Schuss : IDarstellbar
    {
        public void zeichnen()
        {
            Console.WriteLine("Schuss zeichnen");
        }
    }

    class Landschaft : IDarstellbar
    {
        public void zeichnen()
        {
            Console.WriteLine("Landschaft zeichnen");
        }
    }

    class Berg : Landschaft
    {
        //new
        //public void zeichnen()
        //{
        //    Console.WriteLine("Berg zeichnen");
        //}
    }
    class DasHausVomNikolaus : IDarstellbar
    {
        public void zeichnen()
        {
            Console.WriteLine("Das Haus vom Nikolaus");
        }
    }


}
