using System;
using System.Collections.Generic;

namespace ShoppingCartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("-- Shopping Cart Console App --");
                Console.WriteLine("1. List All Products in the Store");
                Console.WriteLine("2. Add Product to the Cart");
                Console.WriteLine("3. Remove Product from the Cart");
                Console.WriteLine("4. Checkout Cart with Price");
                Console.WriteLine("5. Empty the Cart");
                Console.WriteLine("6. Exit Console");
                Console.WriteLine("Please Enter the Choice:");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch(choice)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddToCart();
                        break;
                    case 3:
                        RemoveFromCart();
                        break;
                    case 4:
                        Checkout();
                        break;
                    case 5:
                        ClearCart();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        /// <summary>
        /// Main Program to Add Product and update Cart
        /// </summary>
        static List<concProduct> products = new List<concProduct>()
        {
            // Product List
            new concProduct(01,"Surf Excel Washing Powdwer",80),
            new concProduct(02,"Colgate Toothpaste",70),
            new concProduct(03,"Parachute Oil",60),
            new concProduct(04,"Vaseline",25),
            new concProduct(05,"Vicks Vapourub",25),
            new concProduct(06,"Bisleri",20),
            new concProduct(07,"Pepsi",45),
            new concProduct(08,"Coco cola",45),
            new concProduct(09,"Sunrise Coffee powder",15),
            new concProduct(10,"Clinic Plus Shampoo",80),
            new concProduct(11,"Dettol Soap",30),
            new concProduct(12,"Nycil Powder",45),
            new concProduct(13,"Diary Milk",20),
            new concProduct(14,"Marie Gold Biscuit",20),
            new concProduct(15,"Maggi Noodles",20),
            new concProduct(16,"Lays",20),
            new concProduct(17,"Vim Gel Liquid",20),
            new concProduct(18,"Garnier Face Wash",75),
            new concProduct(19,"Amul Ice Cream",40),
            new concProduct(20,"Kissan Jam",50)
        };

        static ShoppingCart cart = new ShoppingCart();

        static void ListProducts()
        {
            Console.WriteLine("List of Products");
            foreach(var product in products)
                Console.WriteLine($"ID:{product.pId}, {product.pName}, Rs: {product.pPrice}");
        }

        static void AddToCart()
        {
            Console.WriteLine("Enter the Product ID");
            int productId;
            int.TryParse(Console.ReadLine(),out productId);
            var product = products.Find(p => p.pId == productId);
            if(product==null)
            {
                Console.WriteLine("Product not found");
                return;
            }
            Console.WriteLine("Enter Quantity");
            int quantity;
            int.TryParse(Console.ReadLine(),out quantity);
            if(quantity <= 0)
            {
                Console.WriteLine("Invalid Quantity");
                return;
            }
            cart.AddItem(product,quantity);
        }

        static void RemoveFromCart()
        {
            Console.WriteLine("Enter product ID");
            int productId;
            int.TryParse(Console.ReadLine(),out productId);
            Console.WriteLine("Enter Quantity");
            int quantity;
            int.TryParse(Console.ReadLine(),out quantity);
            if(quantity <= 0)
            {
                Console.WriteLine("Invalid Quantity");
                return;
            }
            cart.RemoveItem(productId,quantity);
        }

        static void Checkout()
        {
            cart.DisplayCart();
        }

        static void ClearCart()
        {
            cart.ClearCart();
        }
    }
}