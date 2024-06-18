namespace Constants;

class Program
{
  public static void MainFn()
  {
    const int vat = 20;
    const double percentageVat = vat / 100D;

    int balance = 1000;

    Console.WriteLine(balance * percentageVat);
  }
}


/*

Note the need to use 100D on line 8 to ensure the operation returns a number with fractional parts.

*/
