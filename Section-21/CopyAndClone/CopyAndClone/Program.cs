using System;

namespace CopyAndClone
{
  //model class
  class Employee
  {
      public string EmployeeName { get; set; }
      public string Role { get; set; }
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
      var highlyPaidEmployees2 = (Employee[]) employees.Clone(); //creates a new array and copies from source array to that new array
      Console.WriteLine("Clone:");
      
      //print destination array
      foreach (Employee item in highlyPaidEmployees2)
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
