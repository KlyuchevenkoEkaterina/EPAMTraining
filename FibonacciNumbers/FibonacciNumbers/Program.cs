using System;
using System.Numerics;

namespace FibonacciNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      /* FibonacciNumbersLINQ fibonacciNumbersLINQ = new FibonacciNumbersLINQ();
       fibonacciNumbersLINQ.PrintFibonacciNumbers(fibonacciNumbersLINQ.GetFibonacciNumbers());
       Console.WriteLine("Amount of simple numbers: {0}", fibonacciNumbersLINQ.AmountOfSimpleNumbers());
       Console.WriteLine("Amount of numbers are divided by the sum of their digits: {0}", fibonacciNumbersLINQ.AmountOfNumbersAreDividedByTheSumOfDigits());
       Console.WriteLine("Is there any number that divided by 5 ?: {0}", fibonacciNumbersLINQ.IsNumberIsDividedInto5());
       fibonacciNumbersLINQ.PrintFibonacciNumbers(fibonacciNumbersLINQ.SortingInDecreasingOrder());
       Console.WriteLine("All amount of zeros: {0}", fibonacciNumbersLINQ.CountAmountOfZeros());
       Console.WriteLine("Average amount of zeros: {0}", fibonacciNumbersLINQ.AverageAmountOfZeros());*/
      BigInteger a = 121;
      Console.WriteLine(a.IsSimpleNumber());
      Console.ReadKey();
    }
  }
}
