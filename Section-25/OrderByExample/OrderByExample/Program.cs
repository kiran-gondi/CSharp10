﻿using System;
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

      //IEnumerable<Employee> results = employees.OrderBy(x=>x.Salary);
      //IEnumerable<Employee> results = employees.OrderByDescending(x=>x.Salary);
      //IEnumerable<Employee> results = employees.OrderBy(x=>x.Job)
      //                                  .ThenBy(x=>x.EmpName);
      IEnumerable<Employee> results = employees.OrderByDescending(x => x.Job)
                                        .ThenByDescending(x => x.EmpName);

      foreach (Employee emp in results)
      {
        Console.WriteLine(emp.EmpID + "," + emp.EmpName  + "," + emp.Job + "," + emp.Salary);
      }


      Console.ReadKey();
    }
  }
}
