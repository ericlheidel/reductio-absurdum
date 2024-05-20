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

Dictionary<int, string> productTypeDictionary = new Dictionary<int, string>();
foreach (ProductType productType in productTypes)
{
    // populate a dictionary, this is the translation of the code:
    // dictionaryName[key] = value;
    productTypeDictionary[productType.Id] = productType.Name;
}

string greeting = @"
Welcome to Reductio & absurdum
Wizard supplies for over 1000 years";

void ExitApp()
{
    Console.WriteLine("\nProgram Exited...\n");
}

void InvalidOption()
{
    Console.WriteLine("\nInvalid option...\n");
}

void ViewAllProducts()
{
    Console.WriteLine("\u001b[4mProducts List\u001b[0m");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"\n{i + 1}. {products[i].Name} {(products[i].Sold ? "sold for" : "is available for")} ${products[i].Price} and is in the category: {productTypeDictionary[products[i].ProductTypeId]}");
    }
}

void NewProductMenu()
{
    Console.WriteLine("\nSelect one of the following categories:\n");
    Console.WriteLine(@"
1. Apparel
2. Potions
3. Enchanted Objects
4. Wands
");
}

void AddProduct()
{
    Product newProduct = new Product();

    Console.WriteLine("\nEnter a product name:\n");
    newProduct.Name = Console.ReadLine().Trim();

    Console.WriteLine("\nEnter a price:\n");
    newProduct.Price = decimal.Parse(Console.ReadLine().Trim());

    newProduct.Sold = false;

    NewProductMenu();

    string choice = null;
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Clear();
            newProduct.ProductTypeId = 1;
            break;
        case "2":
            Console.Clear();
            newProduct.ProductTypeId = 2;
            break;
        case "3":
            Console.Clear();
            newProduct.ProductTypeId = 3;
            break;
        case "4":
            Console.Clear();
            newProduct.ProductTypeId = 4;
            break;
        default:
            Console.Clear();
            InvalidOption();
            NewProductMenu();
            break;
    }

    products.Add(newProduct);
    Console.Clear();
    Console.WriteLine("\nProduct added to inventory...\n");

}

void DeleteProduct()
{

}

void UpdateProduct()
{

}

void Menu()
{
    Console.WriteLine(@$"
{"\u001b[4mMain Menu:\u001b[0m"}
1. View All products
2. Add a Product to Inventory
3. Delete a Product from Inventory
4. Update a Product's Details
9. Clear Window
0. Exit

Please choose an option...");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Clear();
            ViewAllProducts();
            Menu();
            break;
        case "2":
            Console.Clear();
            AddProduct();
            Menu();
            break;
        case "9":
            Console.Clear();
            Console.WriteLine(greeting);
            Menu();
            break;
        case "0":
            Console.Clear();
            ExitApp();
            break;
        default:
            Console.Clear();
            InvalidOption();
            Menu();
            break;
    }
}

void App()
{
    Console.Clear();
    Console.WriteLine(greeting);
    Menu();
}

App();