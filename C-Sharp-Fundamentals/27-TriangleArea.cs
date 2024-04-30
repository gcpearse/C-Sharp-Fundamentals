namespace TriangleArea;

class Program
{
  public static void MainFn()
  {
    decimal width = GetDecimal("Enter width: ");
    decimal height = GetDecimal("Enter height: ");

    decimal area = FindTriangleArea(width, height);

    Console.WriteLine($"Area: {area}");
  }

  static decimal GetDecimal(string message)
  {
    Console.Write(message);

    return Convert.ToDecimal(Console.ReadLine());
  }

  static decimal FindTriangleArea(decimal width, decimal height)
  {
    return width * height / 2;
  }
}
