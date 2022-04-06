using System;

namespace ClassApplication
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Product class => name, price, description.
            // Get unlimited number of product information and keep all this value in array.
            // Allow user to determine the number of products.
            // Added products will be listed.

            
            Console.Write("Adet :");
            int adet = int.Parse(Console.ReadLine());
            Product[] products = new Product[adet];
            int i = 0;
            Product prd;
            do
            {
                prd = new Product();

                Console.Write("Ürün adı :");
                prd.Name=Console.ReadLine();

                Console.Write("Ürün fiyatı :");
                prd.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Açıklama :");
                prd.Description= Console.ReadLine();

                products[i] = prd;
                i++;
            }
            while (adet>i);
            Console.WriteLine("*****************");
            //for (int a = 0; a < products.Length; a++)
            //{
            //    Console.WriteLine($"ürün adı: {products[a].Name} ürün fiyat: {products[a].Price} açıklama: {products[a].Description}");
            //}
            foreach (var urun in products)
            {
                Console.WriteLine($"ürün adı: {urun.Name} ürün fiyat: {urun.Price} açıklama: {urun.Description}");
            }
        }
    }
}
