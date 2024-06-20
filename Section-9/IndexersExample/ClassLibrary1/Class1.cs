﻿public class Car
{
  //private
  private string[] _brands = new string[] {"Swift", "Hyundai", "Benz" };
  private string[] _names = new string[] { "first", "second", "third" };

  //public indexer
  public string this[int index]
  {
    set
    {
      this._brands[index] = value;
    }
    get { return this._brands[index]; }
  }

  //indexer overloading
  public string this[string name]
  {
    set
    {
      this._brands[Array.IndexOf(_names, name)] = value;
    }
    get { return this._brands[Array.IndexOf(_names, name)]; }
  }
}
