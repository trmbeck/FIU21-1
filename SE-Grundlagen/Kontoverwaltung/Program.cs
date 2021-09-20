using System;

namespace Kontoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Kontoverwaltung:\n----------------");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1) Geld einzahlen");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2) Geld auszahlen");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("3) Kontostand abfragen");
                Console.WriteLine("4) Beenden");
                Console.Write("Bitte wählen: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    //Geld einzahlen
                    Console.WriteLine("Geldeinzahlen, welchen Betrag?");
                    decimal betrag = Convert.ToDecimal(Console.ReadLine());
                    k1.GeldEinzahlen(betrag);
                }
                else if (eingabe == "2")
                {
                    //Geld auszahlen
                    Console.WriteLine("Geldauszahlen, welchen Betrag? ");
                    decimal betrag = Convert.ToDecimal(Console.ReadLine());
                    k1.GeldAuszahlen(betrag);
                }
                else if (eingabe == "3")
                {
                    //Kontostand anzeigen
                    k1.KontostandAnzeigen();
                    Console.WriteLine("Bitte Taste drücken ...");
                    Console.ReadKey();
                }
                else if (eingabe == "4")
                {
                    return;
                }else
                {
                    //Falsche Eingabe
                    Console.WriteLine("Falsche Eingabe");
                }
            } while (true);
            
            //switch (eingabe)
            //{
            //    case "1":
            //        //Geld einzahlen
            //        break;
            //    case "2":
            //        //Geld auszahlen
            //        break;
            //    case "3":
            //        //Kontostand anzeigen
            //        break;
            //    default:
            //        //falsche Eingabe
            //        break;
            //}

        }
    }


}
