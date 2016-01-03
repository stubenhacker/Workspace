using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            string ausgabe = "";
            long ausgab = fak(n);
            ausgabe = ""+ausgab;
            Console.Write(ausgabe);

        }

        public static long fak(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return fak(n - 1) * n;
            }
        }
    }
}
