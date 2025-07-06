using System;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative integer to calculate its Fibonacci number:");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int result = FibonacciCalculator.Fibonacci(n);
                Console.WriteLine($"Fibonacci({n}) = {result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer.");
            }
        }
    }
}
