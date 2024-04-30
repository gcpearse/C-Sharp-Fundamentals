namespace ConsoleIO;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter your name: ");
    string? name = Console.ReadLine();

    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your name is {name} and you are {age}.");
  }
}


/*

Use Console.Write to allow the input to be entered on the same line in the terminal window.

*/
