namespace NamespacesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      HR.IManager mgr = new HR.Manager();

      FrontOffice.FrontOfficeExecutive frontOfficeExecutive = new FrontOffice.FrontOfficeExecutive();
      FrontOffice.CustomerEnquiry customerEnquiry = new FrontOffice.CustomerEnquiry();

      Console.ReadKey();
    }
  }
}
