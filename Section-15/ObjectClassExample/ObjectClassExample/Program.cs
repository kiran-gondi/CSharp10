class Program
{
  public static void Main()
  {
    //Create an object of Person class
    System.Object personObject = new Person() { PersonName = "rahul", Email = "rahul@ddlj.com" };

    //access methods
    Console.WriteLine(personObject.Equals(new Person() { PersonName = "rahul", Email = "rahul@ddlj.com" }));
    Console.WriteLine(personObject.GetHashCode());
    Console.WriteLine(personObject.ToString());
    Console.WriteLine(personObject.GetType().ToString()); //We can't overide the GetType().ToString() from the class.

    //Supplier supplier = new Supplier() { PersonName = "rob", Email = "rob@wills.com" };
    //Console.WriteLine("\n" + supplier.ToString()); 

    Console.ReadKey();
  }
}