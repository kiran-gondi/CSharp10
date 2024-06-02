namespace LargestOfThreeNos
{
  /*
    Write a C//program to find out largest number among three numbers, using "if".
    Eg:
    num1 = 60
    num2 = 45
    num3 = 123
    Output: 123
*/
  internal class Program
  {
    static void Main(string[] args)
    {
      int num1 = 60, num2 = 45, num3 = 123;

      int biggest;

      if(num1 >= num2)
      {
        if(num1 > num3)
        {
          biggest = num1;
        }
        else
        {
          biggest = num3;
        }
      }
      else if(num2 >= num3)
      {
        biggest = num2;
      }
      else
      {
        biggest = num3;
      }

      Console.WriteLine($"Biggest no is {biggest}");
      Console.ReadKey();
    }
  }
}
