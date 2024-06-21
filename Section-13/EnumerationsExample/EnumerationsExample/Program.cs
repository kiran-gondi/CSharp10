class Program
{
  public static void Main()
  {
    
    Person p = new Person();
    p.Name = "jon";
    p.Email = "ramu@google.com";
    p.AgeGroup = AgeGroupEnumeration.Senior;

    Console.WriteLine(p.AgeGroup);
    Console.ReadKey();
  }
}