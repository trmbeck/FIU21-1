using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auflistungen
{
    class Monatsnamen : IEnumerable // Klassenobjekt ist mittels foreach iterierbar
    {
        int zahl;
        public string[] monat = {
            "Jan","Feb","Mar",
            "Apr","Mai","Jun",
            "Jul","Aug","Sep",
            "Okt","Nov","Dez"
        };

        //Indexer
        public string this[int index]
        {
            get
            {
                if (index < monat.Length && index >= 0)
                    return monat[index];
                else
                {
                    Console.WriteLine("Fehler: Index außerhalb des Bereichs");
                    return null;
                }
            }
            set
            {
                if (index < monat.Length && index >= 0)
                    monat[index] = value;
                else
                {
                    Console.WriteLine("Fehler: Index außerhalb des Bereichs");
                }
            }
        }

        public IEnumerator GetEnumerator() // Liefert Zeiger auf Listenelement 
        {
            for (int i = 0; i < monat.Length; i++)
            {
                yield return monat[i];
            }
        }


        // Getter und Setter Methoden zur Kapselung von zahl
        public int GetZahl()
        {
            return zahl;
        }
        public void SetZahl(int z)
        {
            zahl = z;
        }

        // Eigenschaft (Property) zur Kapselung von zahl
        public int Zahl
        {
            get
            {
                return zahl;
            }
            set
            {
                if (value >= 0)
                    zahl = value;
            }
        }
    }
}
