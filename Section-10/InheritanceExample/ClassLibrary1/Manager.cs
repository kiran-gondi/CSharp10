public class Manager : Employee
{
  //field
  private string _departmentName;

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
}