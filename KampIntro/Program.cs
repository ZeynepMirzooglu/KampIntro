using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }


            Console.WriteLine(sistemeGirisYapmisMi == true ? "Kullanıcı ayarları butonu" : "Giriş yap butonu");

            Console.WriteLine(kategoriEtiketi);
        }
    }
}