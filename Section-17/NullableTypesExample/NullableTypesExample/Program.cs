namespace NullableTypesExample
{

  class Person
  {
      //public Nullable<int> NoOfChildren { get; set; }
          //OR
      public int? NoOfChildren { get; set; }
  }

  public class Program
  {
    static void Main(string[] args)
    {
      //create object
      Person p1 = new Person() { NoOfChildren = 2 };
      Person p2 = new Person() { NoOfChildren = null };
      Person p3 = null; //Valid for classes

      Console.WriteLine(p1.NoOfChildren);
      //if (p2.NoOfChildren != null)
      if (p2.NoOfChildren.HasValue)
      {
        int x = p2.NoOfChildren.Value;
        Console.WriteLine(x);
      }

      Console.ReadKey();
    }
  }
}
