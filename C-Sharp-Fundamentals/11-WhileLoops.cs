namespace WhileLoops;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int answer = num1 * num2;
    int userAnswer;

    do
    {
      Console.Write($"Enter the value of {num1} x {num2}: ");
      userAnswer = Convert.ToInt32(Console.ReadLine());

      if (userAnswer == answer)
      {
        Console.WriteLine("Well done!");
      }
      else
      {
        Console.WriteLine("Try again...");
      }
    } while (userAnswer != answer);
  }
}


/*

Use a do while loop to execute the code in the do block at least once. 
The results of further iterations will depend on the conditional logic in the while statement.

*/
