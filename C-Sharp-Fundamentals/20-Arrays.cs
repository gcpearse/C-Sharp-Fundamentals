namespace Arrays;

class Program
{
  public static void MainFn()
  {
    int limit;

    while (true)
    {
      Console.Write("Enter a number between 1 and 5 to set the length of the array: ");
      limit = Convert.ToInt32(Console.ReadLine());

      if (limit > 0 && limit <= 5)
      {
        break;
      }
      else
      {
        Console.WriteLine("Try again.");
      }
    }

    int[] numbers = new int[limit];

    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write("Enter a number: ");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Numbers: ");

    for (int i = 0; i < numbers.Length - 1; i++)
    {
      Console.Write($"{numbers[i]}, ");
    }

    Console.Write($"{numbers[^1]}\n");
  }
}


/*

We can instantiate a new array with a set number of positions, e.g. int[] numbers = new int[3]

*/
