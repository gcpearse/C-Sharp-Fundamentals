namespace Operations;

class Program
{
  public static void MainFn()
  {
    int age = 30;
    Console.WriteLine(age);
    age++;
    Console.WriteLine(age);
    age--;
    Console.WriteLine(age);
    age += 10;
    Console.WriteLine(age);
    age -= 5;
    Console.WriteLine(age + "\n");

    double quantity = 23;
    quantity /= 10;
    Console.WriteLine(quantity + "\n");

    string name = "James";
    name += " is a developer.";
    Console.WriteLine(name + "\n");

    int i = 0;
    Console.WriteLine(i++);
    Console.WriteLine(++i + "\n");

    int num1 = 10;
    int num2 = 3;
    Console.WriteLine(num1 % num2);
  }
}


/*

When dividing two numbers, using int will return an int, even if the precise result would include fractional parts.

Note the difference between prefix and postfix increments.

*/
