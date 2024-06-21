public class Person
{
  public string Name { get; set; }
  public string Email { get; set; }

  public AgeGroupEnumeration AgeGroup { get; set; }
}

public enum AgeGroupEnumeration : short //Can't use string here
{
  Child,
  Teenager,
  Adult,
  Senior
}