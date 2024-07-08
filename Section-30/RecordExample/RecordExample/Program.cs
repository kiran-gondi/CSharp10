namespace records_example
{
  //C# 9 Records
  public record Person(string Name, int Age, Address PersonAddress);

  //Nested Records
  public record Address(string city);

  class Program
  {
    static void Main()
    {
      Person p1 = new Person("Bill1", 22, new Address("London"));
      Person p2 = new("Bill2", 32, new Address("Delhi"));
      Console.WriteLine($"{p1.Name}, {p1.Age}, {p1.PersonAddress.city}");
      Console.WriteLine($"{p2.Name}, {p2.Age}, {p2.PersonAddress.city}");
      //p1.Name = "jack"; //Error: Init-only property can only be assigned in a constructor or object initializer.
      Console.ReadKey();
    }
  }
}