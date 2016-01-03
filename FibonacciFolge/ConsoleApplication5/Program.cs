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
            int eingabe = 10;
            for (int i = 0; i < eingabe; i++)
            {
                Console.Write(fibonacci(i)+ " ");
            }


        }

        private static int fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            int first = 0;
            int second = 1;
            int nth = 1;

            for (int i = 2; i <= n; i++)
            {
                nth = first + second;
                first = second;
                second = nth;
            }
            return nth;
        }
    }
}
