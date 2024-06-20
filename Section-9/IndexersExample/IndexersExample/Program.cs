namespace IndexersExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car c = new Car();

      //call get accessor of indexer
      Console.WriteLine(c[0]);//Swift 
      Console.WriteLine(c["first"]);//Swift 

      //call set accessor of index
      c[0] = "Nissan";
      
      Console.WriteLine(c[0]);//Nissan

      Console.ReadKey();
    }
  }
}
