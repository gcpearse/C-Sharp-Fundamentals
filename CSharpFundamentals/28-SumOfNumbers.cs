namespace SumOfNumbers;

class Program
{
  public static void MainFn()
  {
    int[] numbers1 = [];
    int[] numbers2 = [1, 2, 3];

    DisplayTotal(numbers1);
    DisplayTotal(numbers2);
  }

  static bool SumOfNumbers(int[] numbers, out int total)
  {
    total = 0;

    if (numbers.Length > 0)
    {
      total = numbers.Sum();
      return true;
    }

    return false;
  }

  static void DisplayTotal(int[] numbers)
  {
    if (SumOfNumbers(numbers, out int total))
    {
      Console.WriteLine($"Total: {total}");
    }
    else
    {
      Console.WriteLine("Empty array!");
    }
  }
}
