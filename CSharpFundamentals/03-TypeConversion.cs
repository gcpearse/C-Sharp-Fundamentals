namespace TypeConversion;

class Program
{
  public static void MainFn()
  {
    string textAge = "30";
    int age = Convert.ToInt32(textAge);
    Console.WriteLine(age);

    string textBigNumber = "1000000000";
    long bigNumber = Convert.ToInt64(textBigNumber);
    Console.WriteLine(bigNumber);

    string textNegativeNumber = "-55.5";
    double negativeNumber = Convert.ToDouble(textNegativeNumber);
    Console.WriteLine(negativeNumber);

    string textPreciseNumber = "7.000001";
    float preciseNumber = Convert.ToSingle(textPreciseNumber);
    Console.WriteLine(preciseNumber);

    string textDecimal = "10.99";
    decimal price = Convert.ToDecimal(textDecimal);
    Console.WriteLine(price);
  }
}


/*

We use Convert.ToInt32 because an int is, by definition, a 32-bit signed integer.
We use Convert.ToInt64 because a long is, by definition, a 64-bit signed integer.
We use Convert.ToSingle because a float is, by definition, a single-precision floating-point number.

*/
