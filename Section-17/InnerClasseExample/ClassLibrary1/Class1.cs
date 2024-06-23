namespace ClassLibrary1
{
  public class Student
  {
      public double SecuredMarks { get; set; }
      public double MaxMarks { get; set; }
      public double Percentage { get; set; }
  }

  //Outer Class
  public class MarksCalculation
  {
    public void CalculatePercentage(Student s)
    {
      //Create object of inner class
      CalclulationHelper ch = new CalclulationHelper();
      //s.Percentage = s.SecuredMarks / s.MaxMarks * 100;
      //s.Percentage = s.SecuredMarks / ch.Multiply(s.MaxMarks, 100);
      s.Percentage = ch.Multiply(s.SecuredMarks / s.MaxMarks, 100);
    }

    //Inner Class
    public class CalclulationHelper
    {
      public double Multiply(double n1, double n2)
      {
        return n1 * n2;
      }
    }
  }
}
