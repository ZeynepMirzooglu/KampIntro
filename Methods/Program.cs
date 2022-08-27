using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.ProductName = "Elma";
			product1.Description = "Amasya Elması";
			product1.UnitPrice = 12;
			product1.Id = 1;

			Product product2 = new Product();
			product2.ProductName = "Kiraz";
			product2.Description = "Napolyon kirazi";
			product2.UnitPrice = 30;
			product2.Id = 2;

			Product product3 = new Product();
			product3.ProductName = "Erik";
			product3.Description = "Papaz Eriği";
			product3.UnitPrice = 35;
			product3.Id = 3;

			Product product4 = new Product();
			product4.ProductName = "Karpuz";
			product4.Description = "Diyarbakır Karpuzu";
			product4.UnitPrice = 68;
			product4.Id = 4;

			Product[] products = new Product[] { product1, product2, product3, product4 };

			foreach (var product in products)
			{
				Console.WriteLine("Ürünün adı : " + product.ProductName + "\n" + "Ürünün açıklaması : " + product.Description + "\n" + "Ürünün fiyatı = " + product.UnitPrice + "\n" + "*********");
			}

			Console.WriteLine("--------Metotlar--------");
			CartManager cartManager=new CartManager();
			cartManager.Add(product1);
            cartManager.Add(product3);
            cartManager.Add(product4);

            cartManager.Add2("Armut", "Yeşil", 12);
            cartManager.Add2("Elma", "Yeşil", 12);
            cartManager.Add2("Erik", "Yeşil", 12);


        }
    }
}