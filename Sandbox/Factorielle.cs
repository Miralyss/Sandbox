using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Factorielle
    {
        static public void FactorielleExecution(int x)
        {

            if (x == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                int Resultat = 1;
                for (int i = 1; i <= x; i++)
                {
                    Resultat = Resultat * i;

                }

                Console.WriteLine("La factorielle de " + x + " est " + Resultat);
            }
        }
    }
}
