//Parent Class
public class Employee
{
  //fields
  private int _empId;
  private string _empName;
  private string _location;

    //constructor of parent class
    public Employee(int empId, string empName, string location)
    {
      this._empId = empId;
      this._empName = empName;  
      this._location = location;
    }

    //method
    public string GetHealthInsuranceAmount()
    {
      return "Health Insurance amoutn is: " + 500000;
    }
    //properties
    public int EmpId { get { return _empId; } set { _empId = value; } }

  public string EmpName { get { return _empName; } set { _empName = value; } }

  public string Location { get { return _location; } set { _location = value; } } 

}