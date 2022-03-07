using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac =0;
            Console.Write("Bir sayı giriniz : ");
            int a = int.Parse(Console.ReadLine());
            int[] b= new int[200];
            for (int i = 1; i <= 200; i++)
            {
                if (i% a == 0)
                {   
                    b[sayac]= i;
                    Console.WriteLine(b[sayac]);
                    sayac++;
                }
            }
            Console.WriteLine("===================");
            Console.WriteLine("1-200 aralığında {0} sayısına tam bölünen {1} adet sayı vardır.",a, sayac);

        }
    }
}
