namespace ConstructorsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      Employee emp1 = new Employee(101, "Scott", "manager");
      Employee emp2 = new Employee(102, "Allen", "QE");
      Employee emp3 = new Employee(103, "rom", "tester");

      Console.WriteLine(Employee.CompanyName);
      Console.WriteLine("\nFirst Employee:");
      Console.WriteLine(emp1.EmpId);
      Console.WriteLine(emp1.EmpName);
      Console.WriteLine(emp1.Job);

      Console.WriteLine("\nSecond Employee:");
      Console.WriteLine(emp2.EmpId);
      Console.WriteLine(emp2.EmpName);
      Console.WriteLine(emp2.Job);

      Console.WriteLine("\nThird Employee:");
      Console.WriteLine(emp3.EmpId);
      Console.WriteLine(emp3.EmpName);
      Console.WriteLine(emp3.Job);

      Console.ReadKey();
    }
  }
}
