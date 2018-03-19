using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingStringToInteger
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the string: ");
      try
      {
        string inputString = Console.ReadLine();
        Console.Write(inputString.ConvertStringToInteger());

      }
      catch (Exception)
      {
        Console.WriteLine("There in no numbers in input string.");
      }
      Console.ReadKey();
    }
  }
}