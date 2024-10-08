﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionExample
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
  public class CustomersList : ICollection<Customer>
  {
    private List<Customer> customers = new List<Customer>();

    public int Count => customers.Count;

    public bool IsReadOnly => false;

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

    public Customer Find(Predicate<Customer> match) { 
      return customers.Find(match);
    }

    public List<Customer> FindAll(Predicate<Customer> match)
    {
      return customers.FindAll(match);
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

      //Contains
      Console.WriteLine("Contains: " + customersList.Contains(new_customer));

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
      if (matchingCustomer != null) { 
      Console.WriteLine("Matching customer is " + matchingCustomer.CustomerId + "-" + matchingCustomer.CustomerName); 
      }

      //FindAll
      List<Customer> vipCustomers = customersList.FindAll(cust => cust.CustomerType == TypeOfCustomer.VIPCustomer);
      Console.WriteLine("\nVIP Customers using FindAll");
      foreach (Customer vipCustomer in vipCustomers)
      {
        Console.WriteLine(vipCustomer.CustomerName + ", " + vipCustomer.CustomerId + ", " + vipCustomer.CustomerEmail + ", " + vipCustomer.CustomerType);
      }

      Console.ReadKey();
    }
  }
}
