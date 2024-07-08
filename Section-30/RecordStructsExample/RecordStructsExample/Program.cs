namespace record_structs_example
{
  //public readonly record struct Person(string? Name, int? Age);
  public record struct Person(string? Name, int? Age);

  class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person("Jaxon", 30);
      //ToString(), Deconstruct(), Equals()
      Console.WriteLine(person.ToString());

      Person p2 = person;
      person.Age = 40;//will not effect the other struct variable(p2)

      Console.WriteLine(p2.ToString());
      Console.ReadKey();
    }
  }
}