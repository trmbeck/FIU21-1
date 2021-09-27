﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungPolymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoObjekt[] geoObjektsListe = new GeoObjekt[3];
            //geoObjektsListe[0] = new Punkt();
            
            Linie l = new Linie();
            l.Verschieben(1, 1);

            Kreis k = new Kreis();
            k.Verschieben(2, 2);

            Rechteck r = new Rechteck();
            r.Verschieben(3, 3);

            geoObjektsListe[0] = l;
            geoObjektsListe[1] = k;
            geoObjektsListe[2] = r;


            Console.ReadLine();

            foreach (var item in geoObjektsListe)
            {
                item.Verschieben(1,2);
            }

            Console.ReadLine();
        }
    }
    class Punkt
    {
        public double x;
        public double y;
    }

    class GeoObjekt
    {
        public Punkt A;
        public virtual void Verschieben(double dx, double dy)
        {
            //A.x += dx;
            //A.y += dy;
            Console.WriteLine("GeoObjekt verschoben");
        }
    }

    class Linie : GeoObjekt
    {
        public Punkt A;
        public Punkt B;
        public override void Verschieben(double dx, double dy)
        {
            Console.WriteLine("Linie verschoben");
        }
    }
    class Kreis : GeoObjekt 
    {
        public Punkt A;
        public double Radius;

        public override void Verschieben(double dx, double dy)
        {
            Console.WriteLine("Kreis verschoben");
        }
    }
    class Rechteck : GeoObjekt 
    {
        public Punkt A;
        public Punkt B;

        public override void Verschieben(double dx, double dy)
        {
            //A.x += dx;
            //A.y += dy;
            //B.x += dx;
            //B.y += dy;
            Console.WriteLine("Rechteck verschoben");
        }
    }
}
