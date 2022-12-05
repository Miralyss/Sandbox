namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci.FibonacciExecution(5);
            Console.WriteLine();
            Factorielle.FactorielleExecution(5);
            Console.WriteLine();
            Elementary.HelloWorldExecution();
            Console.WriteLine();
            Elementary.AskingName();
            Console.WriteLine();
            Elementary.AskingNumberAndPrintSum();
            Console.WriteLine();
            Elementary.AskingNumberAndChooseSumOrProduct();
            Console.WriteLine();
           // Elementary.MultiplicationTableTo12();
            Console.WriteLine();
            Elementary.PrimeNumbers();
            Console.WriteLine();
            //Elementary.GuessingSecretNumber();
            Console.WriteLine();
            Elementary.PrintNext20LeapYears();
            Console.WriteLine();
            ListsStrings.LargestElement();
            Console.WriteLine();
            ListsStrings.ReverseList();
            Console.WriteLine();
            ListsStrings.CheckElementInList(4);
            Console.WriteLine();
            ListsStrings.OddElementsInList();
            Console.WriteLine();
            ListsStrings.TotalOfList();
            Console.WriteLine();
            ListsStrings.IsStringPalindrome();
        }
    }
}