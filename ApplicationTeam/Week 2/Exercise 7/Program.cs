using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            Console.WriteLine("Metin tekrar sayısını giriniz: ");
            int tekrar = int.Parse(Console.ReadLine());
            for (int i = 0; i < tekrar; i++)
            {
                Console.WriteLine(metin + " ");
            }
        }
    }
}
