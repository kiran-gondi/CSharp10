using System;
using System.Collections.Generic;

namespace IComparerExample
{
  internal class Program
  {
    class Employee
    {
      public int EmployeeId { get; set; }
      public string EmployeeName { get; set; }
      public string Job { get; set; }
    }

    class CustomComparer : IComparer<Employee>
    {
      public int Compare(Employee x, Employee y)
      {
        return x.EmployeeId - y.EmployeeId;
        
        //below one for string compare
        //return x.EmployeeName.CompareTo(y.EmployeeName);
      }
    }

    static void Main()
    {
      //collection of objects
      List<Employee> employees = new List<Employee>() {
        new Employee(){EmployeeId = 104, EmployeeName = "Jon", Job = "Dev" },
        new Employee(){EmployeeId = 103, EmployeeName = "Joe", Job = "Design" },
        new Employee(){EmployeeId = 102, EmployeeName = "Morni", Job = "Consultant" },
        new Employee(){EmployeeId = 101, EmployeeName = "Eveni", Job = "QA" }
      };

      CustomComparer customComparer = new CustomComparer();
      employees.Sort(customComparer);

      Console.WriteLine();
      foreach (Employee employee in employees)
      {
        Console.WriteLine(employee.EmployeeId + ", " + employee.EmployeeName + ", " + employee.Job);
      }

      Console.ReadKey();
    }
  }
}
