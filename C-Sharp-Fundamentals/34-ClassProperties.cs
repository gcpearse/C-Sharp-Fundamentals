namespace ClassProperties;

class Program
{
  class Person(string name, int age)
  {
    private string name = name;
    private int age = age;

    public string Name
    {
      get => name;
      set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
    }

    public int Age
    {
      get => age;
      set => age = value >= 0 ? value : -1;
    }

    public override string ToString()
    {
      return $"Name: {Name}\nAge: {Age}";
    }

    // public override bool Equals(object? obj)
    // {
    //   if (obj is Person)
    //   {
    //     Person? person = obj as Person;
    //     return Name.Equals(person!.Name) && Age == person.Age;
    //   }

    //   return false;
    // }
  }

  public static void MainFn()
  {
    Person person = new("Danny", 31);

    Console.WriteLine(person);

    person.Name = "James";
    person.Age = 31;

    Console.WriteLine($"{person.Name} is {person.Age}.");
  }
}


/*

In this example, Name and Age are properties. Note the use of Pascal case.
As get and set are available on those properties, we can get and set their values without calling a function.

Whenever additional logic is required, we should use regular properties, as seen in this example.
If no additional logic is required, we can use auto-implemented properties. Take the following code:

  private string name = name;

  public string Name
  {
    get => name;
    set => name = value;
  }

This can be replaced with the following code:

  public string Name { get; set;}

Going forward, favour properties and auto-implemented properties over getters and setters.

Note the use of the public override string ToString() method.
This allows us to run Console.WriteLine(person) and makes the ReturnDetails method from the ClassMethods example redundant.

*/
