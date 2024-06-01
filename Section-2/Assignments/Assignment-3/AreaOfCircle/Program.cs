namespace AreaOfCircle
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double PI = 3.1456;
      int radius = 5;

      double areaOfCircle = PI * radius * radius;
      Console.WriteLine($"Area of a Circle {areaOfCircle} with radius of {radius}");

      Console.ReadKey();
    }
  }
}
