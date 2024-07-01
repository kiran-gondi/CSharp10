using System;
using System.Collections;
using System.Collections.Generic;

namespace IEquatableExample
{
  public enum TypeOfCustomer
  {
    RegularCustomer, VIPCustomer
  }

  public class Customer : IEquatable<Customer>
  {
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public TypeOfCustomer CustomerType { get; set; }

    public bool Equals(Customer other)
    {
      return this.CustomerId == other.CustomerId && this.CustomerName == other.CustomerName &&
        this.CustomerEmail == other.CustomerEmail && this.CustomerType == other.CustomerType;
    }
  }

  //customer collection class
  public class CustomersList : IList<Customer>
  {
    private List<Customer> customers = new List<Customer>();

    public int Count => customers.Count;

    public bool IsReadOnly => false;

    public Customer this[int index]
    {
      get => customers[index];
      set => customers[index] = value;
    }

    //{ 
    //  new Customer { CustomerId = 1, CustomerName = "ramu", CustomerEmail = "ramu@one.com", CustomerType = TypeOfCustomer.RegularCustomer }, 
    //  new Customer { CustomerId = 2, CustomerName = "roy", CustomerEmail = "roy@one.com", CustomerType = TypeOfCustomer.VIPCustomer } 
    //};

    public List<Customer> GetCustomers()
    {
      return customers;
    }

    //read each customer, one-by-one
    //implementing IEnumerable.GetEnumerator()
    IEnumerator IEnumerable.GetEnumerator()
    {
      for (int i = 0; i < customers.Count; i++)
      {
        yield return customers[i]; //return & pause.
      }
      //yield return customers[0];
      //yield return customers[1];
      //yield return customers[2];
    }

    //implementing IEnumerable<T>.GetEnumerator()
    public IEnumerator<Customer> GetEnumerator()
    {
      for (int i = 0; i < customers.Count; i++)
      {
        yield return customers[i]; //return & pause.
      }
    }

    public void Add(Customer customer)
    {

      if (customer.CustomerId > 0)
        customers.Add(customer);
      else
        Console.WriteLine("Invalid customer");

    }

    public void Clear()
    {
      customers.Clear();
    }

    public bool Contains(Customer item)
    {
      return customers.Contains(item);
    }

    public void CopyTo(Customer[] array, int arrayIndex)
    {
      customers.CopyTo(array, arrayIndex);
    }

    public bool Remove(Customer item)
    {
      return customers.Remove(item);
    }

    public Customer Find(Predicate<Customer> match)
    {
      return customers.Find(match);
    }

    public List<Customer> FindAll(Predicate<Customer> match)
    {
      return customers.FindAll(match);
    }

    public int IndexOf(Customer item)
    {
      return customers.IndexOf(item);
    }

    public void Insert(int index, Customer item)
    {
      if (index < 0)
      {
        Console.WriteLine("Invalid Index");
      }
      else
      {
        customers[index] = item;
      }
    }

    public void RemoveAt(int index)
    {
      if (index < 0)
      {
        Console.WriteLine("Invalid Index");
      }
      else
      {
        customers.RemoveAt(index);
      }
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
      Customer new_customer = new Customer() { CustomerId = 3, CustomerName = "Ramie", CustomerEmail = "ramie@one.com", CustomerType = TypeOfCustomer.VIPCustomer };
      customersList.Add(new_customer);

      Customer another_customer = new Customer() { CustomerId = 3, CustomerName = "Ramie", CustomerEmail = "ramie@one.com", CustomerType = TypeOfCustomer.VIPCustomer };
      customersList.Add(new_customer);

      //Contains
      Console.WriteLine("Contains: " + customersList.Contains(new_customer)); //True
      Console.WriteLine("Contains: " + customersList.Contains(another_customer)); //True

      Console.WriteLine();
      Console.WriteLine(customersList.Count + " customers found.");

      //Remove
      //customersList.Remove(new_customer);

      foreach (Customer customer in customersList)
      {
        Console.WriteLine(customer.CustomerName + ", " + customer.CustomerId + ", " + customer.CustomerEmail + ", " + customer.CustomerType);
      }

      //enumerator.MoveNext();
      //Console.WriteLine((Customer) enumerator.Current);
      //enumerator.MoveNext();
      //Console.WriteLine(enumerator.Current);
      //enumerator.MoveNext();
      //Console.WriteLine(enumerator.Current);

      //customersList.Clear();

      //Find
      Customer matchingCustomer = customersList.Find(cust => cust.CustomerId == 1);
      Console.WriteLine("\nMatching Customers using Find");
      if (matchingCustomer != null)
      {
        Console.WriteLine("\nMatching customer is " + matchingCustomer.CustomerId + "-" + matchingCustomer.CustomerName);
      }

      //FindAll
      List<Customer> vipCustomers = customersList.FindAll(cust => cust.CustomerType == TypeOfCustomer.VIPCustomer);
      Console.WriteLine("\nVIP Customers using FindAll");
      foreach (Customer vipCustomer in vipCustomers)
      {
        Console.WriteLine(vipCustomer.CustomerName + ", " + vipCustomer.CustomerId + ", " + vipCustomer.CustomerEmail + ", " + vipCustomer.CustomerType);
      }


      //IndexOf
      Console.WriteLine("\nIndexOf");
      Console.WriteLine("IndexOf: " + customersList.IndexOf(new_customer));

      //Insert
      Console.WriteLine("\nInsert");
      customersList.Insert(2, new_customer);
      Console.WriteLine(customersList[2].CustomerId + ", " + customersList[2].CustomerName);
      //foreach (Customer vipCustomer in customersList)
      //{
      //  Console.WriteLine(vipCustomer.CustomerName + ", " + vipCustomer.CustomerId + ", " + vipCustomer.CustomerEmail + ", " + vipCustomer.CustomerType);
      //}

      customersList.Clear();

      Console.ReadKey();
    }
  }
}
