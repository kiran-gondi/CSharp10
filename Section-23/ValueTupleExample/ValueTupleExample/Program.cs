using ClassLibrary1;
using System;

namespace ValueTupleExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create object
      Customer customer = new Customer();

      //get details
      //(int customerId, string customerName, string email) cust = customer.GetCustomerDetails();
      (int customerId, string customerName, string email) = customer.GetCustomerDetails();

      //Console.WriteLine(cust.customerId + ", " + cust.customerName + ", " + cust.email);
      Console.WriteLine(customerId + ", " + customerName + ", " + email);

      Console.ReadKey();
    }
  }
}
