using System;
using System.Collections;

namespace Auflistungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            
            if (args != null && args.Length > 0)
                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }

            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Auflistungen");

            #region ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hallo");
            arrayList.Add(123);
            arrayList.Add(DateTime.Now);
            Console.WriteLine(arrayList[0]); // Zugriff über Indexer
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);
            Console.WriteLine("Anzahl: " + arrayList.Count);
            Console.WriteLine("Kapazität: " + arrayList.Capacity);
            arrayList.Add(10.2);
            arrayList.Add('a');
            Console.WriteLine("Anzahl: " + arrayList.Count);
            Console.WriteLine("Kapazität: " + arrayList.Capacity);
            for (int i = 0; i < 8; i++)
            {
                arrayList.Add(i * i);
            }
            Console.WriteLine("Anzahl: " + arrayList.Count);
            Console.WriteLine("Kapazität: " + arrayList.Capacity);
            arrayList.Remove(123);
            arrayList.RemoveAt(1);
            Console.WriteLine("\nAusgabe der ArrayList");
            foreach (var item in arrayList)
            {
                if (item is int)
                {
                    Console.WriteLine(((int)item) + 1);
                }else
                Console.WriteLine(item);
            }

            //Initialisierer
            ArrayList liste = new ()
            {
                "PKW",  //Element wird über 'boxing' als 'object' gespeichert
                "Fahrrad",
                "Schiff",
                12,
                'a',
            };

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Queue
            Console.Clear();
            Queue queue = new ();

            for (int i = 1; i <= 20; i++)
            {
                queue.Enqueue("Inhalt von Schlangenelement " + i);
            }

            Console.WriteLine("Anzahl Elemente: " + queue.Count);
            Console.WriteLine(queue.Dequeue() + " entfernt");
            Console.WriteLine(queue.Dequeue() + " entfernt");
            Console.WriteLine("Anzahl Elemente: " + queue.Count);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Stack

            Stack stack = new Stack();

            for (int i = 1; i <= 20; i++)
            {
                stack.Push("Inhalt von Stapelelement " + i);
            }

            Console.Clear();
            Console.WriteLine("Anzahl Elemente: " + stack.Count);
            Console.WriteLine(stack.Pop() + " enfernt");
            Console.WriteLine(stack.Pop() + " enfernt");
            Console.WriteLine("Oberstes Element ohne Enfernen: " + stack.Peek());
            Console.WriteLine("Anzahl Elemente: " + stack.Count);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            int anzahl = stack.Count;
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            #endregion

            #region Hashtable

            Console.Clear();
            Hashtable ht = new Hashtable();

            ht.Add("Schlüssel_1", "Wert1");
            ht.Add(123, "Wert2");
            ht.Add(10.5, 0815);

            Console.WriteLine("Code: " + "Schlüssel_1".GetHashCode());
            Console.WriteLine("Code: " + 123.GetHashCode());
            Console.WriteLine("Code: " + 10.5.GetHashCode());

            Console.WriteLine("Einträge: {0}", ht.Count);
            Console.WriteLine("Wert abrufen: " + ht["Schlüssel_1"]);

            //foreach (var item in ht)
            //{
            //    Console.WriteLine((string)item);
            //}

            #endregion

            //Eigene Liste Mit Monatsnamen
            Monatsnamen monatsObj = new Monatsnamen();
            Console.WriteLine(monatsObj.monat[0]);
            foreach (var item in monatsObj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nEnumerator verwenden: ");
            IEnumerator enumerator =  monatsObj.GetEnumerator();

            while (enumerator.MoveNext()) 
            {
                Console.WriteLine(enumerator.Current);
                if ((string)enumerator.Current == "Jul")
                    enumerator.MoveNext();
            }

            //Abfrage über Index
            Console.WriteLine("\n\nAbfrage über Index:");
            string test = monatsObj[2];
            Console.WriteLine(test);

            monatsObj[12] = "März";
            Console.WriteLine(monatsObj[12]);

            monatsObj.SetZahl(10);
            Console.WriteLine(monatsObj.GetZahl());

            monatsObj.Zahl = 10;
        }
    }
}
