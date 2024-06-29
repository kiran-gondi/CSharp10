using System;
using ECommerce;
using System.Collections.Generic;

namespace CollectionOfObjectsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create an empty collection
      List<Product> products = new List<Product>();

      //loop to read data from user
      string choice;
      do
      {
        Console.WriteLine("Enter Product ID: ");
        int pid = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Product Name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter date of Manufacture(yyyy-MM-dd): ");
        DateTime dom = DateTime.Parse(Console.ReadLine());

        //Create a new object of Product class
        Product product = new Product() { ProductId = pid, ProductName = productName, Price = price, DateOfManufacture = dom};

        //Add product object to the collection
        products.Add(product);

        //Ask the user to continue
        Console.WriteLine("Product Added.\n");
        Console.WriteLine("Do you want to continue to next product?(Yes/No)");
        choice = Console.ReadLine();
      } 
      while (choice != "No" && choice != "no" && choice != "n" && choice != "N");

      //foreach
      Console.WriteLine("Product Info");
      foreach (Product product in products) {
        Console.WriteLine(product.ProductName + " - " + product.Price + " - " + product.DateOfManufacture.ToShortDateString());
      }

      Console.ReadKey();
    }
  }
}
