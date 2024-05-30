namespace ProductAPI.Model;

public class Product
{
    public int ProductId {get;set;}

    public string ProductName {get;set;}

    public string ProductDescription {get;set;}
    public decimal ProductPrice {get;set;}

    public bool ProductInStock {get;set;}

    public Product(
        int ProductId, 
        string ProductName, 
        string ProductDescription, 
        decimal ProductPrice, 
        bool ProductInStock)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.ProductDescription = ProductDescription;
        this.ProductPrice = ProductPrice;
        this.ProductInStock = ProductInStock;
    }

}