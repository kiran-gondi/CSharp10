using System.Runtime.CompilerServices;

public class Employee
{
  //Instance Field
  public int EmpId;
  public string EmpName;
  public string Job;

  //Static Field
  public static string CompanyName;

  //Instance Constructor
  public Employee(int empId, string empName, string job)
  {
    EmpId = empId;
    EmpName = empName;
    Job = job;
  }

  //Static Constructor
  static Employee()
  {
    CompanyName = "WWF";
  }
}