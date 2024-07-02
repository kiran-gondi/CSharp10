using ManyToOne;
using System;

namespace ManyToOneExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create object for Employee1
      Employee e1 = new Employee();
      e1.EmployeeId = 1;
      e1.EmployeeName = "Sagar";
      e1.EmployeeEmail = "sagu@one.com";

      Department department = new Department() { DeptId = 001, DeptName = "Accounts" };

      //Many To One Relationship
      e1.Dept = department;

      Console.WriteLine("Employee one details below, " +  e1.ToString());

      Employee e2 = new Employee();
      e2.EmployeeId = 2;
      e2.EmployeeName = "Dom";
      e2.EmployeeEmail = "dome@one.com";

      //Many To One Relationship
      e2.Dept = department;

      Console.WriteLine("Employee two details below, " + e2.ToString());

      Console.ReadKey();
    }
  }
}
