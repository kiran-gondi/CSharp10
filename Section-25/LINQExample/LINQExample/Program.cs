using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{

  class Employee
  {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }

  class Temporary
  {
    public bool Check(Employee emp)
    {
      return emp.Job == "Manager";
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //collection of objects
      List<Employee> employees = new List<Employee>() {
        new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston" },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York" },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", City = "Tokyo" },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo" },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York" }
      };

      //var results = employees.Where(e => e.Job == "Manager");
      //IEnumerable<Employee> results = employees.Where(e => e.City == "Tokyo");
      IEnumerable<Employee> results = employees.Where(e => e.City == "London");
      foreach (Employee emp in results) { 
        Console.WriteLine(emp.EmpID + "," + emp.Job + "," + emp.EmpName);
      }


      Console.ReadKey();  
    }
  }
}
