using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
  //class
  class Employee : IComparable
  {
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeEmail { get; set; }
    public string Job { get; set; }

    //public int CompareTo(object other)
    //{
    //  Employee otherEmployee = (Employee)other;
    //  Console.WriteLine(this.EmployeeId + "," + otherEmployee.EmployeeId);
    //  return this.EmployeeId - otherEmployee.EmployeeId;
    //}

    //To compare the strings
    public int CompareTo(object other)
    {
      Employee otherEmployee = (Employee)other;
      Console.WriteLine(this.EmployeeName + "," + otherEmployee.EmployeeName);
      return this.EmployeeName.CompareTo(otherEmployee.EmployeeName);
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //list of numbers
      /*List<int> integersList = new List<int>() { 4, 5, 1, 2, 6}; 
      integersList.Sort();

      foreach (int i in integersList) { 
        Console.WriteLine(i);
      }*/

      //list of employees
      List<Employee> employees = new List<Employee>()
      {
        new Employee(){EmployeeId = 104, EmployeeName = "Jon", Job = "Dev" },
        new Employee(){EmployeeId = 103, EmployeeName = "Joe", Job = "Design" },
        new Employee(){EmployeeId = 102, EmployeeName = "Morni", Job = "Consultant" },
        new Employee(){EmployeeId = 101, EmployeeName = "Eveni", Job = "QA" }
      };

      employees.Sort();

      Console.WriteLine();
      foreach (Employee employee in employees) {
        Console.WriteLine(employee.EmployeeId + ", " + employee.EmployeeName + ", " + employee.Job);
      }


      Console.ReadKey();
    }
  }
}
