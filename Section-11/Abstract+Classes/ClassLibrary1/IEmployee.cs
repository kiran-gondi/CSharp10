//child interface
public interface IEmployee 
{
    
  //abstract method
  string GetHealthInsuranceAmount();

    //auto-properties
    int EmpID
    {
       get; set;
    }

    string EmpName
    {
    get; set;
  }

    string Location
    {
    get; set;
  }

  int GetAge();
}
