using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christbaum
{
    class Program
    {
        private static void Main(string[] args)
        {
            int reihen = 10;

            //Maximale Anzahl der Sterne/Reihe im Baum
            int max_zeichen = 3 + 2 * reihen / 3;

            int count = 1;
            for (int i = 0; i < reihen / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Eine Sternzeile erstellen
                    string sternzeile = InTheMiddle(string.Empty.PadRight(count, '*'), max_zeichen);
                    Console.WriteLine(sternzeile);
                    count += 2;
                }
                count -= 4;
            }

            //Baumstamm hat mindestens eine Höhe von 1
            int stammhoehe = reihen % 3 == 0 ? 1 : reihen % 3;

            for (int i = 0; i < stammhoehe; i++)
            {
                Console.WriteLine(InTheMiddle("###", max_zeichen));
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Der übergebene string wird in die Mitte der Zeile geschoben.
        /// </summary>
        /// <param name="input">Zeileninhalt</param>
        /// <param name="rowlength">Zeilenlänge</param>
        /// <returns></returns>
        private static string InTheMiddle(string input, int rowlength)
        {
            int length = input.Length;
            int padding = (rowlength - length) / 2 + 1;

            return input.PadLeft(padding + length, ' ');
        }
    }
}
