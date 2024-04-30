namespace ForLoops;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter a number between 1 and 10: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count <= 0)
    {
      Console.WriteLine("Enter a positive integer.");
    }
    else if (count > 20)
    {
      Console.WriteLine("Enter a smaller number.");
    }
    else
    {
      for (int i = 1; i <= count; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
