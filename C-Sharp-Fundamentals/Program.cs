namespace Fundamentals;

class Program
{
  public static void Main(string[] args)
  {
    if (args.Length == 1)
    {
      switch (args[0])
      {
        case "0": HelloWorld.Program.MainFn(); break;
        case "1": NumericDataTypes.Program.MainFn(); break;
        case "2": TextDataTypes.Program.MainFn(); break;
        case "3": TypeConversion.Program.MainFn(); break;
        case "4": Booleans.Program.MainFn(); break;
        case "5": Operations.Program.MainFn(); break;
        case "6": Constants.Program.MainFn(); break;
        case "7": ConsoleIO.Program.MainFn(); break;
        case "8": IfStatements.Program.MainFn(); break;
        default: Console.WriteLine("Invalid argument."); break;
      }
    }
    else
    {
      Console.WriteLine("Please provide a single argument.");
    }
  }
}
