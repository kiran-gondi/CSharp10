using ClassLibrary1;
using System;

namespace ArrayOfObjectsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create objects of Employee class
      Employee employee1 = new Employee() { EmployeeId = 101, EmployeeName = "Tom"};
      Employee employee2 = new Employee() { EmployeeId = 102, EmployeeName = "Pom"};
      Employee employee3 = new Employee() { EmployeeId = 103, EmployeeName = "Rom"};

      //create array of objects
      Employee[] employes = new Employee[] { employee1,employee2, employee3 };

      //foreach loop for array of object
      foreach (Employee employee in employes) { 
        Console.WriteLine("Employee Id: " + employee.EmployeeId + ", " + "Employee Name: " + employee.EmployeeName);
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
