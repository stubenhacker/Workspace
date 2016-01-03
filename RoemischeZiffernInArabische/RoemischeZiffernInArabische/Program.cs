using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoemischeZiffernInArabische
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string Ziel = "";
                Console.Write("Geben Sie bitte ein Jahr ein: ");
                int aJahr;
                string Jahrstring = Console.ReadLine();
                if (!int.TryParse(Jahrstring, out aJahr) || (aJahr < 0) || (aJahr > 3999))
                {
                    Console.WriteLine("Error! Ein Jahr muss eine positive , kleiner als 4000 Zahl sein");
                }
                else
                {

                    Console.Write("\n {0} wird in römischen Zahl umgewandelt. Das Ergebnis ist ", aJahr.ToString());
                    //arabischeZahle und römische Zahle aufgelistet.
                    int[] arabischZahl = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                    string[] roemischeZahl = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                    
                    while (aJahr > 0)
                    {
                        for (int i = 0; i < arabischZahl.Length; i++)
                        {
                            if (aJahr >= arabischZahl[i])
                            {
                                Ziel += roemischeZahl[i];
                                aJahr -= arabischZahl[i];
                                //i = arabischZahl.Length;
                                
                                break;
                            }
                        }
                    }
                    Console.WriteLine(Ziel);

                }

            }
            while (true);

        }
    }
}
