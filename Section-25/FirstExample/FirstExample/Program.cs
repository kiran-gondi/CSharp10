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
    public double Salary { get; set; }
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
        new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7235 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 6335 },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 5256 },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 3235 },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 1235 }
      };

      //Where
      //List<Employee> filteredEmpoyees = employees.Where(x=>x.Job == "Manager").ToList();
      //Console.WriteLine(filteredEmpoyees[0].EmpID + "," + filteredEmpoyees[0].EmpName);

      //First
      //Employee firstManager = employees.First(x => x.Job == "Manager");
      //Console.WriteLine(firstManager.EmpID + "," + firstManager.EmpName);

      //FirstOrDefault
      Employee firstManager = employees.FirstOrDefault(x => x.Job == "Manager1");
      if (firstManager != null)
        Console.WriteLine(firstManager.EmpID + "," + firstManager.EmpName);
      else
        Console.WriteLine("No Manager1 found");

      Console.ReadKey();
    }
  }
}
