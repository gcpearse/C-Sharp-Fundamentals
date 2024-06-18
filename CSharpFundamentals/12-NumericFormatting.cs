using System.Globalization;

namespace NumericFormatting;

class Program
{
  public static void MainFn()
  {
    double value = 1000D / 12.34D;

    Console.WriteLine(value);
    Console.WriteLine(string.Format("{0:0}", value));
    Console.WriteLine(string.Format("{0:0.#}", value));
    Console.WriteLine(string.Format("{0:0.0}", value));
    Console.WriteLine(string.Format("{0:0.00}", value));

    double price = -10D / 3D;

    Console.WriteLine(price);
    Console.WriteLine(string.Format("£{0:0.00}", price));
    Console.WriteLine(price.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
    Console.WriteLine(price.ToString("C0", CultureInfo.CreateSpecificCulture("en-GB")));
    Console.WriteLine(price.ToString("C1", CultureInfo.CreateSpecificCulture("en-GB")));
    Console.WriteLine(price.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB")));
  }
}


/*

The use of price.ToString("C") tells the compiler that we wish to display a currency.
We can use the CultureInfo.CreateSpecificCulture format provider to specify the currency we wish to display.

*/
