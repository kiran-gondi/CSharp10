using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionsExample
{
  public enum TypeOfCustomer
  {
    RegularCustomer, VIPCustomer
  }

  public class Customer
  {
      public int CustomerId { get; set; }
      public string CustomerName { get; set; }
      public string CustomerEmail { get; set; }
      public TypeOfCustomer CustomerType { get; set; }
  }

  //customer collection class
  public class CustomersList : IEnumerable
  {
    private List<Customer> customers = new List<Customer>();
    //{ 
    //  new Customer { CustomerId = 1, CustomerName = "ramu", CustomerEmail = "ramu@one.com", CustomerType = TypeOfCustomer.RegularCustomer }, 
    //  new Customer { CustomerId = 2, CustomerName = "roy", CustomerEmail = "roy@one.com", CustomerType = TypeOfCustomer.VIPCustomer } 
    //};

    public List<Customer> GetCustomers() { 
      return customers;
    }

    public IEnumerator GetEnumerator()
    {
      for (int i = 0; i < customers.Count; i++) { 
        yield return customers[i];
        }
      //yield return customers[0];
      //yield return customers[1];
      //yield return customers[2];
    }

    public void Add(Customer customer) {

      if (customer.CustomerId > 0)
        customers.Add(customer);
      else
        Console.WriteLine("Invalid customer");

    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      CustomersList customersList = new CustomersList() { 
        new Customer { CustomerId = 1, CustomerName = "ramu", CustomerEmail = "ramu@one.com", CustomerType = TypeOfCustomer.RegularCustomer },
        new Customer { CustomerId = 2, CustomerName = "roy", CustomerEmail = "roy@one.com", CustomerType = TypeOfCustomer.VIPCustomer } 
      };
      //IEnumerator enumerator = customersList.GetEnumerator();

      //Add
      Customer new_customer = new Customer() {CustomerId = -3, CustomerName = "Ramie", CustomerEmail = "ramie@one.com", CustomerType = TypeOfCustomer.VIPCustomer };
      customersList.Add(new_customer);

      foreach (Customer customer in customersList) { 
        Console.WriteLine(customer.CustomerName + ", " + customer.CustomerId + ", " + customer.CustomerEmail + ", " + customer.CustomerType);
      }

      //enumerator.MoveNext();
      //Console.WriteLine((Customer) enumerator.Current);
      //enumerator.MoveNext();
      //Console.WriteLine(enumerator.Current);
      //enumerator.MoveNext();
      //Console.WriteLine(enumerator.Current);

      Console.ReadKey();
    }
  }
}
