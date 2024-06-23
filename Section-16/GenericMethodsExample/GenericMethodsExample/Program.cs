class Program
{
  public static void Main()
  {
    //Create instance of Sample class
    Employee employee = new Employee() { Salary = 10000 };
    Student student = new Student() { Marks = 55 };
    Sample s = new Sample() ;
    
    //call the generic method
    s.PrintData<Employee>(employee);
    s.PrintData<Student>(student);

    Console.ReadKey();

  }
}