using System;

namespace Wiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Schlüsselwort var, Convert, parse, tryparse

            var zahl = 10;

            var eingabe = Console.ReadLine();

            zahl = Convert.ToInt32(eingabe);

            var zahl2 = 29;

            zahl = int.Parse(eingabe); // wenn kein parsen möglich, dann exception
            //zahl = int.Parse("bla"); // --> exception

            bool erfolgreich = int.TryParse(eingabe, out zahl); //keine Exception bei Fehler
            if (erfolgreich)
            {
                Console.WriteLine("parsen hat funktioniert");
            }
            else
            {
                Console.WriteLine("fehler");
            }

            #endregion

            #region Value-Types und Reference-Type, Schlüsselwort ref

            int MainA;   
            MainA = 10; // Stackspeicher: 10
            MainA = testA(MainA);

            Console.WriteLine("a: " + MainA);

            int MainB = 10;
            testB(ref MainB); //Übergabe per Referenz -> Speicheradresse wird übergeben

            Console.WriteLine("b: " + MainB);

            Kfz meinKfz; // Im Stack wird nur die Adresse des Speichers (Heap) abgelegt wird, in welchem sich die Daten des Objekts befinden
            meinKfz = new Kfz();

            Console.WriteLine("Leistung: " + meinKfz.Leistung); // Output: 50
            testC(meinKfz);
            Console.WriteLine("Leistung: " + meinKfz.Leistung); // Output: 0

            Kfz meinZweitesKfz = new Kfz();
            Console.WriteLine("Leistung 2. Kfz: " + meinZweitesKfz.Leistung);   // Output: 50
            meinZweitesKfz = meinKfz; // Stackwert von meinKfz (Heapadresse) überschreibt den Stackwert vom 2. Kfz
            Console.WriteLine("Leistung 2. Kfz: " + meinZweitesKfz.Leistung);   // Output: 0
            meinZweitesKfz.Leistung++;
            Console.WriteLine("Leistung 2. Kfz: " + meinZweitesKfz.Leistung);   // Output: 1
            Console.WriteLine("Leistung 1. Kfz: " + meinKfz.Leistung);          // Output: 1
            #endregion

            #region Vererbung, Polymorphie, abstrake Klasse
            Kfz auto = new Kfz();
            Fahrrad fahrrad = new Fahrrad();

            auto.Beschleunigen();
            fahrrad.Beschleunigen();

            auto.Richtungsanzeige("links");

            Fahrzeug[] fahrzeugListe = new Fahrzeug[3];
            fahrzeugListe[0] = new LKW();
            fahrzeugListe[1] = auto;    //Richtungsanzeige Ausblenden, boxing
            fahrzeugListe[2] = fahrrad; //Richtungsanzeige Überschreiben, boxing

            
            foreach(var item in fahrzeugListe)
            {
                Console.WriteLine(nameof(item)); //nur test
                item.Beschleunigen();
                Console.WriteLine("Geschw.: " + item.Geschwindigkeit);
                if (item is Kfz)
                {
                    (item as Kfz).Richtungsanzeige("links"); //unboxing, -> wenn item kein Kfz-Type ist wird null verwendet
                    ((Kfz)item).Richtungsanzeige("link");    //unboxing -> führt zu einer Ausnahme, wenn item kein Objekt vonKfz-Typ ist
                    //double kommazahl = 10.0;
                    //int ganzzahl = (int)kommazahl;
                }
                else
                    item.Richtungsanzeige("links");
                item.RückwärtsFahren();
            }

            Fahrzeug zweirad = new Fahrrad();
            zweirad.Richtungsanzeige("rechts");
            #endregion
        }

        static int testA(int testA) // Stack: reserviert einen Integerspeicherplatz, 
        {                           // Call-by-Value (einfache Datentypen übergeben)
            testA++;
            return testA;
        }
        static void testB(ref int testB)  // Call-by-Reference --> gleiche Speicheradresse wie das übergebene  Argument
        {
            testB++;
        }
        static void testC(Kfz kfz) // Call-by-Referenz --> komplexe Datentypen werden per Referenz übergeben
        {
            kfz.Leistung = 0;
        }
        static void testD(Fahrzeug f)
        {
            f.Richtungsanzeige("links");
        }
    }

    public abstract class Fahrzeug  //abstrakt
    {
        //Attribute
        private string NurFürFahrzeug;          //nur in der eigenen Klasse verfügbar (Standard)
        protected string VerfügbarInHierarchie; //in sämtlichen Ableitungen, aber nicht von ausserhalb
        internal string InnerhalbDerAssembly;   //UML packages -> verfügbar im ganzen Projekt
        public double Geschwindigkeit = 0.0;
        //Operationen
        public void Beschleunigen()
        {
            Geschwindigkeit += 1;
        }
        public virtual void Richtungsanzeige(string richtung) //virtual erlaubt ein überschreiben der Methode
        {
            Console.WriteLine("Richtungsanzeige: " + richtung);
        }
        public abstract void RückwärtsFahren(); //Vorgabe für Ableitung, dass dieser Member implementiert sein muss!!!

    }
    
    public class Kfz : Fahrzeug //Standardzugriffsmodifizierer für Klassen ist **internal**
    {
        public int Leistung = 50;
        new public void Richtungsanzeige(string richtung) //Ausblenden, Schlüsselwort new kennzeichnet Ausblendung als vorgesehen
        {
            Console.WriteLine("Blinker: " + richtung);
        }
        public override void RückwärtsFahren()
        {
            Console.WriteLine("Rückwärtsgang einlegen und beschleunigen :-)");
        }
    }

    class Fahrrad : Fahrzeug
    {
        public override void Richtungsanzeige(string richtung) // überschreibt die geerbte Methode
        {
            Console.WriteLine("Hand heben: " + richtung);
        }
        public override void RückwärtsFahren()
        {
            Console.WriteLine("Absteigen und zurückschieben");
        }
    }

    class BMXrad : Fahrrad
    {
        // die geerbte Methode ist mit override gekennzeichnet und
        // somit ist es möglich auch diese Methode zu überschreiben
        public override void Richtungsanzeige(string richtung)
        {
            base.Richtungsanzeige(richtung); //Aufruf der geerbten Methode mittels Schlüsselwort base
        }
    }

    class LKW : Fahrzeug
    {
        public override void RückwärtsFahren()
        {
            Console.WriteLine("Rückwärtsgang einlegen, Kamera an und beschleunigen");
        }
    }

}
