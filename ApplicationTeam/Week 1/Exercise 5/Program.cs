using System;

namespace _5_Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0;
            Console.Write("Bir sayı giriniz: ");
            a= int.Parse(Console.ReadLine());

            if (a <= 100 && 0 <= a)
            {
                Console.WriteLine($"{a} Sayısı 0-100 sayıları arasındadır.");
            }
            else
            {
                Console.WriteLine($"{a} Sayısı 0-100 sayıları arasında değildir.");
            }

        }
    }
}
