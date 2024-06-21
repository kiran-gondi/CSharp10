using m = HR.Mgr;
using FrontOffice;
using static System.Console;

namespace NamespacesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      WriteLine("Manager Class");
      m.IManager mgr = new m.Manager();

      FrontOfficeExecutive frontOfficeExecutive = new FrontOfficeExecutive();
      CustomerEnquiry customerEnquiry = new CustomerEnquiry();

      ReadKey();
    }
  }
}
