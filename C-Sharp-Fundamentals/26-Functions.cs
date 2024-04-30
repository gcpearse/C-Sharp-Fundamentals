namespace Functions;

class Program
{
  public static void MainFn()
  {
    GreetUser(GetName(), GetAge());
    Console.WriteLine();

    string testName = "Danny";
    int testAge = 30;

    GreetUser(
      age: testAge,
      name: testName
    );
    Console.WriteLine();

    HandleAddition();
    Console.WriteLine();

    List<string> shoppingList = ["Coffee", "Milk"];

    HandleItemSearch(shoppingList);
    Console.WriteLine();

    string name = GetName();
    string newName = GetName();

    bool isNameChanged = ChangeName(ref name, newName);
    ConfirmNameChange(isNameChanged, name);

    Dog.Bark();
  }

  static string GetName()
  {
    Console.Write("Enter name: ");
    string? name = Console.ReadLine();
    return !string.IsNullOrEmpty(name) ? name : "";
  }

  static int GetAge()
  {
    Console.Write("Enter age: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  static void GreetUser(string name, int age)
  {
    Console.WriteLine($"Hello, your name is {name} and you are {age}!");
  }

  static int GetInt(string message)
  {
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  static int SumInts(int x, int y = default)
  {
    return x + y;
  }

  static void HandleAddition()
  {
    int x = GetInt("Enter a value for x");
    int y = GetInt("Enter a value for y");
    Console.WriteLine($"The sum of {x} and {y} is {SumInts(x, y)}.");
  }

  static bool FindItemInList(string item, List<string> list, out int index)
  {
    index = -1;

    for (int i = 0; i < list.Count; i++)
    {
      if (list[i].ToLower().Equals(item.ToLower()))
      {
        index = i;
      }
    }

    return index > -1;
  }

  static void HandleItemSearch(List<string> list)
  {
    Console.Write("Enter an item to search for: ");
    string? item = Console.ReadLine();

    if (!string.IsNullOrEmpty(item))
    {
      bool isFound = FindItemInList(item, list, out int index);

      if (isFound)
      {
        Console.WriteLine($"Found {item.ToLower()} at index {index}.");
      }
      else
      {
        Console.WriteLine($"Did not find {item.ToLower()} in the list.");
      }
    }
  }

  static bool ChangeName(ref string name, string newName)
  {
    if (!string.IsNullOrEmpty(newName))
    {
      name = newName;
      return true;
    }

    return false;
  }

  static void ConfirmNameChange(bool isSuccess, string name)
  {
    Console.WriteLine(isSuccess ? $"Name updated successfully: {name}" : "New name cannot be empty.");
  }
}

class Dog
{
  public static void Bark()
  {
    Console.WriteLine("Woof!");
  }
}


/*

A static function can be accessed anywhere.
We do not need to create a new instance of a class to call a static function.

Note that we can make a parameter optional by assigning it a default value, or using [Optional] before it.

Note the use of named parameters when GreetUser is called with testAge and testName.

Note the use of out parameters in FindItemInList and HandleItemSearch.

Note the use of reference parameters in ChangeName.

*/
