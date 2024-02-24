using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsole
{
    class ShoppingCartItem
    {
        /// <summary>
        /// Shopping Cart Induvidual Item
        /// </summary>
        public concProduct Product {get; set;}
        public int Quantity {get; set;}
    }

    class ShoppingCart
    {
        public List<ShoppingCartItem> cart=new List<ShoppingCartItem>();
        public void AddItem(concProduct product,int quantity)
        {
            // To Add a Product to Cart
            var existing=cart.Find(item => item.Product.pId == product.pId);
            if(existing!=null)
                existing.Quantity+=quantity;
            else
                cart.Add(new ShoppingCartItem{Product=product,Quantity=quantity});
            Console.WriteLine("Product Added to Cart");
        }

        public void RemoveItem(int productId,int quantity)
        {
            // To Remove a Product from Cart
            var existing =cart.Find(item => item.Product.pId==productId);
            if(existing == null)
            {
                Console.WriteLine("Product Not Found in Cart.");
                return;
            }
            existing.Quantity -= quantity;
            if(existing.Quantity <= 0)
                cart.Remove(existing);
            Console.WriteLine("Product Removed from Cart.");
        }
        public int CalculateTotal()
        {
            // To Return Total Amount of Cart
            int tot_price =0;
            foreach(var item in cart)
                tot_price += item.Product.pPrice * item.Quantity;
            return tot_price;  
        }
        public void DisplayCart()
        {
            // To Display the Whole Cart
            Console.WriteLine("Checkout Cart");
            foreach (var item in cart)
                Console.WriteLine($"ID:{item.Product.pId}, {item.Product.pName} x {item.Quantity}: {item.Product.pPrice} each");
            Console.WriteLine($"Total Price: {CalculateTotal()}");
        }
        public void ClearCart()
        {
            // To Empty the Whole Cart
            cart.Clear();
        }
    }
}