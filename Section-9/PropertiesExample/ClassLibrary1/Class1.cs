public class Employee
{
  private int _empId;
  private string _firstName;
  private string _job;
  private double _salary;
  private double _tax;

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
        this._salary = 1000;
    }

    public Employee(int empId, string firstName)
    {
        this._empId = empId;
        this._firstName = firstName;
        this._salary = 1000;
  }
    public Employee(int empId, string firstName, string job)
    {
      this._empId = empId;
      this._firstName = firstName;
      this._job = job;
      this._salary = 1000;
    }

    static Employee()
    {
      CompanyName = "Uncle Bob's Org";
    }

    //readonly property
    public double Salary
    {
      get
      {
        return _salary;
      }
    }

    //writeonly property
    public double Tax
    {
      set
      {
        if(value >=0 && value <= 100)
        {
          _tax = value;
        }
      }
    }

    //Calculate Net Salary
    public double CalculateNetSalary()
    {
      double t = Salary - _tax;
      return t;
    }

  //C# 3.0 - Automatic Properties
  //public string NativePlace { get; set; }

  //C# 6.0 Auto-Implemented Property Initializers
  public string NativePlace { get; set; } = "New York";
}