using System;

namespace DeepCopyExample
{
  //model class
  class Employee : ICloneable
  {
    public string EmployeeName { get; set; }
    public string Role { get; set; }

    public object Clone()
    {
      Employee new_One = new Employee() { EmployeeName = this.EmployeeName, Role = this.Role };
      return new_One;
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Employee[] employees = new Employee[] {
        new Employee(){ EmployeeName = "Scott", Role = "Dev" },
        new Employee(){ EmployeeName = "Jac", Role = "Designer" },
        new Employee(){ EmployeeName = "Alex", Role = "Analyst" }
      };

      //deep copy
      Employee[] employees_Deep_Copy = new Employee[employees.Length];
      for (int i = 0; i < employees.Length; i++)
      {
        var result = (Employee)employees[i].Clone();
        employees_Deep_Copy[i] = result;
      }

      //new Array
      Employee[] highlyPaidEmployees = new Employee[6];
      //Array.CopyTo
      employees.CopyTo(highlyPaidEmployees, 1);
      employees[0].Role = "Changed"; //Shallow copy

      Console.WriteLine("CopyTo:");
      //print destination array
      foreach (Employee item in highlyPaidEmployees)
      {
        if (!(item is null))
          Console.WriteLine("Employee Name: " + item.EmployeeName + ", " + "Employee Role: " + item.Role);
        else
          Console.WriteLine("null object");
      }

      Console.WriteLine();

      //Array.Clone
      var highlyPaidEmployees2 = (Employee[])employees.Clone(); //creates a new array and copies from source array to that new array
      Console.WriteLine("Clone:");

      //print destination array
      foreach (Employee item in highlyPaidEmployees2)
      {
        if (!(item is null))
          Console.WriteLine("Employee Name: " + item.EmployeeName + ", " + "Employee Role: " + item.Role);
        else
          Console.WriteLine("null object");
      }

      Console.WriteLine("\nDeep Copy:");
      //print destination array
      foreach (Employee item in employees_Deep_Copy)
      {
        if (!(item is null))
          Console.WriteLine("Employee Name: " + item.EmployeeName + ", " + "Employee Role: " + item.Role);
        else
          Console.WriteLine("null object");
      }
      Console.ReadKey();
    }
  }
}