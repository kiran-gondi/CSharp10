using System;
using System.Collections.Generic;
using System.Linq;

namespace LastExample
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
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 1235 },
                new Employee() { EmpID = 106, EmpName = "Jammie", Job = "Manager", Salary = 1225 }
      };

      //Where
      //List<Employee> filteredEmployees = employees.Where(x=> x.Job == "Manager").ToList();
      //Console.WriteLine(filteredEmployees[filteredEmployees.Count - 1].EmpID + ", "
      //  + filteredEmployees[filteredEmployees.Count-1].EmpName + ", "
      //  + filteredEmployees[filteredEmployees.Count - 1].Job);

      //Last
      Employee lastManager1 = employees.Last(x => x.Job == "Manager");
      Console.WriteLine(lastManager1.EmpID + "," + lastManager1.EmpName);

      //LastOrDefault
      Employee lastManager = employees.LastOrDefault(x => x.Job == "Manager");
      if (lastManager != null)
        Console.WriteLine(lastManager.EmpID + "," + lastManager.EmpName);
      else
        Console.WriteLine("No Manager1 found");

      Console.ReadKey();
    }
  }
}
