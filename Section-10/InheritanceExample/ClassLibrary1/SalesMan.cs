public class SalesMan : Employee
{
  //field 
  private string _region;

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