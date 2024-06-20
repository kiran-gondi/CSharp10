public class SalesMan : Employee
{
  //field 
  private string _region;

  //Constructor of Child Class
  public SalesMan(int empId, string empName, string location, string region):base(empId, empName, location)
  {
      this._region = region;
  }

    //property
    public string Region
  {
    get { return _region; }
    set { _region = value; }
  }

  public long GetMonthlySalesOfTheCurrentMonth()
  {
    return 1000;
  }
}