namespace OddEvenSplit;

class Program
{
  public static void MainFn()
  {
    List<int> odds = [];
    List<int> evens = [];

    for (int i = 0; i <= 20; i++)
    {
      if (i % 2 != 0)
      {
        odds.Add(i);
      }
      else
      {
        evens.Add(i);
      }
    }

    Console.Write("Even: ");

    foreach (int number in evens)
    {
      Console.Write(number + " ");
    }

    Console.WriteLine();

    Console.Write("Odd: ");

    foreach (int number in odds)
    {
      Console.Write(number + " ");
    }

    Console.WriteLine();
  }
}
