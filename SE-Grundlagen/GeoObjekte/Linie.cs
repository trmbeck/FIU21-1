using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjekte
{
    public class Linie
    {
        #region Felder
        public static int anzahl = 0;

        public Punkt A;
        public Punkt B;

        public Color farbe;
        private string name;
        #endregion

        #region Konstruktoren
        public Linie(double x1, double y1, double x2, double y2, Color c)
        {
            A = new Punkt();
            A.x = x1;
            A.y = y1;
            A.farbe = c;

            B = new Punkt() { x = x2, y = y2, farbe = c}; //Objektinitialisierer
            //B.x = x2;
            //B.y = y2;
            //B.farbe = c;

            farbe = c;
            anzahl++;
            name = "Linie " + anzahl;
        }

        #endregion

        #region Methoden
        public string GetInfo()
        {
            string info = "";

            info += name + "\r\n";
            info += $"A: ({A.x}|{A.y})\r\n";
            info += String.Format("B: ({0}|{1})\r\n", B.x, B.y);
            info += "Farbe: " + farbe.Name + Environment.NewLine;
            info += "Länge: " + Math.Round(Laenge(),2);

            return info;
        }
        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return GetName();
        }

        public double Laenge()
        {
            double c;
            double a = B.x - A.x;
            double b = B.y - A.y;

            Math.Pow(a, 2); // Beispiel a quadrieren
            c = Math.Sqrt(a * a + b * b); // Wurzel ziehen

            return c;
        }

        #endregion
    }
}
