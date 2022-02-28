using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 Adet sayı giriniz.");
            int toplam =0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());

                toplam+= sayi;
            }

            Console.WriteLine(toplam);
        }
    }
}
