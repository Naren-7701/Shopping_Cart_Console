using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsole
{
    public interface IProduct
    {
        /// <summary>
        /// Product Interface
        /// </summary>
        int pId{get; set;}
        string pName{get;set;}
        int pPrice{get;set;}
    }
}
