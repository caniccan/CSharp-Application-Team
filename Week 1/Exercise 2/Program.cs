using System;

namespace _2_Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c=0;
            
            Console.Write("1. Sayı: ");
            a=Int32.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            b=Int32.Parse(Console.ReadLine());
            c = a+b;
            Console.WriteLine($"{a} ve {b} Sayılarının toplamı: {c}");


            
            
        }
    }
}
