class Program
{
  static void Main(string[] args)
  {

    Console.WriteLine($"{args.Length} values found." );
    int sum = 0;
    foreach (string i in args) {
      if(int.TryParse(i, out int result))
      {
        sum += result;
      }
    }
    Console.WriteLine($"Total of all numbers: {sum}");
    Console.ReadKey();
    //NOTE: Run this solution via command prompt with Command Line Arguments(CLI).
  }
}