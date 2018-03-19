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
      //int index = IsStringHasNegativeNumber(inputString); 
      //int result = Ibh(inputString, index); 
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
      int result = int.Parse(stringBuilder.ToString());
      return result;
    }

    private static bool IsStringConsistsOnlyOfLetters(string inputString)
    {
      char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      foreach (var number in numbers)
      {
        foreach (var element in inputString)
        {
          if (inputString.Contains(number.ToString()))
          {
            return true;
          }
        }
      }
      return false;
    }

    //private static int IsStringHasNegativeNumber(string inputString) 
    //{ 
    // StringBuilder stringBuilder = new StringBuilder(); 
    // int index = 0; 
    // for(int i = 0; i < inputString.Length; i++) 
    // { 
    // if(inputString[i]=='-' && char.IsDigit(inputString[i + 1])) 
    // { 
    // Console.Write('-'); 
    // index = inputString.IndexOf(inputString[i]); 
    // break; 
    // } 
    // } 
    // return index; 

    //} 

    //private static int Ibh(string inputString, int index) 
    //{ 
    // StringBuilder stringBuilder = new StringBuilder(); 
    // for (int i = index; i < inputString.Length; i++) 
    // { 
    // if (char.IsDigit(inputString[i+1])) 
    // { 
    // stringBuilder.Append(inputString[i+1]); 
    // if (inputString[i+1] == inputString[inputString.Length - 1] || char.IsDigit(inputString[i + 2])) 
    // { 
    // continue; 
    // } 
    // else break; 
    // } 

    // } 
    // int result = int.Parse(stringBuilder.ToString()); 
    // return result; 
    //} 
  }
}