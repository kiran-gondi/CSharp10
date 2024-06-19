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
  //Constructor 1
  public Employee(int empId, string empName, string job)
  {
    EmpId = empId;
    EmpName = empName;
    Job = job;
  }

  //Constructor 2
  public Employee(int empId, string empName)
  {
    EmpId = empId;
    EmpName = empName;  
  }

  //Constructor 3
  public Employee()
  {
    EmpId = 1;
  }

  //Static Constructor
  static Employee()
  {
    CompanyName = "WWF";
  }
}