class Program
{
  static void Main()
  {
    //create object of Employee
    Employee e1 = new Employee();
    e1.EmpId = 101;
    e1.EmpName = "Bill1";
    e1.Location = "Bangalore1";
    PrintBaseClassProperties(e1);

    //Create Object of Manager
    Manager mgr = new Manager();
    mgr.EmpId = 102;
    mgr.EmpName = "Bill2";
    mgr.Location = "Bangalore2";
    mgr.DepartmentName = "Accounting";
    Console.WriteLine("\nObject of Child Class - Manager");
    PrintBaseClassProperties(mgr);
    Console.WriteLine(mgr.DepartmentName);
    Console.WriteLine("Mgr to GetTotalSalesOfTheYear:" + mgr.GetTotalSalesOfTheYear());

    //Create Object of Salesman
    SalesMan salesMan = new SalesMan();
    salesMan.EmpId = 103;
    salesMan.EmpName = "Bill3";
    salesMan.Location = "Bangalore3";
    Console.WriteLine("\nObject of Child Class - SalesMan");
    PrintBaseClassProperties(salesMan);
    salesMan.Region = "UK";
    Console.WriteLine("Salesman to GetMonthlySalesOfTheCurrentMonth:" + salesMan.GetMonthlySalesOfTheCurrentMonth());

    Console.ReadKey();

    static void PrintBaseClassProperties(Employee e1)
    {
      Console.WriteLine(e1.EmpId);
      Console.WriteLine(e1.EmpName);
      Console.WriteLine(e1.Location);
    }
  }
}