using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create an object of Queue class
      Queue<string> queue = new Queue<string>();

      //Enqueue(Add)
      queue.Enqueue("Task3");
      queue.Enqueue("Task5");
      queue.Enqueue("Task1");
      queue.Enqueue("Task4");
      queue.Enqueue("Task2");

      //Dequeue(Remove)
      string dq = queue.Dequeue();
      Console.WriteLine("Dequeue-1: " + dq);

      string dq1 = queue.Dequeue();
      Console.WriteLine("Dequeue-2: " + dq1);


      //Peek
      string pk = queue.Peek();
      Console.WriteLine("Peek: " + pk);

      Console.WriteLine();

      //foreach
      foreach (var item in queue) { 
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}
