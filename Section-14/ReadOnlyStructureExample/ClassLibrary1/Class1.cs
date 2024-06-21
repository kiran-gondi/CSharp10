public readonly struct Marvel
{
    //field
    private readonly string _characterName;

    //public readonly property
    public string CharacterName { get {
      return _characterName;
    } 
  }

  //public method
  public void PrintCharacteName()
  {
    Console.WriteLine(this.CharacterName);
  }

    //constructors
    public Marvel(string characterName)
    {
        this._characterName = characterName;
    }
}