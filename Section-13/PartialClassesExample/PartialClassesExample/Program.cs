class Program 
{ 
  static void Main()
  {

    Product product = new Product();

    product.ProductId = 123;
    product.Cost = 1000;

    Console.WriteLine("Tax of product is: " + product.GetTax());
    Console.ReadKey();

  }
}