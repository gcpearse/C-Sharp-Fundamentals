namespace Dictionaries;

class Program
{
  public static void MainFn()
  {
    Dictionary<int, string> names = new()
  {
    { 1, "James" },
    { 2, "Danny" },
    { 3, "Rob" }
  };

    for (int i = 0; i < names.Count; i++)
    {
      KeyValuePair<int, string> pair = names.ElementAt(i);
      Console.WriteLine($"{pair.Key} {pair.Value}");
    }

    Console.WriteLine();

    foreach (KeyValuePair<int, string> pair in names)
    {
      Console.WriteLine($"{pair.Key} {pair.Value}");
    }

    Console.WriteLine();

    Dictionary<string, string> teachers = new()
  {
    { "IT", "James" },
    { "Physics", "Danny" },
    { "Biology", "Rob" }
  };

    Console.Write("Enter a subject: ");
    string? subject = Console.ReadLine();

    if (!string.IsNullOrEmpty(subject))
    {
      if (teachers.TryGetValue(subject, out string? teacher))
      {
        Console.WriteLine($"{teacher} is the {subject} teacher.");
      }
      else
      {
        Console.WriteLine($"{subject} teacher not found.");
      }

      if (teachers.Remove(subject))
      {
        Console.WriteLine($"{subject} removed successfully.");
      }
      else
      {
        Console.WriteLine($"{subject} does not exist.");
      }
    }
  }
}


/*

Use the TryGetValue method of Dictionary to attempt to return the value associated with the specified key.

*/
