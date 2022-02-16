using System;

namespace _3_Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b=0;
            Console.Write("Kısa Kenar: ");
            a=Int32.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar: ");
            b=Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Alan {a*b}");
            Console.WriteLine($"Çevre {a*2 + b*2}");
        }
    }
}
