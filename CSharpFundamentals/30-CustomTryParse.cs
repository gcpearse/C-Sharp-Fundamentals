namespace CustomTryParse;

class Program
{
  public static void MainFn()
  {
    while (true)
    {
      Console.Write("Enter a number: ");
      string? input = Console.ReadLine();

      if (!string.IsNullOrEmpty(input) && CustomTryParse(input, out int result))
      {
        Console.WriteLine($"Your number is {result}.");
        break;
      }
      else
      {
        Console.WriteLine("Please enter a number.");
      }
    }
  }

  static bool CustomTryParse(string input, out int result)
  {
    try
    {
      result = Convert.ToInt32(input);
      return true;
    }
    catch (Exception)
    {
      result = -1;
      return false;
    }
  }
}
