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

      //Single
      //Employee firstEmployee = employees.Single(em => em.Job == "Analyst");
      //Console.WriteLine(firstEmployee.EmpID + ", " + firstEmployee.EmpName + ", " + firstEmployee.Job);
      Employee firstEmployee = employees.Single(em => em.EmpID == 102);
      Console.WriteLine(firstEmployee.EmpID + ", " + firstEmployee.EmpName + ", " + firstEmployee.Job);

      //SingleOrDefault
      Employee firstEmployee1 = employees.SingleOrDefault(em => em.Job == "Analyst");
      if (firstEmployee1 != null)
        Console.WriteLine(firstEmployee1.EmpID + ", " + firstEmployee1.EmpName + ", " + firstEmployee1.Job);
      else
        Console.WriteLine("No Manager1 found");

      Console.ReadKey();
    }
  }
}
