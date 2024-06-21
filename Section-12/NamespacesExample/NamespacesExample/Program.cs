namespace NamespacesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      HR.Mgr.IManager mgr = new HR.Mgr.Manager();

      FrontOffice.FrontOfficeExecutive frontOfficeExecutive = new FrontOffice.FrontOfficeExecutive();
      FrontOffice.CustomerEnquiry customerEnquiry = new FrontOffice.CustomerEnquiry();

      Console.ReadKey();
    }
  }
}
