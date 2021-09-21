using System;
using System.Collections.Generic;
using System.Text;

namespace IPAdressenÜbung
{
    class IPAdresse
    {
        //Felder
        private string ipadresse;

        //Konstruktoren (Überladung)
        public IPAdresse()
        {
            this.ipadresse = "0.0.0.0";
        }
        public IPAdresse(int a, int b, int c, int d)
        {
            SetIP(a, b, c, d);
        }
        public IPAdresse(string ipadresse)
        {
            SetIP(ipadresse);
        }

        //Methoden
        public bool SetIP(string ipadresse)
        {
            string[] oktetts = ipadresse.Split('.');
            foreach (var item in oktetts)
            {
                byte oktett;
                if (!byte.TryParse(item, out oktett))
                {
                    Console.WriteLine("Fehler: IPAdresse wird auf 0.0.0.0 gesetzt!!!");
                    this.ipadresse = "0.0.0.0";
                    return false;
                };
            }
            this.ipadresse = ipadresse;
            return true;
        }
        public bool SetIP(int a, int b, int c, int d)
        {
            if (a > -1 && a < 256 && b > -1 && b < 256 && c > -1 && c < 256 && d > -1 && d < 256)
                ipadresse = a + "." + b + "." + c + "." + d;
            else
            {
                ipadresse = "0.0.0.0";
                Console.WriteLine("Fehler: IPAdresse wird auf 0.0.0.0 gesetzt!!!");
                return false;
            }
            return true;
        }
        public string GetIP()
        {
            return ipadresse;
        }

        //Eigenschaften, Properties
        public string IpAdresse
        {
            get
            {
                return GetIP();
            }
            set
            {
                SetIP(value);
            }
        }
    }
}
