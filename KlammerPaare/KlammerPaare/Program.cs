using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlammerPaare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den zu prüfenden String ein");
            string klammernstring = Console.ReadLine();
            bool ok = true;
            List<string> klammer = new List<string>();
            int i = 0;

            foreach (char c in klammernstring)
            {
                if (c == '(')
                {
                    klammer.Add("kl1");
                    i++;
                }
                else if (c == '[')
                {
                    klammer.Add("kl2");
                    i++;
                }
                else if (c == '{')
                {
                    klammer.Add("kl3");
                    i++;
                }
                else if (c == ')')
                {
                    if (klammer[i - 1] == "kl1")
                    {
                        klammer.RemoveAt(i - 1);
                        i--;
                    }
                    else
                        ok = false;
                }
                else if (c == ']')
                {
                    if (klammer[i - 1] == "kl2")
                    {
                        klammer.RemoveAt(i - 1);
                        i--;
                    }
                    else
                        ok = false;
                }
                else if (c == '}')
                {
                    if (klammer[i - 1] == "kl3")
                    {
                        klammer.RemoveAt(i - 1);
                        i--;
                    }
                    else
                        ok = false;
                }
            }
            if (klammer.Count != 0)
            {
                ok = false;
            }
            Console.WriteLine(ok.ToString());
            Console.ReadKey();
        }
    }
}
