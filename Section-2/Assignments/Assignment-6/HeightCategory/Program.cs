namespace HeightCategory
{
  /*
    Write a program to findout "category of height" based on the given height of a person (in inches), using "if".
    Height categories:
    Height is less than 150 cm = "Dwarf"
    Height is between 150 cm and 165 cm = "Average height"
    Height is between 165 cm and 195 cm = "Tall"
    Height is above 195 cm = "Abnormal height"

    Note: 1 inch = 2.54 centimeter

    Eg:
    Input: 75
    Output: Tall
  */
  internal class Program
  {
    static void Main(string[] args)
    {

      //NOTE: 1inch = 2.54 cm
      int inputHeight = 75;

      int inputHeightInCms = Convert.ToInt32(inputHeight * 2.54);

      if(inputHeightInCms < 150)
      {
        Console.WriteLine("Dwarf");
      }else if(inputHeightInCms > 150 && inputHeightInCms < 165)
      {
        Console.WriteLine("Average Height");
      }else if(inputHeightInCms > 165 && inputHeightInCms < 195)
      {
        Console.WriteLine("Tall");
      }else if(inputHeightInCms > 195)
      {
        Console.WriteLine("Abnormal Height");
      }

      Console.ReadKey();
    }
  }
}
