namespace FeetToCentimeters
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Q:Write a C# program convert a person's height (in feet and inches) to centimeters.

      //Formula
      //1 inch = 2.54 cm
      //1 feet = 12 inches

      //Ex: feet = 5, inches = 7 output: 170.18 cm
      int personInFeet = 5;
      int personInInches = 7;

      double personInCms;

      //Convert Feet to inches
      double tempFeetToInches = (personInFeet * 12) + personInInches;
      //Console.WriteLine($"Person from feet to Inches: {tempFeetToInches}");

      //Convert inches to cms
      personInCms = (tempFeetToInches * 2.54);
      Console.WriteLine($"Person in cms is: {personInCms}");


      Console.ReadKey();
    }
  }
}
