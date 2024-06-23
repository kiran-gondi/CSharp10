namespace NullPropogationOperatorExample
{

  class Person
  {
    public int Age;
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //p1 is null
      //Person p1 = null;

      Person p1 = new Person() { Age = 23 };

      //print Age
      //Console.WriteLine((p1 == null) ? null : Convert.ToString(p1.Age));
      Console.WriteLine(p1?.Age);

      Console.ReadKey();
    }
  }
}
