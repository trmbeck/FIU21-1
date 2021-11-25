using System;

namespace FahrzeugHierarchie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Fahrzeug { }
    class Automobil : Fahrzeug { }
    class Zweirad : Fahrzeug { }
    class Wasserfahrzeug : Fahrzeug { }
    class PKW : Automobil{ }
    class Lastwagen : Automobil{ }
    class Sportwagen : PKW{ }
    class Limousine : PKW{ }
    class Ruderboot : Wasserfahrzeug{ }
    class Schiff : Wasserfahrzeug{ }
    class Öltanker : Schiff{ }
    class Fahrrad : Zweirad{ }
    class Motorrad : Zweirad{ }
    class Sattelschlepper : Lastwagen{ }
}