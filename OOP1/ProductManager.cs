using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //parantez için sanki (string ad) der gibi anlamı product türünde bir şey ver diyorsun 
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        
        
    }
}
