using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int a = int.Parse(Console.ReadLine());
            int b =1;
            for (int i = 1;i<=a;i++)
            {
                b*= i;
            }
            Console.WriteLine(b);
        }
    }
}
