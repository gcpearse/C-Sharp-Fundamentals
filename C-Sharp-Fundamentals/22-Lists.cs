namespace Lists;

class Program
{
  public static void MainFn()
  {
    List<int> numbers = [];

    for (int i = 0; i < 3; i++)
    {
      Console.Write("Enter a number: ");
      numbers.Add(Convert.ToInt32(Console.ReadLine()));
    }

    for (int i = 0; i < numbers.Count; i++)
    {
      Console.WriteLine(numbers[i]);
    }
  }
}


/*

Note the use of Count rather than Length when working with a list.

*/
