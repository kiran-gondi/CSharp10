namespace BoxingExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //primitive variable
      int x = 10;

      //Boxing (value-type to reference-type)
      object obj = x;

      Console.WriteLine(x);
      Console.WriteLine(obj);


      Console.ReadKey();
    }
  }
}
