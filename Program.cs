﻿// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Invisibility Cloak",
        Price = 150.00M,
        Sold = false,
        ProductTypeId = 1,
        DateStocked = new DateTime(2019,02,02)
    },
    new Product()
    {
        Name = "Phoenix Feather Wand",
        Price = 75.00M,
        Sold = false,
        ProductTypeId = 4,
        DateStocked = new DateTime(2018,02,02)
    },
    new Product()
    {
        Name = "Love Potion",
        Price = 25.00M,
        Sold = true,
        ProductTypeId = 2,
        DateStocked = new DateTime(2018,12,12)
    },
    new Product()
    {
        Name = "Flying Broomstick",
        Price = 200.00M,
        Sold = false,
        ProductTypeId = 3,
        DateStocked = new DateTime(2016,11,11)
    },
    new Product()
    {
        Name = "Dragon Hide Gloves",
        Price = 50.00M,
        Sold = false,
        ProductTypeId = 1,
        DateStocked = new DateTime(2020,01,01)
    },
    new Product()
    {
        Name = "Healing Potion",
        Price = 30.00M,
        Sold = false,
        ProductTypeId = 2,
        DateStocked = new DateTime(2018,04,04)
    },
    new Product()
    {
        Name = "Enchanted Mirror",
        Price = 90.00M,
        Sold = false,
        ProductTypeId = 3,
        DateStocked = new DateTime(2017,05,05)
    },
    new Product()
    {
        Name = "Elder Wand",
        Price = 300.00M,
        Sold = false,
        ProductTypeId = 4,
        DateStocked = new DateTime(2016,10,10)
    },
    new Product()
    {
        Name = "Sorcerer's Stone",
        Price = 500.00M,
        Sold = true,
        ProductTypeId = 3,
        DateStocked = new DateTime(2019,08,08)
    },
    new Product()
    {
        Name = "Wizard Hat",
        Price = 40.00M,
        Sold = false,
        ProductTypeId = 1,
        DateStocked = new DateTime(2017,01,10)
    },
    new Product()
    {
        Name = "Truth Serum",
        Price = 35.00M,
        Sold = true,
        ProductTypeId = 2,
        DateStocked = new DateTime(2020,02,02)
    },
    new Product()
    {
        Name = "Crystal Ball",
        Price = 120.00M,
        Sold = false,
        ProductTypeId = 3,
        DateStocked = new DateTime(2022,02,02)
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
        Console.WriteLine($"\n{i + 1}. {products[i].Name} {(products[i].Sold ? "sold for" : "is available for")} ${products[i].Price} and is in the category: {productTypeDictionary[products[i].ProductTypeId]}. {(products[i].Sold ? "" : $"This product was shelved {products[i].DaysOnShelf} days ago.")}");

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

    string choice = Console.ReadLine();

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
    Console.WriteLine("\nType a product name to remove from inventory:\n");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    Console.WriteLine("");

    try
    {
        int response = int.Parse(Console.ReadLine().Trim());

        products.RemoveAt(response - 1);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("\nInvalid response...");
    }
}

void UpdateProduct()
{
    Console.WriteLine("\nChoose a product to edit:\n");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    Console.WriteLine("");

    Product chosenProduct = null;

    while (chosenProduct == null)
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];

        Console.WriteLine($"\nPlease enter a new name ({chosenProduct.Name}):\n");
        chosenProduct.Name = Console.ReadLine();

        Console.WriteLine($"\nPlease enter a new price ({chosenProduct.Price}):\n");
        chosenProduct.Price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nIs the product available? (Y/N)\n");
        string isAvailable = Console.ReadLine().Trim();

        switch (isAvailable)
        {
            case "Y":
                chosenProduct.Sold = false;
                break;
            case "N":
                chosenProduct.Sold = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("\nInvalid option...");
                UpdateProduct();
                break;
        }

        Console.WriteLine(@"
Please enter a category:
        
1. Apparel
2. Potions
3. Enchanted Objects
4. Wands
");
        chosenProduct.ProductTypeId = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProduct updated\n");
    }
}

void GetProductTypeId()
{
    Console.WriteLine("\u001b[4mSelect a category:\u001b[0m");
    Console.WriteLine(@"
1. Apparel
2. Potions
3. Enchanted Objects
4. Wands
");

    int response = int.Parse(Console.ReadLine().Trim());

    ViewProductsByProductType(products, response);
}

void ViewProductsByProductType(List<Product> products, int productTypeId)
{
    Console.WriteLine($"\u001b[4m{productTypeDictionary[productTypeId]} Products:\u001b[0m");

    List<Product> filteredProducts = products.Where(
        product => product.ProductTypeId == productTypeId).ToList();

    Console.WriteLine("");
    for (int i = 0; i < filteredProducts.Count; i++)
    {
        Console.WriteLine($"{filteredProducts[i].Name}");
    }

}

void AvailableProducts()
{
    List<Product> availableProducts = products.Where(
        product => !product.Sold).ToList();

    int i = 1;

    foreach (Product product in availableProducts)
    {
        Console.WriteLine($"{i++}. {product.Name}");
    }
}

void Menu()
{
    Console.WriteLine(@$"
{"\u001b[4mMain Menu:\u001b[0m"}
1. View All products
2. Add a Product to Inventory
3. Delete a Product from Inventory
4. Update a Product's Details
5. View Products by Category
6. View Available Products
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
        case "3":
            Console.Clear();
            DeleteProduct();
            Menu();
            break;
        case "4":
            Console.Clear();
            UpdateProduct();
            Menu();
            break;
        case "5":
            Console.Clear();
            GetProductTypeId();
            Menu();
            break;
        case "6":
            Console.Clear();
            AvailableProducts();
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