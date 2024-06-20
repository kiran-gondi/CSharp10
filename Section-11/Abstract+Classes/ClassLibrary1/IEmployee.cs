//child interface
public interface IEmployee : IPerson
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
}
