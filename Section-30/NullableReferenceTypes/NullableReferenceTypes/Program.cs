class Employee
{
  public int x{ get; set; }

  public string FirstName { get; set; }
  public string LastName { get; set; }

  public AddressDetails? PersonAddressDetails { get; set; }

    public Employee(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }
}

class AddressDetails()
{
    public string? City { get; set; }
    public int? ZipCode { get; set; }
}

class EmployeeBusinessLogic
{
  public Employee? GetEmployee()
  {
    //return new Employee() { x = 10 };
    //return null;
    //return new("rob", "doe"); //Target-typed 'new' expression feature in C# 9
    Employee e = new("rob", "mon");
    return e;
  }
}

class DataPrinter
{
  public static void PrintEmployee(Employee e)
  {
    if (e != null)
    {
      Console.WriteLine($"{e.FirstName} {e.LastName}");
    }
  }
}

//Emloyee = non-nullable (null values are not expected)
//Emloyee? = nullable (accept null values)
class Program
{
  static void Main()
  {
    EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
    Employee? employee = employeeBusinessLogic.GetEmployee();
    bool isValid = employee != null;

    if (isValid) { 
      Console.WriteLine(employee!.x); //Null Forgiving Operator
      Console.WriteLine(employee!.FirstName.ToUpper());
      Console.WriteLine(employee!.LastName.ToUpper());
      //if (employee!.PersonAddressDetails != null)
      //{
      //  Console.WriteLine(employee!.PersonAddressDetails.City);
      //  Console.WriteLine(employee!.PersonAddressDetails!.ZipCode);
      //}
      Console.WriteLine(employee!.PersonAddressDetails?.City);
      Console.WriteLine(employee!.PersonAddressDetails?.ZipCode);
    }

    //Target-typed new expression
    DataPrinter.PrintEmployee(new("one", "two"));//Employee class name wil be taken automatically here, based
    //on the definition of hte PrintEmplyee method

    //using (var f = new("", FileMode.Create, FileAccess.Read))
    //{

    //}

    Console.ReadKey();
  }
}
