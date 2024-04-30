﻿namespace Fundamentals;

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
        default: Console.WriteLine("Invalid argument."); break;
      }
    }
    else
    {
      Console.WriteLine("Please provide a single argument.");
    }
  }
}
