// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Invisibility Cloak",
        Price = 150.00M,
        Sold = false,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Phoenix Feather Wand",
        Price = 75.00M,
        Sold = false,
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "Love Potion",
        Price = 25.00M,
        Sold = true,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Flying Broomstick",
        Price = 200.00M,
        Sold = false,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Dragon Hide Gloves",
        Price = 50.00M,
        Sold = false,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Healing Potion",
        Price = 30.00M,
        Sold = false,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Enchanted Mirror",
        Price = 90.00M,
        Sold = false,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Elder Wand",
        Price = 300.00M,
        Sold = false,
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "Sorcerer's Stone",
        Price = 500.00M,
        Sold = true,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Wizard Hat",
        Price = 40.00M,
        Sold = false,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Truth Serum",
        Price = 35.00M,
        Sold = true,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Crystal Ball",
        Price = 120.00M,
        Sold = false,
        ProductTypeId = 3
    }
};

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Name = "Apparel"
    },
    new ProductType()
    {
        Id = 2,
        Name = "Potions"
    },
    new ProductType()
    {
        Id = 3,
        Name = "Enchanted Objects"
    },
    new ProductType()
    {
        Id = 4,
        Name = "Wands"
    },
};