
namespace records_example
{
  //C# 9 Records
  //public record Person(string Name, int Age, Address PersonAddress);
  //{
  //  //public int x { get; set; }
  //}

  //Records - 'with' Expression
  //public record Person(string Name, Address PersonAddress)
  //{
  //  public int Age { get; set; }
  //}

  //Nested Records
  //public record Address(string City, string Country);
  //{
  //  public string? Country { get; set; }
  //}

  //Records - ToString()
  #region Records - ToString()
  //public record Address(string City, string Country)
  //{
  //  public override string ToString()
  //  {
  //    return $"City is {City} in {Country}";
  //  }
  //}
  #endregion

  class PersonBase
  {

  }

  //Records - Inheritance
  public sealed record Employee(string? Name, DateTime? DateOfBirth, double? Salary) 
    : Person(Name, DateOfBirth)
  {
    public sealed override string ToString()
    {
      return $"Salary is {Salary}, {base.ToString()}";
    }
  }
  //Record - sealed ToString()
  //public record Manager: Employee(null, null, null)
  //{
  //  public override string ToString()//Error: cannot override inherited member ToString(),
                                       //  beacuse it is sealed.
  //  {
  //    return "somevalue";
  //  }
  //}

  #region Records - Construtor
  //Records - Construtor
  
  public abstract record Person(string? Name, DateTime? DateOfBirth, int? Age): IPerson //: PersonBase
  //public sealed record Person(string? Name, DateTime? DateOfBirth, int? Age): IPerson //: PersonBase
  {
    //User ==> user-defined constructor --> compiler-generated constructor
    public Person(string? name, DateTime? dateOfBirth) : this(name, dateOfBirth, null)
    {
      if (dateOfBirth != null) {
        Age = Convert.ToInt32 ((DateTime.Now.Subtract(dateOfBirth.Value).TotalDays / 365.25));
      }
    }

    //user-defined constructor (paramter-less)
    public Person() : this(null, null, null)
    {
      
    }

    //user-defined method
    public string GetName()
    {
      return $"Mr./Ms.{Name}";
    }

    public override string ToString()
    {
      return $"Name is {Name}";
    }
  }
  #endregion

  //class Manager: Employee
  //{

  //}

  public interface IPerson
  {
    string? Name { get; init; }
  }

  class Program
  {
    static void Main()
    {
      //Person p1 = new Person("Bill1", 20, new Address("London", "UK"));
      //Person p2 = new("Bill2", 32, new Address("Indi"Delhi"));
      //p1.PersonAddress.Country = "UK";
      //Person p2 = new Person("Bill1", 22, new Address("London", "UK"));
      //Person p2 = new Person("Bill1", 22, p1.PersonAddress);
      //p1.Age = 20;
      ////Person p2 = p1; //Reference Copy
      //Person p2 = p1 with { Age = 90, Name="rob" }; //Shallow Copy
      //p1.Age = 55;

      #region Records Deconstruct()
      //var (name, age, add)=p1;
      //var (name, age, (city, country))=p1;
      //var (name, _, (city, country))=p1;//Discard if we need to discard a value.

      //Console.WriteLine($"{name}, {age}, {city}, {country}");
      //Console.WriteLine($"{name}, {city}, {country}");
      # endregion

      //Console.WriteLine($"{p1.Name}, {p1.Age}, {p1.PersonAddress.City}, {p1.PersonAddress.Country}");
      //Console.WriteLine($"{p2.Name}, {p2.Age}, {p2.PersonAddress.City}, {p2.PersonAddress.Country}");
      //Console.WriteLine($"{p2.Name}, {p2.Age}, {p2.PersonAddress.city}");
      //p1.Name = "jack"; //Error: Init-only property can only be assigned in a constructor or object initializer.

      //Console.WriteLine(p1.Equals(p2));//True
      //Console.WriteLine(p1 == p2);//True
      //Console.WriteLine(p1 != p2);//False
      //Console.WriteLine(p1 != p2.PersonAddress);//Error

      //Records - ToString()
      //Console.WriteLine(p1.ToString());

      //Records - Constructor
      //Person p1 = new Person("Scott", DateTime.Parse("2001-06-04"));
      //Console.WriteLine(p1);
      //Console.WriteLine(p1.GetName());

      //Employee emp = new Employee("Scott", DateTime.Parse("1995-04-06"), 22, 6000);
      //Console.WriteLine(emp);

      //Absract/Sealed 
      //Person p1 = new Person(); 

      Employee emp = new Employee("Scott", DateTime.Parse("1995-04-06"), 6000);
      Console.WriteLine(emp);

      Console.ReadKey();
    }
  }
}