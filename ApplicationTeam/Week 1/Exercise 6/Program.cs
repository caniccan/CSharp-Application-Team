using System;

namespace _6_Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b=0;
            Console.Write("Boyunuzu Giriniz: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz: ");
            b = double.Parse(Console.ReadLine());
            a *= a;
            Console.WriteLine($"Vücut kitle indeksi : {b/a} BMI ");
            


        }
    }
}
