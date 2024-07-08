using System.Diagnostics;

enum MaritalStatus
{
  Unmarried, Married
}
class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
    public MaritalStatus PersonMaritalStatus { get; set; }

    //Pattern Matching - Positional Pattern
    public void Deconstruct(out Person person, out string? gender, out int? age, out MaritalStatus maritalStatus)
    {
    //OLD WAY
    //person = this;
    //gender = this.Gender;
    //age = this.Age;
    //maritalStatus = this.PersonMaritalStatus;

    //ANOTHER WAY
    (person, gender, age, maritalStatus) = (this, this.Gender, this.Age, this.PersonMaritalStatus);
    }
}

class Employee: Person
{
    public double? Salary { get; set; }
}

class Customer : Person
{
  public double? CustomerBalance { get; set; }
}

class Supplier : Person
{
  public double? SupplierBalance { get; set; }
}

class Manager : Employee
{

}

class Descriptor
{
  public static string GetDescription(Person person)
  {
    #region Old way of casting without Pattern Matching

    /*if (person.GetType() == typeof(Employee))
    {
      Employee emp = (Employee)person;
      return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}";
    }
    else if (person.GetType() == typeof(Customer))
    {
      Customer cust = (Customer)person;
      return $"{person.Name}, {person.Age}, {person.Gender}, {cust.CustomerBalance}";
    }
    else if (person.GetType() == typeof(Supplier))
    {
      Supplier sup = (Supplier)person;
      return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";
    }
    else
      return $"{person.Name}, {person.Age}, {person.Gender}"; */
    #endregion


    #region C# 9 Pattern Matching - Type Pattern
    /*if (person is Employee emp) //C# 9 Pattern Matching - Type Pattern
    {
      return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}";
    }
    else if (person is Customer cust)
    {
      return $"{person.Name}, {person.Age}, {person.Gender}, {cust.CustomerBalance}";
    }
    else if (person is Supplier sup)
    {
      return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";
    }
    else
      return $"{person.Name}, {person.Age}, {person.Gender}"; */
    #endregion

    #region C# 9 Pattern Matching - Switch-Case Pattern
    switch (person)
    {
      case Employee emp:
        return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}";
      case Customer cust:
        return $"{person.Name}, {person.Age}, {person.Gender}, {cust.CustomerBalance}";
      case Supplier sup:
        return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";
      //break;
      default:
        return $"{person.Name}, {person.Age}, {person.Gender}";
    }
    #endregion
  }


  #region C# 9 Pattern Matching - When Pattern
  public static string GetDescriptionWithWhen(Person person)
  {
    //Pattern Matching - When Pattern
    //switch (person)
    //{
    //  case Person p when p.Age < 20 && p.Age > 13: //Type Pattern, Variable Pattern and When Pattern
    //    return $"{p.Name} is a Teenager";
    //  case Person p when p.Age < 13:
    //    return $"{p.Name} is Child";
    //  case Person p when p.Age >= 20 && p.Age < 60:
    //    return $"{p.Name} is Adult";
    //  case Person p when p.Age > 60:
    //    return $"{p.Name} is Senior Citizen";
    //  default:
    //    return $"{person.Name} is a person";
    //}

    //Pattern Matching - Switch Expression Pattern
    //string result = person switch
    //{
    //  Person p when p.Age < 20 && p.Age > 13 => $"{p.Name} is a Teenager",
    //  Person p when p.Age < 13 => $"{p.Name} is Child",
    //  Person p when p.Age >= 20 && p.Age < 60 => $"{p.Name} is Adult",
    //  Person p when p.Age > 60 => $"{p.Name} is Senior Citizen",
    //  _ => $"{person.Name} is a person"
    //};
    //return result;

    //Pattern Matching - Relational & Logical Pattern
    //string result = person switch
    //{
    //  Person p when p.Age is <= 20 and >= 13 => $"{p.Name} is a Teenager", //p.Age <= 20 and p.Age >= 13
    //  Person p when p.Age is < 13 => $"{p.Name} is Child", //p.Age < 13
    //  Person p when p.Age is >= 20 and < 60 => $"{p.Name} is Adult", //p.Age >= 20 and p.Age < 60
    //  Person p when p.Age is >= 60 and not (100 or 200)  => $"{p.Name} is Senior Citizen", //p.Age > 60
    //  Person p when p.Age is 100 or 200 => $"{p.Name} is centenarian", //p.Age == 100 || p.Age == 200
    //  _ => $"{person.Name} is a person"
    //};
    //return result;

    //Pattern Matching - Property Pattern
    string result = person switch
    {
      Person {Age:<=20 and >=13 } p => $"{p.Name} is a Teenager", //p.Age <= 20 and p.Age >= 13
      Person {Age:<13 } p => $"{p.Name} is Child", //p.Age < 13
      Person {Age:>=20 and <60} p => $"{p.Name} is Adult", //p.Age >= 20 and p.Age < 60
      Person {Age:>=60 and not (100 or 200) } p => $"{p.Name} is Senior Citizen", //p.Age > 60
      Person {Age:100 or 200} p => $"{p.Name} is centenarian", //p.Age == 100 || p.Age == 200
      _ => $"{person.Name} is a person"
    };
    return result;

  }
  #endregion

  public static string GetDescriptionWithMultipleProperitesPattern(Person person)
  {
    //Pattern Matching - Property Pattern along with Multiple Properties
    //Master, Mr, Miss, Ms, Mx
    //return person switch
    //{
    //  Person { Gender: "Female", PersonMaritalStatus: MaritalStatus.Unmarried } => $"Miss.{person.Name}",
    //  Person { Gender: "Female", PersonMaritalStatus: MaritalStatus.Married } => $"Mrs.{person.Name}",
    //  Person { Gender: "Male", Age: < 18 } => $"Master.{person.Name}",
    //  Person { Gender: "Male", Age: >= 18 } => $"Mr.{person.Name}",
    //  Person { Gender: not ("Male" or "Female") } => $"Mx.{person.Name}",
    //  _ => $"{person.Name}"
    //};

    //Pattern Matching - Tuple Pattern
    //return (person, person.Gender, person.Age, person.PersonMaritalStatus) switch //Tuple
    //{
    //  (Person, "Female",_, MaritalStatus.Unmarried) => $"Miss.{person.Name}",
    //  (Person, "Female",_, MaritalStatus.Married) => $"Mrs.{person.Name}",
    //  (Person, "Male", <18,_) => $"Master.{person.Name}",
    //  (Person, "Male", >=18,_) => $"Mr.{person.Name}",
    //  (Person, not ("Male" or "Female"),_,_) => $"Mx.{person.Name}",
    //  _ => $"{person.Name}"
    //};

    //Pattern Matching - Positional Pattern
    //(person, person.Gender, person.Age, person.PersonMaritalStatus)
    return person switch //Tuple
    {
      (Person, "Female", _, MaritalStatus.Unmarried) p => $"Miss.{p.Name}", //We can have alias as "p" also
      (Person, "Female", _, MaritalStatus.Married) p => $"Mrs.{p.Name}",
      (Person, "Male", < 18, _) p=> $"Master.{p.Name}",
      (Person, "Male", >= 18, _) p=> $"Mr.{p.Name}",
      (Person, not ("Male" or "Female"), _, _) p=> $"Mx.{p.Name}",
      _ => $"{person.Name}"
    };
  }

  class Program
  {
    static void Main()
    {
      Manager manager = new Manager() { Name = "John", Gender = "Male", Age = 20, Salary = 3000, PersonMaritalStatus = MaritalStatus.Married };
      //Console.WriteLine(Descriptor.GetDescription(manager));

      Customer customer = new Customer() { Name = "Smith", Gender = "Male", Age = 12, 
        CustomerBalance = 1000, PersonMaritalStatus = MaritalStatus.Unmarried };
      //Console.WriteLine(Descriptor.GetDescription(customer));
      //Console.WriteLine(Descriptor.GetDescriptionWithWhen(customer));
      
      Console.WriteLine(Descriptor.GetDescriptionWithMultipleProperitesPattern(manager));
      Console.WriteLine(Descriptor.GetDescriptionWithMultipleProperitesPattern(customer));

      Console.ReadKey();
    }
  }
}