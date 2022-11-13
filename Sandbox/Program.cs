namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci.FibonacciExecution(5);
            Console.WriteLine("");
            Factorielle.FactorielleExecution(5);
            Console.WriteLine("");
            Elementary.HelloWorldExecution();
            Console.WriteLine("");
            Elementary.AskingName();
            Console.WriteLine("");
            Elementary.AskingNumberAndPrintSum();
            Console.WriteLine("");
            Elementary.AskingNumberAndChooseSumOrProduct();
            Console.WriteLine("");
            Elementary.MultiplicationTableTo12();
        }
    }
}