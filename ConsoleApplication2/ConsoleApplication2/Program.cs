using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString = "Hello";
            Console.WriteLine(myString);

            int baumHoehe = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < baumHoehe; i++)
            {
                for(int j = 0; j < baumHoehe-1-i; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m< i * 2 + 1; m++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
