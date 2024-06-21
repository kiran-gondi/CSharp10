public partial class Product
{
  // public method
  partial void GetTax()
  {
    double tax = Cost * 10 / 100;
    Console.WriteLine("Calculated tax from File3 is:-> " + tax); 
  }
}