using System;

namespace Wiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 3;

            int x2 = 5;
            int y2 = 6;

            int[] p = new int[2];
            p[0] = 3;
            p[1] = 4;

            int[] p2 = new int[2];
            p2[0] = 5;
            p2[1] = 6;

            Koordinate Punkt1 = new Koordinate();
            Punkt1.SetX(4);
            Punkt1.y = 3;

            Koordinate[] koordinatenListe = new Koordinate[10];

            Console.WriteLine($"X:{Punkt1.GetX()}\nY:{Punkt1.y}");
            
            Punkt1.Move(2, 1);
            Console.WriteLine($"X:{Punkt1.GetX()}\nY:{Punkt1.y}");

            Fzg fzg1 = new Fzg();
            //fzg1.geschw = 100;
            fzg1.gewicht = 800;
            fzg1.Beschleunigen(10);
            Console.WriteLine(fzg1.GetGeschwindigkeit());

            PKW pkw1 = new PKW();
            //pkw1.geschw = 120;
            pkw1.heckspoiler = true;
            pkw1.leistung = 100;

            Roadster roadster1 = new Roadster();
            //roadster1.geschw = 200;
            roadster1.gewicht = 750;
            roadster1.heckspoiler = true;
            roadster1.leistung = 140;
            roadster1.elektrischesVerdeck = true;
            roadster1.Beschleunigen(20);


            Console.ReadLine();
        }
    }

    // Klasse, Datentyp
    class Koordinate //Bezeichner
    {
        //Felder, fields
        private int x;
        public int y;

        //Methoden
        public int GetX()
        {
            return x;
        }
        public void SetX(int _x)
        {
            if (_x > 9)
                x = _x;
            else
                x = 10;
        }

        public void Move(int dx, int dy)
        {
            x = x + dx;
            y += dy;
        }
    }
}
