using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
      public (int customerId, string customerName, string email) GetCustomerDetails()
      {
      return (101, "Rob", "rob@one.com");
      }
    }
}
