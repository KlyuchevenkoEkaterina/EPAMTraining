using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FibonacciNumbers
{
  class FibonacciNumbersLINQ
  {   
    List<BigInteger> fibonacciNumbers = new List<BigInteger>();

    public List<BigInteger> GetFibonacciNumbers()
    {

      fibonacciNumbers.Add(0);
      fibonacciNumbers.Add(1);
      for (int i = 0; i < 198; i++)
      {
        BigInteger nextNumber = fibonacciNumbers[i] + fibonacciNumbers[i + 1];
        fibonacciNumbers.Add(nextNumber);
      }
      return fibonacciNumbers;
    }

    public void PrintFibonacciNumbers(IEnumerable<BigInteger> numbers)
    {
      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }

    //1
    public int AmountOfSimpleNumbers()
    {
      return fibonacciNumbers.Where(elem => elem.IsSimpleNumber()).Count();
     /* var amount = from number in fibonacciNumbers
                   where number.IsSimpleNumber()
                   select number;
      return amount.Count();*/
    }

    //2
    public int AmountOfNumbersAreDividedByTheSumOfDigits()
    {
      var amount = from number in fibonacciNumbers
                   where number.IsNumbersAreDividedByTheSumOfDigits()
                   select number;
      return amount.Count();
    }

    //3
    public bool IsNumberIsDividedInto5()
    {
      return (fibonacciNumbers.Any(number => number % 5 == 0));
    }

    //5
    public IEnumerable<BigInteger> SortingInDecreasingOrder()
    {
      IEnumerable<BigInteger> doubleDigitNumbers = from number in fibonacciNumbers
                                                   where number.ToString().Length > 1
                                                   select number;

      IEnumerable<BigInteger> sortedNumbers = from number in doubleDigitNumbers
                                              orderby number.ToString()[1] descending
                                              select number;
       return sortedNumbers;
    }

    //6
    public bool IsLastTwoDigitsDividedBy3()
    {
      int index = 0; ;
      foreach (var element in fibonacciNumbers)
      {
        if (element.ToString().Length > 1 && int.Parse(element.ToString().Substring(element.ToString().Length - 2)) % 3 == 0)
        {
          index = fibonacciNumbers.IndexOf(element);
        }

        bool isExist = true;
        for (int i = index; i > index - 5; i--)
        {
          if (fibonacciNumbers[i] % 5 == 0)
          {
            return isExist;
          }
          else
          {
            isExist = false;
          }
        }
        if (!isExist)
        {
          for (int i = index; i < index + 5; i++)
          {
            if (fibonacciNumbers[i] == fibonacciNumbers[fibonacciNumbers.Count - 5])
            {
              return false;
            }
            if (fibonacciNumbers[i + 1] % 5 == 0)
            {
              return true;
            }
          }
        }

      }
      return false;
    }

    //8
    public int CountAmountOfZeros()
    {
      return fibonacciNumbers.Select(elem => elem.ToString().ToCharArray().Count(digit => digit=='0')).Sum();
      int count = 0;
      for (int j = 0; j < fibonacciNumbers.Count; j++)
      {
        char[] arrayOfDigits = fibonacciNumbers[j].ToString().ToCharArray();
        for (int i = 0; i < arrayOfDigits.Length; i++)
        {
          if (arrayOfDigits[i] == '0')
          {
            count++;
          }
        }
      }
      return count;
    }

    public int AverageAmountOfZeros()
    {
      int averageAmount = CountAmountOfZeros() / fibonacciNumbers.Count;
      return averageAmount;
    } 
  }
}