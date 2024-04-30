namespace FizzBuzz;

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
        for (int i = 1; i <= number; i++)
        {
          bool isDivisibleBy3 = i % 3 == 0;
          bool isDivisibleBy5 = i % 5 == 0;

          if (isDivisibleBy3 && isDivisibleBy5)
          {
            Console.WriteLine("FizzBuzz");
          }
          else if (isDivisibleBy3)
          {
            Console.WriteLine("Fizz");
          }
          else if (isDivisibleBy5)
          {
            Console.WriteLine("Buzz");
          }
          else
          {
            Console.WriteLine(i);
          }
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
