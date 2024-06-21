class Program
{
  public static void Main()
  {

    //Create object of static class
    //Country c = new Country();
    Console.WriteLine(Country.CountryName);
    Console.WriteLine(Country.NoOfStates);
    Console.WriteLine(Country.GetTotalNoOfUnionTerritories());

    Console.ReadKey();
  }
}