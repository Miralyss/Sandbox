using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Fibonacci
    {
        static public void FibonacciExecution(int x)
        {
            int a = 0;
            int b = 1;
            int Resultat = a + b;
            Console.WriteLine("Voici la suite de Fibonnaci jusqu'à " + x);
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < x; i++)
            {
                Console.WriteLine(Resultat);
                a = b;
                b = Resultat;
                Resultat = a + b;


            }


        }
    }
}
