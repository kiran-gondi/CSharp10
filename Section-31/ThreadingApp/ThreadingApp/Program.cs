using System.Threading;
class Program
{
  static void Main()
  {
    Thread mainThread = Thread.CurrentThread;
    mainThread.Name = "Main thread demo";
    //Console.WriteLine(mainThread);
    Console.WriteLine(mainThread.Name);//Main thread demo"

    ThreadPriority tp = mainThread.Priority;
    Console.WriteLine(tp.ToString());//Normal
    Console.WriteLine(mainThread.IsAlive);//True
    Console.WriteLine(mainThread.IsBackground);//False
    
    ThreadState ts = mainThread.ThreadState;
    Console.WriteLine(ts.ToString());//Running

    //Console.WriteLine("Main Method");
    //Method1();
    Console.ReadKey();
  }

  static void Method1()
  {
    Console.WriteLine("Method 1");
  }
}