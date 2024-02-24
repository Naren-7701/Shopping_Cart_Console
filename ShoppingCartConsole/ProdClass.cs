using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsole
{
    abstract class absProduct : IProduct
    {
        /// <summary>
        /// Abstract class representing a product
        /// </summary>
        public int pId{get;set;}
        public string pName{get;set;}
        public int pPrice{get;set;}
    }

    class concProduct : absProduct
    {
        /// <summary>
        /// // Concrete class representing a Product
        /// </summary>
        public concProduct(int id,string name,int price)
        {
            pId = id;
            pName = name;
            pPrice = price;
        }
    }
}