public class Employee {
    public int Salary { get; set; }
}

public class Student
{
    public int Marks { get; set; }
}

//a class with generic method
public class Sample
{
  public void PrintData<T>(T obj) where T: class
  {
    if (obj.GetType() == typeof(Student)) { 
      
      Student tempStudent = obj as Student;
      Console.WriteLine(obj.GetType() + " marks is " + tempStudent.Marks);
    } 
    else if(obj.GetType() == typeof(Employee)) { 
      Employee tempEmployee = obj as Employee;
      Console.WriteLine(obj.GetType() + " salary is " + tempEmployee.Salary);
    }
  }
}