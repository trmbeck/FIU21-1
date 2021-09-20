using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholung
{
    class Fzg
    {
        //Felder
        protected double geschw;
        public double gewicht;
        private double hoechstgeschwindigkeit = 200;

        //Methoden
        public void Beschleunigen(double wert)
        {
            geschw += wert;
            if (geschw > hoechstgeschwindigkeit)
                geschw = hoechstgeschwindigkeit;
        }

        public double GetGeschwindigkeit()
        {
            return geschw;
        }
    }

    class PKW : Fzg
    {
        public bool heckspoiler;
        public int leistung;

        public double getGeschwindigkeit()
        {
            geschw = 100;
            return geschw;
        }
    }

    class Roadster : PKW
    {
        public bool elektrischesVerdeck;
    }
}
