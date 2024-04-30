namespace Structures;

class Program
{
  struct Person(string name, int age)
  {
    public string name = name;
    public int age = age;
  }

  public static void MainFn()
  {
    Person person = GetPerson();

    Console.WriteLine($"{person.name} is {person.age}.");
  }

  static Person GetPerson()
  {
    string? name;
    int age;

    while (true)
    {
      Console.Write("Enter your name: ");
      name = Console.ReadLine();

      if (!string.IsNullOrEmpty(name))
      {
        break;
      }
    }

    while (true)
    {
      try
      {
        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        break;
      }
      catch (Exception)
      {
        continue;
      }
    }

    return new Person(name, age);
  }
}


/*

A struct is a value type, while a class is a reference type.
Structs are typically used to represent small and simple data types.

*/
