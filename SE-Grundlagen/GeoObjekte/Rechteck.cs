using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjekte
{
    class Rechteck
    {
        //Konstruktoren
        public Rechteck()
        {
            anzahl++;
            Name = "Rechteck " + anzahl;
            a = new Punkt();
            B = new Punkt();
        }

        //Klassenfelder
        public static int anzahl = 0;

        //Objektfelder
        private Punkt a;
        private Punkt B; // B.x B.y
        private System.Drawing.Color farbe;
        private string name;


        //Eigenschaften, properties
        public Punkt A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; } 
        }
        public double SeiteB
        {
            get { return B.y - a.y; }
        }
        public double Umfang
        {
            get { return 2 * SeiteA() + 2 * SeiteB; }
        }
        public double Flaeche
        {
            get { return SeiteA() * SeiteB; }
        }


        //Getter und Setter Methoden
        public Punkt GetPunktB()
        {
            return B;
        }
        public void SetPunktB(Punkt x)
        {
            B = x;
        }

        //Methoden
        public void Verschieben(double deltaX, double deltaY)
        {
            a.x += deltaX;
            a.y += deltaY;
            B.x += deltaX;
            B.y += deltaY;
        }
        public override string ToString()
        {
            return Name;
        }
        public double SeiteA()
        {
            double seiteA = 0;
            seiteA = B.x - a.x;
            return seiteA;
        }
        public string GetInfo()
        {
            string info = "";
            info += Name + Environment.NewLine;
            info += $"A: ({a.x}|{a.y})" + Environment.NewLine;
            info += $"B: ({B.x}|{B.y})" + Environment.NewLine;
            info += $"Farbe: {farbe}" + Environment.NewLine;
            info += $"Länge a: " + SeiteA() + Environment.NewLine;
            info += $"Länge b: " + SeiteB + Environment.NewLine;
            info += $"Umfang: " + Umfang + Environment.NewLine;
            info += $"Fläche: " + Flaeche + Environment.NewLine;
            return info;
        }
    }
}
