namespace Exceptions
{
  class Program
  {
    public static void MainFn()
    {
      while (true)
      {
        try
        {
          Console.Write("Enter a number: ");
          int num = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine($"Your number is {num}.");

          break;
        }
        catch (FormatException)
        {
          Console.WriteLine("Please enter a number.");
        }
        catch (OverflowException)
        {
          Console.WriteLine("Please enter a number smaller than 2,147,483,648.");
        }
        catch (Exception e)
        {
          Console.WriteLine($"Error: {e.Message}");
        }
      }
    }
  }
}


/*

Hovering over ToInt32 will display information including the possible exceptions that can be handled.

We can use a generic, catch-all catch block at the end of the chain to handle any exceptions not specifically handled in earlier catch blocks.

*/
