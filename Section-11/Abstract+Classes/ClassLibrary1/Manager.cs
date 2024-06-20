﻿//child class
public class Manager : IEmployee
{
  //field
  private string _departmentName;

  //constructor of child class
  public Manager(int empID, string empName, string location, string departmentName)
  {
    this._empId = empID;
    this._empName = empName;
    this._location = location;
    this._departmentName = departmentName;
  }

  //method overriding the abstract methods
  //public override string GetHealthInsuranceAmount()
  //{
  //    return "Additional Health Insurance premium amount is: 1000";
  //}

  //property
  public string DepartmentName
  {
      set
      {
          _departmentName = value;
      }
      get
      {
          return _departmentName;
      }
  }

  //method
  public long GetTotalSalesOfTheYear()
  {
      return 10000;
  }

  //method
  public string GetFullDepartmentName()
  {
    return DepartmentName + " at " + _location;
  }

  private int _empId;
  private string _empName;
  private string _location;

  public int EmpID { get { return _empId; } set { 
      if(value >= 10000 && value <= 2000) { 
        _empId = value;
      }
    } }
  public string EmpName { get { return _empName; } set { _empName = value; } }
  public string Location { get { return _location; } set { _location = value; } }

  //method implementation
  public string GetHealthInsuranceAmount()
  {
    return "Additional Health Insurance premium amount is: 1000"; ;
  }
}

