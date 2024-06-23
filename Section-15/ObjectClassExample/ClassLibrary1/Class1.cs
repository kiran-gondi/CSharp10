public class Person
{
    //properties
    public string PersonName { get; set; }
    public string Email { get; set; }

  //overriding Equals method
  public override bool Equals(object obj)
  {
    bool result = false;
    Person p = (Person)obj;
    if ((this.PersonName == p.PersonName) && (this.Email == p.Email)) {
      result = true;
    }
    return result;
  }

  //overriding ToString method
  public override string ToString()
  {
    return "Person name: " + this.PersonName + "\n" + "Person Email: "  + this.Email;
  }
}

public class Supplier : Person
{
  //overriding ToString method
  public override string ToString()
  {
    return "Supplier-Person name: " + this.PersonName + "\n" + "Supplier-Person Email: " + this.Email;
  }
}