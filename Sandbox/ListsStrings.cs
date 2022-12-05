using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class ListsStrings
    {
        //Write a function that returns the largest element in a list.
        static public int LargestElement()
        {
            var Array = new int[] { 0, 1, 4, 7, 10, 444 };
            Console.WriteLine("Here a list of integer");
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("And here the largest element");
            Console.WriteLine(Array.Max());
            return Array.Max();
        }

        //Write function that reverses a list, preferably in place.
        static public void ReverseList()
        {
            //creating an list of string
            List<string> Nickname = new List<string>();
            Nickname.Add("Ugo");
            Nickname.Add("Philippe");
            Nickname.Add("Jean-Edouard");
            Nickname.Add("Mickael");

            Console.WriteLine("Here the original list items");
            foreach (string item in Nickname)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");    
            //reverse the list
            Nickname.Reverse();
            Console.WriteLine("And here the reversed list");
            foreach (string item in Nickname)
            {
                Console.WriteLine(item);
            }
        }

        // Write a function that checks whether an element occurs in a list.
        static public void CheckElementInList(int x)
        {
            List<int> firstlist = new List<int>();

            // Adding elements to List
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            firstlist.Add(5);
            firstlist.Add(6);
            firstlist.Add(7);
            Console.WriteLine("Here a list of integer");
            foreach (int item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Is " + x + " in this list ?");
            // Checking whether 4 is present
            // in List or not
            Console.Write(firstlist.Contains(x));
        }

        //Write a function that returns the elements on odd positions in a list.
        static public void OddElementsInList()
        {
            // Initialize array
            int[] Array = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14};
            Console.WriteLine("Here a list of integer");
            for(int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
            Console.WriteLine("Here the elements on odd positions in this list");
            for (int i = 0; i < Array.Length; i = i+2)
            {
                Console.WriteLine(Array[i]);
            }
        }

        //Write a function that computes the running total of a list.
        static public void TotalOfList()
        {
            // Initialize array
            int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Here a list of integer");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
            Console.WriteLine("And here the sums of list");
            int total = 0;
            for (int i = 0; i <Array.Length; i++)
            {
                total = total + Array[i];
            }
            Console.WriteLine(total);
        }

        //Write a function that tests whether a string is a palindrome.
        static public void IsStringPalindrome()
        {
            //Initialise the string
            string Sentence = "Hi Everyone this is my sandbox";
            string TrueSentence = "kayak";
            Console.WriteLine("Here we have 2 sentences,Let's try if it's a palindrome or not.");
            Console.WriteLine(Sentence);
            Console.WriteLine(TrueSentence);

            // have to make it in char[] to reverse it after
            char[] ReverseSentence = Sentence.ToCharArray();
            char[] ReverseTrueSentence = TrueSentence.ToCharArray();
            //using array.reverse to reverse the string 
            Array.Reverse(ReverseSentence);
            Array.Reverse(ReverseTrueSentence);
            //convert to a string again to compare
            string RSentence = new string(ReverseSentence);
            string RTrueSentence = new string(ReverseTrueSentence);
            Console.WriteLine("So lets check if they are palindrome");
            Console.WriteLine(RSentence);
            Console.WriteLine(RTrueSentence);
            if (RSentence != Sentence)
            {
                Console.WriteLine(Sentence + " is not a palindrome");
            }
            else if (RSentence == Sentence)
            {
                Console.WriteLine(Sentence + " is a palindrome");
            }
            if (RTrueSentence != TrueSentence)
            {
                Console.WriteLine(TrueSentence + " is not a palindrome");
            }
            else if(RTrueSentence == TrueSentence)
            {
                Console.WriteLine(TrueSentence + " is a palindrome");
            }
        }
    }
}

