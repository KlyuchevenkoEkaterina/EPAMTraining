using System.Collections.Generic;
using System.Numerics;

namespace FibonacciNumbers
{
  public static class ExtensionMethod
  {
    public static bool IsSimpleNumber(this BigInteger number)
    {
      return !((number % 2 == 0 && number != 2) || (number % 3 == 0 && number != 3) || (number % 5 == 0 && number != 5));
    }

    public static bool IsNumbersAreDividedByTheSumOfDigits(this BigInteger number)
    {
      char[] arrayOfDigits = number.ToString().ToCharArray();
      int sum = 0;
      for (int i = 0; i < arrayOfDigits.Length; i++)
      {
        sum += int.Parse(arrayOfDigits[i].ToString());
      }

      return (sum != 0) ? (number % sum == 0) : false;
    }
  }
}
