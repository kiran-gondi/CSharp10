//C# 9 Records
public record Person(string Name, int Age);

class Program
{
  static void Main()
  {
    Person p1 = new Person("Bill1", 22);
    Person p2 = new("Bill2", 32);
    Console.WriteLine($"{p1.Name}, {p1.Age}");
    Console.WriteLine($"{p2.Name}, {p2.Age}");
    //p1.Name = "jack"; //Error: Init-only property can only be assigned in a constructor or object initializer.
    Console.ReadKey();
  }
}