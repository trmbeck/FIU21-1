using System;
using System.Diagnostics;

namespace IPAdressenÜbung
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAdresse ip1 = new IPAdresse("1033.1.1.1");
            ip1.SetIP("1.2.3.4");
            Debug.WriteLine(ip1.GetIP());

            ip1.IpAdresse = "4.3.45.11";
            Console.WriteLine(ip1.IpAdresse);

        }
    }
}
