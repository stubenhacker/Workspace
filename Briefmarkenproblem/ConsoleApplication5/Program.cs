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
            int n;
            do
            {
                Console.WriteLine("Gib einen Betrag >= 20 ein, der ein Vielfaches von 5 ist: ");
                n = 0;
                int.TryParse(Console.ReadLine(), out n);
                if (n < 20 || n % 5 != 0)
                    Console.WriteLine("Ungültige Eingabe" + Environment.NewLine);
                else
                    break;
            } while (true);
            int cent25 = n / 25 - (n % 25 == 5 ? 1 : 0);
            int cent10 = (n - 25 * cent25) / 10;
            Console.WriteLine("{0} Cent = {1} * 25 Cent + {2} * 10 Cent", n, cent25, cent10);
        }
    }
}
