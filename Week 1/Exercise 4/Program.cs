using System;

namespace _4_Alıitırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            Console.Write("Bir sayı giriniz: ");
            a= int.Parse(Console.ReadLine());

            if (a%2==1)
            {
                Console.WriteLine($"{a} Sayısı tek sayıdır.");
            }
            else
            {
                Console.WriteLine($"{a} Sayısı çift sayıdır.");
            }

        }
    }
}
