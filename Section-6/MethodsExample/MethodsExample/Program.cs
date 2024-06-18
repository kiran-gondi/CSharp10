using Methods;

namespace MethodsExample
{
  internal class Program
  {
    static void Main()
    {
      //create reference variables
      Product product1, product2, product3;

      //create objects
      product1 = new Product();
      product2 = new Product();
      product3 = new Product();

      //initalize fields
      product1.productID = 1001;
      product1.productName = "Mobile";
      product1.cost = 20000;
      product1.quantityInStock = 1200;
      product2.productID = 1003;
      product2.productName = "Laptop";
      product2.cost = 45000;
      product2.quantityInStock = 3400;
      product3.productID = 1003;
      product3.productName = "Speakers";
      product3.cost = 36000;
      product3.quantityInStock = 800;

      //Call methods
      product1.CalculateTax();
      product2.CalculateTax();
      product3.CalculateTax();

      //get values from fields
      Console.WriteLine("Product 1:");
      Console.WriteLine("Product ID: " + product1.productID);
      Console.WriteLine("Product Name: " + product1.productName);
      Console.WriteLine("Cost: " + product1.cost);
      Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);
      Console.WriteLine("Tax: " + product1.tax);

      Console.WriteLine("\nProduct 2:");
      Console.WriteLine("Product ID: " + product2.productID);
      Console.WriteLine("Product Name: " + product2.productName);
      Console.WriteLine("Cost: " + product2.cost);
      Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
      Console.WriteLine("Tax: " + product2.tax);

      Console.WriteLine("\nProduct 3:");
      Console.WriteLine("Product ID: " + product3.productID);
      Console.WriteLine("Product Name: " + product3.productName);
      Console.WriteLine("Cost: " + product3.cost);
      Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
      Console.WriteLine("Tax: " + product3.tax);

      Console.ReadKey();
    }
  }
}
