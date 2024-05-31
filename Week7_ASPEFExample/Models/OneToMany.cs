namespace EFCoreExample.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        // This establishes 1 to many relationship for the category class
        // a category can be associated wtih many productions
        //We use the ICollection <> interface because Entity Framework manages this relationship for us

        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //Products can only have a single category 
        //Products will also hold the foreign key assoicated wtih the category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}