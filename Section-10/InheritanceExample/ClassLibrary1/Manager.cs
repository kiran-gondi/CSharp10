﻿using System;

public sealed class Manager : Employee
{
  //field
  private string _departmentName;

  //Constructor of Child Class
  public Manager(int empId, string empName, string location, string departmentName):base(empId, empName, location)
  {
      _departmentName = departmentName;
  }

    //property
    public string DepartmentName { get { return _departmentName; } set { _departmentName = value; } }

  //method
  public long GetTotalSalesOfTheYear()
  {
    return 100000;
  }

  //method 
  public string GetFullDepartmentName()
  {
    return DepartmentName + " at " + base.Location; 
  }

  //Method Hiding
  //public new string GetHealthInsuranceAmount()
  //{
  //  return "Health Insurance amount is: " + 700000;
  //}

  //Method Overriding
  public override string GetHealthInsuranceAmount()
  {
    Console.WriteLine(base.GetHealthInsuranceAmount());
    return "Additional Health Insurance amount is: " + 750000;
  }
}

//Cannot inherit the sealed class
//public class BranchManager : Manager
//{

//}