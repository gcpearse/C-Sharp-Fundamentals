namespace ClassMethods;

class Program
{
  class Person(string name, int age)
  {
    private string name = name;
    private int age = age;

    public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

    public string GetName() => name;

    public void SetAge(int age) => this.age = age >= 0 ? age : -1;

    public int GetAge() => age;

    public string ReturnDetails()
    {
      return $"Name: {name}\nAge: {age}";
    }
  }

  public static void MainFn()
  {
    Person person = new("James", 30);

    person.SetName("Danny");
    person.SetAge(31);

    Console.WriteLine(person.ReturnDetails());

    if (person.GetName() != "Invalid name" && person.GetAge() >= 0)
    {
      Console.WriteLine($"Your name is {person.GetName()} and you are {person.GetAge()}.");
    }
  }
}


/*

By making a property private, we prevent its value from being reassigned without the use of a setter.
By using a setter, we can place restrictions on the reassignment of the value in question. 
We use a getter to access a private property.

Note the optional use of expression bodied members for a simple, one-line function e.g. public string GetName() => name;
The alternative to this would be:

  public string GetName()
  {
  return name;
  }

Getters and setters should now typically be avoided in favour of properties.

*/
