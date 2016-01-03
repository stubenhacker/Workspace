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
            int[,] startMatrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            // Matrix soll um 90 Grad rotieren: alte Höhe ist neue Breite
            //                                  alte Breite ist neue Höhe
            int hoehe = startMatrix.GetUpperBound(0) + 1;
            int breite = startMatrix.GetUpperBound(1) + 1;

            

            int[,] gedrehtMatrix = new int[breite, hoehe];

            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    gedrehtMatrix[j, hoehe - 1 - i] = startMatrix[i, j];
                }
            }

            // Ausgabe der gedrehten Matrix:
            for (int i = 0; i <= gedrehtMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= gedrehtMatrix.GetUpperBound(1); j++)
                {
                    Console.Write(gedrehtMatrix[i, j]);
                }
                Console.WriteLine("");
            }

            

        }
    }
}
