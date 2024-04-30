namespace ArrayMethods;

class Program
{
  public static void MainFn()
  {
    int[] numbers = [4, 1, 5, 3, 2];

    Array.Sort(numbers);

    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }

    Console.WriteLine();

    Array.Reverse(numbers);

    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }

    Console.WriteLine();

    Console.Write("Enter a number to search for: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int position = Array.IndexOf(numbers, number);

    if (position > -1)
    {
      Console.WriteLine($"Number {number} found at position {position}.");
    }
    else
    {
      Console.WriteLine($"Number {number} not found.");
    }

    Array.Clear(numbers, 0, numbers.Length);

    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }

    Console.WriteLine();
  }
}


/*

The indexOf method of Array can optionally take a start index and a count as additional arguments.
For example, Array.IndexOf(numbers, number, 2, 2) will start searching from index position 2.
Since the count is 2, it will only check the element at the start index and the one after that.

*/
