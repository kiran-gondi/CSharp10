using System;
using System.Collections;

namespace ArrayListExample
{
  class Sample
  {
    public int GetNum()
    {
      return 10;
    }

    public double GetNum2()
    {
      return 10.45;
    }

    public string GetMessage()
    {
      return "Hello";
    }

    public Employee GetEmployee()
    {
      return new Employee() { EmployeeName = "Robin" };
    }

  }

  class Employee
  {
      public string EmployeeName { get; set; }


  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //Create object of ArrayList class
      ArrayList arrayList = new ArrayList() { 100, 'A' };

      Sample s = new Sample();

      //Add
      arrayList.Add(s.GetNum());
      arrayList.Add(s.GetNum2());
      arrayList.Add(s.GetMessage());
      arrayList.Add(s.GetEmployee());

      //foreach
      foreach (var e in arrayList) {
        if(e is Employee emp)
        {
          Console.WriteLine(emp.EmployeeName);
        }
        else
          Console.WriteLine(e);
      }

      Console.ReadKey();
    }
  }
}
