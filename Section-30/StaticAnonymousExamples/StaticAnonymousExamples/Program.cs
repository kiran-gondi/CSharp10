class Student
{
  public int RollNumber { get; set; }

    public List<int> Marks { get; set; }
}

class Teacher
{
  public static int MinPassMarksStatic {get; set;} = 35;
  public const int MinPassMarksConstant = 35;
  public int MinPassMarskInstance { get; set; } = 35;
  //public void GetMarskOfPassedSubjects(int minimumMarks)
  public void GetMarskOfPassedSubjects()
  {
    Student student = new Student()
    {
      RollNumber = 1,
      Marks = new List<int> { 34, 10, 50, 70, 80, 90 }
    };

    //int minimumPassMarks = 35;

    //Get marks of passed subjects. Assuming minimum pass marks is 35
    //student.Marks.Where(x=>x > 35);
    //IEnumerable<int> passedSubjects = student.Marks.Where((int n) =>
    //{
    //  if (n >= minimumPassMarks)
    //    return true;
    //  else return false;
    //});

    //Static Anonymous Functions
    IEnumerable<int> passedSubjects = student.Marks.Where(static (int n) =>
    {
      //if (n >= minimumPassMarks)
      //if (n >= minimumMarks)
      //if (n >= MinPassMarksStatic)
      if (n >= MinPassMarksConstant)
      //if (n >= MinPassMarskInstance)
        return true;
      else 
        return false;
    });

    foreach (int n in passedSubjects)
    {
      Console.WriteLine(n);
    }
  }
}

class Program
{
  static void Main()
  {
    Teacher t = new Teacher();
    t.GetMarskOfPassedSubjects();

    Console.ReadKey();
  }
}