using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        public void Add(Product product)
        {

            Console.WriteLine("Sepete eklendi! Tebrikler sepete ürünü eklediniz!"+ " Sepete eklenen :  " +product.ProductName);
        }

        public void Add2(string productName,string description, decimal price)
        {
            Console.WriteLine("Sepete eklendi."+ productName);
        }

      
    }
}
