using System;
using System.Collections.Generic;

namespace ExistsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //collection with marks of student
      List<int> marks = new List<int>() { 40, 95, 22, 78, 21, 81 };

      //Exists: check if the student is failed
      bool result = marks.Exists(x => x < 35);

      if(result == true)
      {
        Console.WriteLine("Student is failed in one or more subjects");
      }
      else
      {
        Console.WriteLine("Student is passed");
      }

      //marks.ForEach(n => { Console.WriteLine(n); });

      //Find: Get marks of first failed subject
      int firstFailedSubject = marks.Find(x => x < 35);
      Console.WriteLine("First Failed subject marks " + firstFailedSubject);

      //FindIndex: Get index of first failed subject
      int firstFailedSubjectIndex = marks.FindIndex(x => x < 35);
      Console.WriteLine("First Failed subject marks index " + firstFailedSubjectIndex);

      //FindLast: Get marks of first failed subject from last
      int firstFailedSubjectFromLast = marks.FindLast(x => x < 35);
      Console.WriteLine("First Failed subject marks from last " + firstFailedSubjectFromLast);

      //FindLastIndex: Get index of first failed subject from last
      int firstFailedSubjectFromLastIndex = marks.FindLastIndex(x => x < 35);
      Console.WriteLine("First Failed subject marks index from last " + firstFailedSubjectFromLastIndex);

      //FindAll: Get marks of first failed subject
      List<int> excludedFailedSubjects = marks.FindAll(x => x > 35);
      //Console.WriteLine("Excluded Failed subject marks " + excludedFailedSubjects.ForEach(n => { Console.WriteLine(n); }));
      Console.WriteLine("Excluded Failed subject marks ");
      excludedFailedSubjects.ForEach(n => { Console.WriteLine(n); });

      Console.ReadKey();
    }
  }
}
