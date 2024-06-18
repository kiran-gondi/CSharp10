namespace RecursionExample
{

  class Sample
  {
    public double Factorial(int number)
    {
      if (number == 0)
      {
        return 1;
      }
      else
      {
        return number * Factorial(number-1);
      }
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine($"Enter a number: ");
      int n = int.Parse(Console.ReadLine());

      Sample sample = new Sample();

      double result = sample.Factorial(n);
      Console.WriteLine($"Factorial of {n} is {result}");

      Console.ReadKey();  
    }
  }
}
