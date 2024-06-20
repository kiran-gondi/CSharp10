//child class
using System;

public class SalesMan : IPerson, IEmployee
{
  //field
  private string _region;

  //constructor of child class
  public SalesMan(int empID, string empName, string location, string region)
  {
      this._empId = empID;
      this._empName = empName;
      this._location = location;
      this._region = region;
  }

  //property
  public string Region
  {
      set
      {
          _region = value;
      }
      get
      {
          return _region;
      }
  }

//public override string GetHealthInsuranceAmount()
//{
//  return "Additional Health Insurance premium amount is: 2000";
//}

//method
public long GetSalesOfTheCurrentMonth()
  {
      return 1000;
  }

  private int _empId;
  private string _empName;
  private string _location;
  private DateTime _dob;

  public int EmpID { get { return _empId; } 
    
    set {
      if (value >= 5000 && value <= 8000)
      {
        _empId = value;
      }
    } 
  }
  public string EmpName { get { return _empName; } set { _empName = value; } }
  public string Location { get { return _location; } set { _location = value; } }

  public DateTime DateOfBirth
  {
    get { return _dob; }
    set
    {
      if (value != DateTime.Now)
      {
        _dob = value;
      }
    }
  }

  //method implementation
  public string GetHealthInsuranceAmount()
  {
    return "Additional Health Insurance premium amount is: 2000"; ;
  }

  public int GetAge()
  {
    return DateTime.Now.Year - _dob.Year; ;
  }
}

