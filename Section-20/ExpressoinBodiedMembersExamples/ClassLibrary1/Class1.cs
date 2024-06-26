using System.Diagnostics.Contracts;

namespace ClassLibrary1
{
  public class Student
  {
    //private field
    private string _studentName;

    //public method
    //public int GetStudentNameLength()
    //{
    //  return _studentName.Length;
    //}
    public int GetStudentNameLength() => _studentName.Length;

    //public constructors
    public Student() => _studentName = "Romi";

    //public properties
    public string StudentName
    {
      set => _studentName = value;
      get => _studentName;
    }

  }
}
