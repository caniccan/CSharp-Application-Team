using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac =0;
            Console.WriteLine("N sayısını giriniz: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (i % 3 == 0 && i% 7 == 0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine($"1-{N} değer aralığında "+sayac+" adet 3'e ve 7'ye tam bölünen sayı vardır.");
        }
    }
}
