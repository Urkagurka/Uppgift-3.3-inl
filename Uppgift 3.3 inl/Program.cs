using System;
using System.Net.NetworkInformation;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int pris = timmar * 80;

            if (pris > 950)
            {
                Console.WriteLine("Det kostar mer än 950kr");
            }
            else if (pris < 950)
            {
                Console.WriteLine("Det kostar " + pris + "kr");
            }

        }
    }
}
