namespace MultiplesArray;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a length: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int[] multiples = new int[length];

    for (int i = 0; i < length; i++)
    {
      multiples[i] = number * (i + 1);
    }

    foreach (int multiple in multiples)
    {
      Console.Write(multiple + " ");
    }

    Console.WriteLine();
  }
}
