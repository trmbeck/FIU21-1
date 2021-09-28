using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Server meinSubbaDubbaServer = new Server();
            Terminal terminal = new Terminal();

            terminal.ServerReferenz = meinSubbaDubbaServer;

            meinSubbaDubbaServer.setIPAdresse(1234567123);

            uint okt1 = meinSubbaDubbaServer.GetOktett1();
            uint okt2 = meinSubbaDubbaServer.GetOktett2();
            uint okt3 = meinSubbaDubbaServer.GetOktett3();
            uint okt4 = meinSubbaDubbaServer.GetOktett4();

            Console.WriteLine(okt1 + "." + okt2 + "." + okt3 + "."+ okt4);

            Console.ReadLine();
        }
    }

    class Rechner
    {
        protected string Name;
        protected uint IPAdress;
        
        public void setIPAdresse(uint ip)
        {
            IPAdress = ip;
        }
        public uint GetOktett1()
        {
            uint oktett = 0;
            oktett = IPAdress >> 24;
            oktett = oktett & 255;
            return oktett;
        }

        public uint GetOktett2()
        {
            uint oktett = 0;
            oktett = IPAdress >> 16;
            oktett = oktett & 255;
            return oktett;
        }
        public uint GetOktett3()
        {
            uint oktett = 0;
            oktett = IPAdress >> 8;
            oktett = oktett & 255;
            return oktett;
        }
        public uint GetOktett4()
        {
            uint oktett = 0;
            oktett = IPAdress & 255;
            return oktett;
        }
    }

    class Server : Rechner
    {
        protected int AnzahlCPU;
        protected double LeistungCPU;
        protected string Funktion;
        protected double LeistungNetzwerk;
        protected int AnzahlHD;
        protected double HDKapazität;
    }

    class Workstation : Rechner
    {
        protected double LeistungCPU;
        protected int RAM;
        protected double HDKapazität;
    }

    class GrafischerArbeitsplatz : Workstation
    {
        protected float Monitorgrösse;
        protected string Grafikkartenname;
    }

    class Terminal
    {
        protected string Standort;
        public Server ServerReferenz;

        public string GetStandort()
        {
            return Standort;
        }

        public void SetStandort(string s)
        {
            Standort = s;
        }
    }
}
