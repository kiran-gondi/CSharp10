
namespace records_example
{
  //C# 9 Records
  //public record Person(string Name, int Age, Address PersonAddress);
  //{
  //  public int x { get; set; }
  //}

  //Records - 'with' Expression
  public record Person(string Name, Address PersonAddress)
  {
    public int Age { get; set; }
  }

  //Nested Records
  public record Address(string City, string Country);
  //{
  //  public string? Country { get; set; }
  //}

  class Program
  {
    static void Main()
    {
      Person p1 = new Person("Bill1", new Address("London", "UK"));
      //Person p2 = new("Bill2", 32, new Address("Indi"Delhi"));
      //p1.PersonAddress.Country = "UK";
      //Person p2 = new Person("Bill1", 22, new Address("London", "UK"));
      //Person p2 = new Person("Bill1", 22, p1.PersonAddress);
      p1.Age = 20;
      //Person p2 = p1; //Reference Copy
      Person p2 = p1 with { Age = 90, Name="rob" }; //Shallow Copy
      p1.Age = 55;

      Console.WriteLine($"{p1.Name}, {p1.Age}, {p1.PersonAddress.City}, {p1.PersonAddress.Country}");
      Console.WriteLine($"{p2.Name}, {p2.Age}, {p2.PersonAddress.City}, {p2.PersonAddress.Country}");
      //Console.WriteLine($"{p2.Name}, {p2.Age}, {p2.PersonAddress.city}");
      //p1.Name = "jack"; //Error: Init-only property can only be assigned in a constructor or object initializer.

      //Console.WriteLine(p1.Equals(p2));//True
      //Console.WriteLine(p1 == p2);//True
      //Console.WriteLine(p1 != p2);//False
      //Console.WriteLine(p1 != p2.PersonAddress);//Error

      Console.ReadKey();
    }
  }
}