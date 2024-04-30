namespace IfStatements;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter your name: ");
    string? name = Console.ReadLine();

    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your name is {name} and you are {age}.");

    if (age < 0)
    {
      Console.WriteLine("Invalid age!");
    }
    else
    {
      if (age >= 18 && age <= 25)
      {
        Console.WriteLine("You are between 18 and 25 years old.");
      }
      else if (age >= 26)
      {
        Console.WriteLine("You are over 25.");
      }
      else
      {
        Console.WriteLine("You are under 18.");
      }
    }

    Console.WriteLine(age >= 18 ? "You are eligible to vote." : "You are ineligible to vote.");
  }
}


/*

Note the use of the ternary operator.

*/
