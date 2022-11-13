using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Elementary
    {
        static public void HelloWorldExecution()
        {
            //Just a program that print Hello World to the screen
            //LA BASE 
            Console.WriteLine("Hello World");
        }

        static public void AskingName()
        {
            //a program that asks the user for their name and greets them with their name.
            //Modify the previous program such that only the users Alice and Bob are greeted with their names.
            string name = "";

            Console.WriteLine("What's your name ?");
            name = Console.ReadLine();
            if (name == "Bob" || name == "Alice")
            {
                Console.WriteLine("Nice to meet you, " + name);
            }
            else
                Console.WriteLine("ratio " + name);
        }

        static public void AskingNumberAndPrintSum()
        {
            //Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
            //Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
            Console.WriteLine("Put a number");
            int ConvertStringToInt = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = 1; i <= ConvertStringToInt; i++)
            {
                if (i%3 == 0 || i%5 == 0)//modulo du coup pour vérifier si n est un multiple de 3 ou 5 
                {
                    x = x + i;
                    // ici je m'étais trompé j'avais fait x = i+i mais le résultat n'étais pas bon
                }

            }
            Console.WriteLine("The sum of number 1 to " + ConvertStringToInt + " with only multiple of 3 or 5 is "+ x);

        }

        static public void AskingNumberAndChooseSumOrProduct()
        {
            //Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.
            Console.WriteLine("Put a number");
            int ConvertStringToInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose 1 for Sum or choose 2 for Product");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                int x = 0;
                for (int i = 1; i <= ConvertStringToInt; i++)
                {
                    x = x + i;
                    // ici je m'étais trompé j'avais fait x = i+i mais le résultat n'étais pas bon
                }
                Console.WriteLine("The sum of number 1 to " + ConvertStringToInt + " is " + x);
            }
            if (choice == 2)
            {
                int x = 1;
                for (int i = 1; i <= ConvertStringToInt; i++)
                {
                    x = x * i;
                    //du coup pour le produit la meme chose mais avec multiplication
                }
                Console.WriteLine("The product of number 1 to " + ConvertStringToInt + " is " + x);
            }

        }

        static public void MultiplicationTableTo12()
        {
            //Write a program that prints a multiplication table for numbers up to 12.
            Console.WriteLine("Voici les tables de multiplication jusqu'à 12");
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(j + "*" + i + "=" + j*i);
                }
                Console.WriteLine("");
                //petit espace pour une meilleure visibilité
            }
        }
    }
}
