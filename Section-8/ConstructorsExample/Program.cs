namespace ConstructorsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      //Employee emp1 = new Employee(101, "Scott", "manager");
      Employee emp1 = new Employee();
      emp1.EmpId = 101;
      emp1.EmpName = "Scott";
      emp1.Job = "Manager";

      //Employee emp2 = new Employee(102, "Allen", "QE");
      Employee emp2 = new Employee(102, "Allen");
      emp2.Job = "Director";

      Employee emp3 = new Employee(103, "rom", "tester");

      //Object Initializer
      Employee emp4 = new Employee() { EmpName = "Rami", Job = "Dev" };

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

      Console.WriteLine("\nFourth Employee:");
      Console.WriteLine(emp4.EmpId);
      Console.WriteLine(emp4.EmpName);
      Console.WriteLine(emp4.Job);

      Console.ReadKey();
    }
  }
}
