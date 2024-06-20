public class Employee
{
  private int _empId;
  private string _firstName;
  private string _job;

  public int EmployeeId
  {
    set {
      if(value >= 100)
      _empId = value; 
    }
    get { return _empId; }
  }

  public string FirstName
  {
    set { _firstName = value; }
    get { return _firstName; }
  }

  public string Job
  {
    set { _job = value; }
    get { return _job; }
  }

  private static string? _companyName;

  public static string CompanyName
  {
    set { 
      if(value.Length <= 20) 
      { 
        _companyName = value;
      }
    }
    get { return _companyName ?? string.Empty; }
  }

    public Employee()
    {
        this._empId = 1;
    }

    public Employee(int empId, string firstName)
    {
        this._empId = empId;
        this._firstName = firstName;
    }
    public Employee(int empId, string firstName, string job)
    {
      this._empId = empId;
      this._firstName = firstName;
      this._job = job;
    }

    static Employee()
    {
      CompanyName = "Uncle Bob's Org";
    }
}