class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
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
    if (person is Employee emp) //C# 9 Pattern Matching - Type Pattern
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
      return $"{person.Name}, {person.Age}, {person.Gender}"; 
    #endregion

  }
}

class Program
{
  static void Main()
  {
    Manager manager = new Manager() { Name="John", Gender="Male", Age=20, Salary = 3000 };
    Console.WriteLine(Descriptor.GetDescription(manager));

    Customer customer = new Customer() { Name="Smith", Gender="Male", Age=30, CustomerBalance=1000};
    Console.WriteLine(Descriptor.GetDescription(customer));

    Console.ReadKey();
  }
}