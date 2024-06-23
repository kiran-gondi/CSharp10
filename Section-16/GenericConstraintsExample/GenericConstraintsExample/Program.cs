class Program
{
  static void Main()
  {

    //create object of generic class
    MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
    mp.student = new GraduateStudent() { Marks = 80 };
    mp.PrintMarks();

    MarksPrinter<PostGraduateStudent> pgs = new MarksPrinter<PostGraduateStudent>();
    pgs.student = new PostGraduateStudent() { Marks = 180 };
    pgs.PrintMarks();

    Console.ReadKey();
  }
}