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

    public enum SortBy
    {
      EmpId, EmpName, Job
    }

    class CustomComparer : IComparer<Employee>
    {
      //public int Compare(Employee x, Employee y)
      //{
      //  //Sort by EmployeeId
      //  //return x.EmployeeId - y.EmployeeId;

      //  //below one for string compare
      //  return x.EmployeeName.CompareTo(y.EmployeeName);
      //}

      //Sort By Job, EmpName columns
      //public int Compare(Employee x, Employee y)
      //{
      //  int result = 0;
      //  if (x.Job != null) { 
      //   result = x.Job.CompareTo(y.Job);
      //  }
      //  if (result == 0) {
      //    if (x.EmployeeName != null)
      //    {
      //      result = x.EmployeeName.CompareTo(y.EmployeeName);
      //    }
      //  }
      //  return result;  
      //}

      //Sortby selected column
      public int Compare(Employee x, Employee y)
      {
        int result = 0;
        switch (this.SortBy)
        {
          case SortBy.EmpId:
            result = x.EmployeeId - y.EmployeeId;
            break;
          case SortBy.EmpName:
            result = (x.EmployeeName != null) ? x.EmployeeName.CompareTo(y.EmployeeName) : 0; 
            break;
          case SortBy.Job:
            result = (x.Job != null) ? x.Job.CompareTo(y.Job) : 0;
            break;
          default:
            result = 0;
            break;
        }
        return result;
      }

      public SortBy SortBy { get; set; }
    }

    static void Main()
    {
      //collection of objects
      List<Employee> employees = new List<Employee>() {
        new Employee(){EmployeeId = 104, EmployeeName = "Jon", Job = "Dev" },
        new Employee(){EmployeeId = 103, EmployeeName = "Joe", Job = "Design" },
        new Employee(){EmployeeId = 102, EmployeeName = "Morni", Job = "Consultant" },
        new Employee(){EmployeeId = 101, EmployeeName = "Eveni", Job = "Consultant" },
        new Employee(){EmployeeId = 105, EmployeeName = "Eveni", Job = null }
      };

      CustomComparer customComparer = new CustomComparer();
      customComparer.SortBy = SortBy.Job;
      employees.Sort(customComparer);//EmployeeName


      Console.WriteLine();
      foreach (Employee employee in employees)
      {
        Console.WriteLine(employee.EmployeeId + ", " + employee.EmployeeName + ", " + employee.Job);
      }

      Console.ReadKey();
    }
  }
}
