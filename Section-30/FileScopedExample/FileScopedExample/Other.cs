Something something = new Something();
Console.WriteLine(something.student);
Console.WriteLine(something.teacher);
Console.ReadKey();

class Something
{
  public College.Student student = new College.Student();
  public College.Teacher teacher = new College.Teacher();
}