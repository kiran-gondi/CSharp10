using System.Collections.Generic;

namespace CollegeOneToMany
{
  /// <summary>
  /// Represents a Student
  /// </summary>
  public class Student
  {
    public int RollNo { get; set; }
    public string StudentName { get; set; }
    public string Email { get; set; }

    public List<Examination> Examinations { get; set; }
  }
}