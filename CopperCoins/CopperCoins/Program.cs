using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopperCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe des Benutzers lesen und speichern.
            Console.WriteLine("Geben Sie einen Betrag in Cent an: ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int coins = 0;
            int value = userValue;

            //Endwert berechnen.
            while (value > 0)
            {
                if (value >= 5)
                {
                    value -= 5;
                    coins++;
                }
                else if (value >= 2)
                {
                    value -= 2;
                    coins++;
                }
                else if (value >= 1)
                {
                    value -= 1;
                    coins++;
                }
            }

            Console.WriteLine("Sie brauchen mindestens {0} Münzen!", coins);
            Console.ReadKey();
        }
    }
}
