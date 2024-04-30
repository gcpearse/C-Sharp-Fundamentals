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
        case "9": SwitchStatements.Program.MainFn(); break;
        case "10": ForLoops.Program.MainFn(); break;
        case "11": WhileLoops.Program.MainFn(); break;
        case "12": NumericFormatting.Program.MainFn(); break;
        case "13": TryParse.Program.MainFn(); break;
        case "14": TimesTable.Program.MainFn(); break;
        case "15": FizzBuzz.Program.MainFn(); break;
        case "16": StringFormatting.Program.MainFn(); break;
        case "17": Strings.Program.MainFn(); break;
        case "18": ReverseString.Program.MainFn(); break;
        case "19": VerifyPassword.Program.MainFn(); break;
        case "20": Arrays.Program.MainFn(); break;
        case "21": ArrayMethods.Program.MainFn(); break;
        case "22": Lists.Program.MainFn(); break;
        case "23": Dictionaries.Program.MainFn(); break;
        case "24": OddEvenSplit.Program.MainFn(); break;
        case "25": MultiplesArray.Program.MainFn(); break;
        case "26": Functions.Program.MainFn(); break;
        case "27": TriangleArea.Program.MainFn(); break;
        default: Console.WriteLine("Invalid argument."); break;
      }
    }
    else
    {
      Console.WriteLine("Please provide a single argument.");
    }
  }
}
