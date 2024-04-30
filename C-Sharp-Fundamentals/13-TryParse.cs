namespace TryParse;

class Program
{
  public static void MainFn()
  {
    bool isSuccess = false;

    while (!isSuccess)
    {
      Console.Write("Enter a number: ");

      string? userInput = Console.ReadLine();

      if (int.TryParse(userInput, out int num))
      {
        isSuccess = true;
        Console.WriteLine(num);
      }
      else
      {
        Console.WriteLine(isSuccess ? num : "Invalid input!");
      }
    }
  }
}
