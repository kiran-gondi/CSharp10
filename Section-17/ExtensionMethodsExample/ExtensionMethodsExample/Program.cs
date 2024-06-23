using ClassLibrary1;
using ExtensionMethodsExample;

class Program
{
  static void Main()
  {
    //create object
    Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };
    
    //call the extension method
    Console.WriteLine(p.GetDiscount());

    Console.ReadKey();
  }
}