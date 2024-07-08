class Program
{
  static void Main()
  {
    var getMessage = () => "Hello World";
    //Console.WriteLine(getMessage());

    //Sceanario 1
    Func<int, object> getResult = object(marks) =>
    {
      if (marks > 35)
      {
        return "Pass";
      }
      else
        return 0;
    };
    Console.WriteLine(getResult(50));

    //Sceanario 2
    var GetNumbers = IList<int>() => new int[] { 10, 20, 30 };
    var results = GetNumbers();
    foreach (var number in results)
    {
      Console.WriteLine(number);
    }

    Console.ReadKey();
  }
}