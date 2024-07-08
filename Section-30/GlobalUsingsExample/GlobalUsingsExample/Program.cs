List<int> numbers = new List<int>() { 1, 2, 3};
List<int> results = numbers.Where(x=>x >= 2).ToList();
foreach(int x in results)
{
  Console.WriteLine(x);
}
Console.ReadKey();
