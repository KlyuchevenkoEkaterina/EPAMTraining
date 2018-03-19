using System;
using System.Text;

namespace ConvertingStringToInteger
{
  public static class StringExtensionMethods
  {
    public static int ConvertStringToInteger(this String inputString)
    {
      if (!IsStringConsistsOnlyOfLetters(inputString))
      {
        throw new Exception();
      }

      IsStringHasNegativeNumber(inputString);

      StringBuilder stringBuilder = new StringBuilder();
      for (int i = 0; i < inputString.Length; i++)
      {
        if (char.IsDigit(inputString[i]))
        {
          stringBuilder.Append(inputString[i]);
          if (inputString[i] == inputString[inputString.Length - 1] || char.IsDigit(inputString[i + 1]))
          {
            continue;
          }
          else break;
        }
      }
      return int.Parse(stringBuilder.ToString());
    }

    private static bool IsStringConsistsOnlyOfLetters(string inputString)
    {
      foreach (var element in inputString)
      {
        if (char.IsDigit(element))
        {
          return true;
        }
      }
      return false;
    }

    private static void IsStringHasNegativeNumber(string inputString)
    {
      for (int i = 0; i < inputString.Length; i++)
      {
        if (inputString[i] == '-' && char.IsDigit(inputString[i + 1]))
        {
          Console.Write('-');
          break;
        }
      }
    }
  }
}