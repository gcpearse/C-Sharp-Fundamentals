namespace TimesTable;

class Program
{
  public static void MainFn()
  {
    while (true)
    {
      Console.Write("Enter a number: ");

      string? userInput = Console.ReadLine();

      if (int.TryParse(userInput, out int number))
      {
        for (int i = 1; i <= 10; i++)
        {
          Console.WriteLine($"{i} x {number} = {i * number}");
        }
        break;
      }
      else
      {
        Console.WriteLine("Invalid input");
      }
    }
  }
}
