class Employee
{
  public int x{ get; set; }
}

class EmployeeBusinessLogic
{
  public Employee? GetEmployee()
  {
    //return new Employee() { x = 10 };
    return null;
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
    if(employee !=null)
      Console.WriteLine(employee.x);
    Console.ReadKey();
  }
}
