using m = HR.Mgr;
using FrontOffice;

namespace NamespacesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      m.IManager mgr = new m.Manager();

      FrontOfficeExecutive frontOfficeExecutive = new FrontOfficeExecutive();
      CustomerEnquiry customerEnquiry = new CustomerEnquiry();

      Console.ReadKey();
    }
  }
}
