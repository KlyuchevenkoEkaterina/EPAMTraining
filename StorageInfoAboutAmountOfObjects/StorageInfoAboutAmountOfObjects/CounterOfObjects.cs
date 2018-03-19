namespace StorageInfoAboutAmountOfObjects
{
  public class CounterOfObjects
  {
    public static int Counter { get; private set; }

    public CounterOfObjects()
    {
      Counter++;     
    }
  }
}
