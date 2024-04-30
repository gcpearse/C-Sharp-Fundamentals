namespace Classes;

class Program
{
  class Person
  {
    public string name;
    public int age;

    public Person()
    {
      name = "";
    }

    public Person(string name)
    {
      this.name = name;
      age = -1;
    }

    public Person(int age)
    {
      name = "";
      this.age = age;
    }

    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
  }
  
  public static void MainFn()
  {
    Console.Write("Name: ");
    string? name = Console.ReadLine();

    Console.Write("Age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (name != null)
    {
      Person person = new(name, age);

      Console.WriteLine(person.name != "" ? $"Name: {person.name}" : "Name: Not provided.");
      Console.WriteLine(age > -1 ? $"Age: {person.age}" : "Age: Not provided.");
    }
  }
}


/*

Classes are used for more complex objects with methods and properties.

Note the four different constructors that allow Person to be instantiated with one, both, or neither of 'name' and 'age'.

*/
