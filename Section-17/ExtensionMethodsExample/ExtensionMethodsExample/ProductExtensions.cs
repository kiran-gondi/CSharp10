using ClassLibrary1;

namespace ExtensionMethodsExample
{
  //static class for extension method
  public static class ProductExtensions
  {
    //extension method for product class
    public static double GetDiscount(this Product product)
    {
      return product.ProductCost * product.DiscountPercentage / 100;
    }
  }
}
