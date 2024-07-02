class Program
{
  static void Main()
  {
    Thread mainThread = Thread.CurrentThread;
    mainThread.Name = "Main thread demo";
    Console.WriteLine(mainThread);
    Console.WriteLine(mainThread.Name);
    
    Console.WriteLine("Main Method");
    Method1();
    Console.ReadKey();
  }

  static void Method1()
  {
    Console.WriteLine("Method 1");
  }
}