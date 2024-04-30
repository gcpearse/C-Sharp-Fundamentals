namespace NumericDataTypes;

class Program
{
  public static void MainFn()
  {
    int age = 30;
    Console.WriteLine(age);

    int x = 10, y = 20, z = 30;
    Console.WriteLine(x + y + z + "\n");

    Console.WriteLine(int.MaxValue);
    Console.WriteLine(int.MinValue + "\n");

    long bigNumber = 1000000000L;
    Console.WriteLine(bigNumber);

    Console.WriteLine(long.MaxValue);
    Console.WriteLine(long.MinValue + "\n");

    double negativeNumber = -55.5;
    Console.WriteLine(negativeNumber);

    Console.WriteLine(double.MaxValue);
    Console.WriteLine(double.MinValue + "\n");

    float preciseNumber = 7.000001F;
    Console.WriteLine(preciseNumber);

    Console.WriteLine(float.MaxValue);
    Console.WriteLine(float.MinValue + "\n");

    decimal price = 10.99M;
    Console.WriteLine(price);
    Console.WriteLine(decimal.MaxValue);
    Console.WriteLine(decimal.MinValue + "\n");
  }
}


/*

The C# compiler will register a whole number as an int.
We use a capital L after a long to tell the compiler that the variable should be processed as a long.

The C# compiler will register a number with a decimal point as a double.
We use a capital F after a float to tell the compiler that the variable should be processed as a float.
We use a capital M after a decimal to tell the compiler that the variable should be processed as a decimal.

*/
