namespace ImplicitlyTypedVariablesExample
{
  public class Program
  {
    static void Main()
    {
      //namespace1.namespace2.namespace3.Person p;
      //p = new namespace1.namespace2.namespace3.Person { PersonName = "Roy" };

      var p = new namespace1.namespace2.namespace3.Person { PersonName = "Roy" };
      //var p2;
      var p2 = "Roy".ToUpper();

      Console.WriteLine(p.PersonName);
      Console.WriteLine(p2);

      Console.ReadKey();
    }
  }
}
