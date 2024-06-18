﻿namespace Methods
{
  public class Product
  {
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }

    //method 
    /* cost<=20000 then tax = 10%
     * cost>20000 then tax = 12.5%*/
    public void CalculateTax()
    {
      double t = 0;

      if (cost <= 20000)
      {
        t = cost * 10 / 100;
      }
      else
      {
        t = cost * 12.5 / 100;
      }

      tax = t;
    }

    //Set method for ProductID
    public void SetProductID(int productId)
    {
      productID = productId;
    }

    //Get method for ProductId
    public int GetProductID() 
    { 
      return productID; 
    }

    //Set method for ProductName
    public void SetProductName(string productNameValue)
    {
      productName = productNameValue;
    }

    //Get method for ProductName
    public string GetProductName()
    {
      return productName;
    }
  }
}
