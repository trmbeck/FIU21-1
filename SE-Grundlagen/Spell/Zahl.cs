using System;
using System.Collections.Generic;
using System.Text;

namespace Spell
{
    class Zahl
    {
        int zahl; //Hunderter, Zehner, Einer z. B. 362 dreihundert zwei und sechszig

        public Zahl(int z)
        {
            if (z < 1000 && z > 0)
                zahl = z;
            else zahl = 999;
        }

        public string Spell()
        {
            string spelledNumber = "";

            int hunderter = zahl / 100;
            int zehner = (zahl - hunderter*100)/10;
            int einer = zahl - hunderter * 100 - zehner * 10;

            if (hunderter > 0)
            {
                switch (hunderter)
                {
                    case 1: spelledNumber = "einhundert ";
                        break;
                    case 2:
                        spelledNumber = "zweihundert ";
                        break;
                    case 3:
                        spelledNumber = "dreihundert ";
                        break;
                    case 4:
                        spelledNumber = "vierhundert ";
                        break;
                    case 5:
                        spelledNumber = "fünfhundert ";
                        break;
                    case 6:
                        spelledNumber = "sechshundert ";
                        break;
                    case 7:
                        spelledNumber = "siebenhundert ";
                        break;
                    case 8:
                        spelledNumber = "achthundert ";
                        break;
                    case 9:
                        spelledNumber = "neunhundert ";
                        break;
                }

            }


            if (zehner == 1) //Sonderfall
            {
                switch (10 + einer)
                {
                    case 10: spelledNumber += "zehn";break;
                    case 11: spelledNumber += "elf"; break;
                    case 12: spelledNumber += "zwölf"; break;
                    case 13: spelledNumber += "dreizehn"; break;
                    case 14: spelledNumber += "vierzehn"; break;
                    case 15: spelledNumber += "fünfzehn"; break;
                    case 16: spelledNumber += "sechszehn"; break;
                    case 17: spelledNumber += "siebzehn"; break;
                    case 18: spelledNumber += "achtzehn"; break;
                    case 19: spelledNumber += "neunzehn"; break;
                }
            }
            else
            {
                switch (einer)
                {
                    case 1:
                        spelledNumber += "ein";
                        if (zehner == 0) spelledNumber += "s";
                        break;
                    case 2: spelledNumber += "zwei"; break;
                    case 3: spelledNumber += "drei"; break;
                    case 4: spelledNumber += "vier"; break;
                    case 5: spelledNumber += "fünf"; break;
                    case 6: spelledNumber += "sechs"; break;
                    case 7: spelledNumber += "sieben"; break;
                    case 8: spelledNumber += "acht"; break;
                    case 9: spelledNumber += "neun"; break;
                }
            }

            if (zehner > 1)
            {
                if (zehner != 0 || einer != 0) spelledNumber += " und ";
                switch (zehner)
                {
                    case 2:
                        spelledNumber += "zwanzig ";
                        break;
                    case 3:
                        spelledNumber += "dreißig ";
                        break;
                    case 4:
                        spelledNumber += "vierzig ";
                        break;
                    case 5:
                        spelledNumber += "fünfzig ";
                        break;
                    case 6:
                        spelledNumber += "sechszig ";
                        break;
                    case 7:
                        spelledNumber += "siebzig ";
                        break;
                    case 8:
                        spelledNumber += "achtzig ";
                        break;
                    case 9:
                        spelledNumber += "neunzig ";
                        break;
                }
            }

            return spelledNumber;
        }
    }
}
