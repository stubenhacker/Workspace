using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoppeltVerketteteListe
{
    class Program
    {
        static void Main(string[] args)
        {
            DoppelteListe dl = new DoppelteListe();
            bool programmAbbruch = false;

            while (!programmAbbruch)
            {
                if (dl.istLeer())
                {
                    Console.WriteLine("Liste ist leer");
                    Console.WriteLine("1. fe (Fuege ein am Anfang)");
                    Console.WriteLine("2. fe (Fuege ein am Ende)");
                    Console.WriteLine("3. la (Loesche am Anfang)");
                    Console.WriteLine("4. le (Loesche am Ende)");
                    Console.WriteLine("5. x (Programmabruch)");
                }
                else
                {
                    Console.WriteLine("Inhalt vorwärts: " + dl.toString(0));
                    Console.WriteLine("Inhalt rückwärts: " + dl.toString(1));
                    Console.WriteLine("Anzahl: " + dl.anzahlElemente());
                    Console.WriteLine("Erstes Element: " + dl.getElementAmAnfang());
                    Console.WriteLine("Letztes Element: " + dl.getElementAmEnde());
                }

                string kommando = Console.ReadLine();

                switch ("fafelalex".IndexOf(kommando))
                {
                    case 0: // fa
                        dl.fuegeEinAmAnfang(Console.ReadLine());
                        break;
                    case 2: // fe
                        dl.fuegeEinAmEnde(Console.ReadLine());
                        break;
                    case 4: // la
                        dl.loescheAmAnfang();
                        break;
                    case 6: // le
                        dl.loescheAmEnde();
                        break;
                    case 8: // x
                        programmAbbruch = true;
                        break;
                    default:
                        Console.WriteLine("Verstehe ich nicht...");
                        break;
                }
            }
            Console.WriteLine("Ciao");
        }
    }
}
