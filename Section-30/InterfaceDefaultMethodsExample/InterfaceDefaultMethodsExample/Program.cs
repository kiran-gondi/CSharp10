namespace interface_enhancements
{
  public interface IEmployee
  {
      public string Name { get; set; }

    //default interface methods OR virtual extension method
    public string GetNameInUpperCase()
    {
      return Name.ToUpper();
    }
  }

  public class Manager : IEmployee
  {
    private string _name;
    public string Name { get => _name; set => _name = value; }
  }

  public class Clerk : IEmployee
  {
    private string _name;
    public string Name { get => _name; set => _name = value; }
  }

  class Program
  {
    static void Main()
    {
      Manager m = new Manager() { Name = "Bob" };
      //IEmployee m = new Manager() { Name = "Bob" };
      IEmployee iemp = (IEmployee)m;
      Console.WriteLine(iemp.GetNameInUpperCase());
      Console.ReadKey();
    }
  }

}

