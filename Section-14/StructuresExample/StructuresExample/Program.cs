class Program
{
  public static void Main()
  {
    //Create structure instance
    Category category = new Category(22, "Logistics");

    //initialize fields through properties.
    //category.CategoryId = 20;
    //category.Categoryname = "General";

    //access methods
    Console.WriteLine(category.CategoryId);
    Console.WriteLine(category.Categoryname);
    Console.WriteLine(category.GetCategoryNameLength());

    Console.ReadKey();  
  }
}