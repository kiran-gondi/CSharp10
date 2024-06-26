﻿namespace PropertiesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create three objects for Employee
      Employee emp1 = new Employee(); //constructor 3
      emp1.EmployeeId = 10;
      emp1.FirstName = "Scott";
      emp1.Job = "Manager";
      //emp1.Salary = 20000; NOT ALLOWED
      emp1.Tax = 50;
      emp1.NativePlace = "USA";
         
      Employee emp2 = new Employee(102, "Allen"); //constructor 2
      emp2.Job = "Asst. Manager";
      Employee emp3 = new Employee(103, "Anna", "Clerk"); //constructor 1
      Employee emp4 = new Employee() { FirstName = "Ford", Job = "Executive" };

      //display fields
      System.Console.WriteLine(Employee.CompanyName);
      System.Console.WriteLine("\nFirst employee:");
      System.Console.WriteLine(emp1.EmployeeId);
      System.Console.WriteLine(emp1.FirstName);
      System.Console.WriteLine(emp1.Job);
      System.Console.WriteLine(emp1.Salary);
      System.Console.WriteLine("Calculated Net Salary: " + emp1.CalculateNetSalary());
      System.Console.WriteLine("Native Place is " + emp1.NativePlace);
      System.Console.WriteLine();

      System.Console.WriteLine("Second employee:");
      System.Console.WriteLine(emp2.EmployeeId);
      System.Console.WriteLine(emp2.FirstName);
      System.Console.WriteLine(emp2.Job);
      System.Console.WriteLine(emp2.Salary);
      System.Console.WriteLine("Native Place is " + emp2.NativePlace);
      System.Console.WriteLine();

      System.Console.WriteLine("Third employee:");
      System.Console.WriteLine(emp3.EmployeeId);
      System.Console.WriteLine(emp3.FirstName);
      System.Console.WriteLine(emp3.Job);
      System.Console.WriteLine(emp3.Salary);
      System.Console.WriteLine("Native Place is " + emp3.NativePlace);
      System.Console.WriteLine();

      System.Console.ReadKey();
    }
  }
}
