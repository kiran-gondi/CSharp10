namespace PartialMethodsExample
{
  partial class Student
  {
    private int _studentId;

    //partial method declaration
    //private void GetStudentId();//Earlier before C# 9 restrictions are: By default private, can't have 
    //out parameters, return types should 'void'

    internal partial int GetStudentId();
    
  }
}
