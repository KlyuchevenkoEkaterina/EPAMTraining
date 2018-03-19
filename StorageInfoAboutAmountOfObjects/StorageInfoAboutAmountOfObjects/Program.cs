using System;

namespace StorageInfoAboutAmountOfObjects
{
  class Program
  {
    static void Main(string[] args)
    {
      CounterOfObjects counterOfObjects1 = new CounterOfObjects();
      CounterOfObjects counterOfObjects2 = new CounterOfObjects();
      CounterOfObjects counterOfObjects3 = new CounterOfObjects();

      Console.WriteLine(CounterOfObjects.Counter.ToString());

      Console.ReadKey();
    }
  }
}
