namespace Strings;

class Program
{
  public static void MainFn()
  {
    Console.Write("Enter your name: ");
    string? name = Console.ReadLine();

    if (name != string.Empty)
    {
      Console.WriteLine($"Your name is {name}.");
    }
    else
    {
      Console.WriteLine("Missing name.");
    }

    Console.WriteLine();

    string word1 = "example";
    string word2 = "example";

    if (word1.Equals(word2))
    {
      Console.WriteLine($"Yes, '{word1}' and '{word2}' match.");
    }
    else
    {
      Console.WriteLine($"No, '{word1}' and '{word2}' do not match.");
    }

    Console.WriteLine();

    string message = "This is a message.";

    for (int i = 0; i < message.Length; i++)
    {
      Console.Write(message[i]);
      Thread.Sleep(200);
    }

    Console.WriteLine();

    Console.WriteLine(message.Contains('a'));

    Console.WriteLine();

    string? noValue = null;

    if (string.IsNullOrEmpty(noValue))
    {
      Console.WriteLine("Null or empty value detected.");
    }
  }
}


/*

Note that the Equals method, unlike the equality operator ==, checks and compares the value of two variables but not their reference in memory.

We can use Thread.Sleep, passing in a time in milliseconds, to suspend the current thread for that length of time.

*/
