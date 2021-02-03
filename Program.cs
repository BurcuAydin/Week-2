using System;

namespace Odev6
{
    /*Herhangi bir e-ticaret sistemine giriniz.
    Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. 
    Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz. */
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Marka = "Adidas";
            product1.UrunAcıklama = "T-shirt";
            product1.Puan = 10;

            Product product2 = new Product();
            product2.Marka = "Gucci";
            product2.UrunAcıklama = "Spor Ayakkabı";
            product2.Puan = 8;

            Product product3 = new Product();
            product3.Marka = "Koton";
            product3.UrunAcıklama = "Lila Kazak";
            product3.Puan = 5;

            Product[] product = new Product[] { product1, product2, product3 };

            //Ürünleri for ile listele.

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].Marka + ":" + product[i].UrunAcıklama+ ":" + product[i].Puan);

            }

            Console.WriteLine("--------------------------------------------------");

            //Ürünleri foreach ile listele.
            foreach(Product urun in product)
            {
                Console.WriteLine(urun.Marka + ":" + urun.UrunAcıklama + ":" + urun.Puan);
}
        Console.WriteLine("--------------------------------------------------");

            //Ürünleri while ile listele.
            int k = 0;
            while (k<product.Length)
            {
                Console.WriteLine(product[k].Marka + ":" + product[k].UrunAcıklama + ":" + product[k].Puan);
                k++;
            }
        }
            
           
            

        class Product
        {
            public string Marka { get; set; }
            public string UrunAcıklama { get; set; }
            public int Puan { get; set; }
        }
    }
}
