namespace ReverseString;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter a message: ");
    string? message = Console.ReadLine();

    if (!string.IsNullOrEmpty(message))
    {
      Console.WriteLine($"Your message: {message}");
      Console.Write("Your message in reverse: ");

      for (int i = message.Length - 1; i >= 0; i--)
      {
        Console.Write(message[i]);
      }

      Console.WriteLine();
    }
  }
}
