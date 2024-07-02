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

  class Person
  {
    public string PersonName { get; set; }
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


      //Min, Max, Sum, Average, Count
      double minSalary = employees.Min(e => e.Salary);
      double maxSalary = employees.Max(e => e.Salary);
      double sumSalary = employees.Sum(e => e.Salary);
      double avgSalary = employees.Average(e => e.Salary);
      double countEmp = employees.Count();

      Console.WriteLine("Min: " + minSalary);
      Console.WriteLine("Max: " + maxSalary);
      Console.WriteLine("Sum: " + sumSalary);
      Console.WriteLine("Avg: " + avgSalary);
      Console.WriteLine("Count: " + countEmp);

      ////Single
      //List<Person> result = employees.Select(x => new Person() { PersonName = x.EmpName }).ToList();
      //foreach (Person emp in result)
      //{
      //  Console.WriteLine(emp.PersonName);
      //}

      //SingleOrDefault
      //Employee firstEmployee1 = employees.SingleOrDefault(em => em.Job == "Analyst");
      //if (firstEmployee1 != null)
      //  Console.WriteLine(firstEmployee1.EmpID + ", " + firstEmployee1.EmpName + ", " + firstEmployee1.Job);
      //else
      //  Console.WriteLine("No Manager1 found");

      Console.ReadKey();
    }
  }
}
