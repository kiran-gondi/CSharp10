class Program
{
  static void Main()
  {
    //create structure instance
    Marvel marvel = new Marvel("Thanos");
      

    //invoke the propertis and methods
    Console.WriteLine(marvel.CharacterName);
    //marvel.CharacterName = "Thor";
    marvel.PrintCharacteName();

    Console.ReadKey();
  }
}