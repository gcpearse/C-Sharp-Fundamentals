namespace VerifyPassword;

class Program
{
  public static void MainFn()
  {
    string? password;

    while (true)
    {
      Console.Write("Enter password: ");
      password = Console.ReadLine();

      if (!string.IsNullOrEmpty(password))
      {
        break;
      }
      else
      {
        Console.WriteLine("Please enter a password.");
      }
    }

    while (true)
    {
      Console.Write("Confirm password: ");
      string? confirmation = Console.ReadLine();

      if (!string.IsNullOrEmpty(confirmation))
      {
        Console.WriteLine(password.Equals(confirmation) ? "Passwords match." : "Passwords do not match.");
        break;
      }
      else
      {
        Console.WriteLine("Please confirm your password.");
      }
    }
  }
}
