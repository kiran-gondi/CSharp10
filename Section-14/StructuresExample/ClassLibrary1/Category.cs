public struct Category
{
  //private field
  private int _categoryId;
  private string _categoryName;

  //public fields
  public int CategoryId
  {
    get { return _categoryId; }
    set 
    {
      if(value >= 1 && value <= 100) { 
      _categoryId = value;
      }
    }
  }

  public string Categoryname
  {
    get { return _categoryName; }
    set 
    {
      if(value.Length <= 40)
        _categoryName = value; 
    }
  }

  public int GetCategoryNameLength()
  {
    return this._categoryName.Length;
  }

}