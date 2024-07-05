class Employee
{
  public int x{ get; set; }

  public string FirstName { get; set; }
  public string LastName { get; set; }

  public AddressDetails? PersonAddressDetails { get; set; }

    public Employee()
    {
      FirstName = "test1";
      LastName = "test2";
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
    return new Employee() { x = 10 };
    //return null;
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

    Console.ReadKey();
  }
}
