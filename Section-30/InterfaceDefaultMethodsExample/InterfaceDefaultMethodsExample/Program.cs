namespace interface_enhancements
{
  public interface IEmployee
  {
      public string Name { get; set; }

    //static method
    internal static string GetNameTitleWithStatic()
    {
      return "Mr./Ms.";
    }

    //private default interface methods

    private string GetNameTitle()
    {
      return "Mr./Ms.";
    }

    //default interface methods OR virtual extension method
    //public string GetNameInUpperCase()
    //{
    //  return Name.ToUpper();
    //}
    internal string GetNameInUpperCase()
    {
      //return GetNameTitle() + "" + Name.ToUpper();
      return IEmployee.GetNameTitleWithStatic() + "" + Name.ToUpper();
    }

    internal string GetNameInLowerCase();
    internal int GetNameLength();
  }

  public class Manager : IEmployee
  {
    private string _name = "Unknown";
    public string Name { get => _name; set => _name = value; }

    //Option 1: You can explicitly implement non-public abstract interface methods.
    string IEmployee.GetNameInLowerCase()
    {
      return Name.ToLower();
    }

    //Option 2: You can convert the non-public abstract methods as 'public'
    public int GetNameLength() {
      return Name.Length;
    }
  }

  //public class Clerk : IEmployee
  //{
  //  private string _name;
  //  public string Name { get => _name; set => _name = value; }
  //}

  class Program
  {
    static void Main()
    {
      Manager m = new Manager() { Name = "Bob" };
      //IEmployee m = new Manager() { Name = "Bob" };
      IEmployee iemp = (IEmployee)m;
      //Console.WriteLine(iemp.GetNameInUpperCase());
      //Console.WriteLine(iemp.GetNameInLowerCase());
      //Console.WriteLine(iemp.GetNameLength());
      //Console.WriteLine(m.GetNameLength());
      Console.WriteLine(IEmployee.GetNameTitleWithStatic());
      Console.ReadKey();
    }
  }

}

