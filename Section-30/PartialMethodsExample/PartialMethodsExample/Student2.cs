namespace PartialMethodsExample
{
  partial class Student
  {
    public int StudentID
    {
      get => _studentId;
      set => _studentId = value;
    }

    //partial method implementation
    internal partial int GetStudentId()
    {
      return StudentID;
    }
  }
}
