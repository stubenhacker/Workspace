using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            long zahl = 20;
            bool valid = false;
            while (!valid)
            {
                long z = zahl;
                for (int i = 1; i <= 20; i++)
                {
                    if (z % i != 0)
                    {
                        zahl += 20;
                        break;
                    }
                    if (i == 20)
                    {
                        valid = true;
                    }
                }
            }
            Console.WriteLine("Die erste Zahl, die durch alle Zahlen von 1-20 teilbar ist, ist: {0}", zahl);
            //if (zahl == 232792560)
            //{
            //    Console.WriteLine("Dein Programm läuft richtig");
            //}
            Console.ReadLine();
        }
    }
}
