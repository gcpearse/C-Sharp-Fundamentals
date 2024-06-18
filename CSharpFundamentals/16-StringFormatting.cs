namespace StringFormatting;

class Program
{
  public static void MainFn()
  {
    string path = @"C:\Users\User\Desktop\C#";
    string greeting = @"Hello, ""stranger""...";

    Console.WriteLine(path);
    Console.WriteLine(greeting);

    Console.WriteLine();

    string name = "James";
    int age = 30;

    Console.WriteLine(string.Concat("Your name is ", name, " and you are ", age, "."));
    Console.WriteLine("Your name is {0} and you are {1}.", name, age);
    Console.WriteLine($"Your name is {name} and you are {age}.");
  }
}


/*

We can introduce a string with the verbatim identifier @ to create a verbatim string literal without the need for escape characters.
Use double quotation marks within a verbatim string literal if quotation marks are part of the desired output.

Note the use of concatenation on line 18, composite formatting on line 19, and string interpolation on line 20.

*/
