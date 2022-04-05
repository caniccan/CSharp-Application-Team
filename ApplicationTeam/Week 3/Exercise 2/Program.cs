using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac =0;
            Console.Write("Arama yapılacak metni giriniz : ");
            string a = Console.ReadLine().Trim();
            Console.Write("Aranacak dizini giriniz : ");
            string b = Console.ReadLine().Trim();
            int al = a.Length;
            int bl = b.Length;
            for (int i = 0; i <=(al-bl); i++)
            {
                if (a.Substring(i,bl)==b)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Aradığınız dizin, metin içerisinde {0} kez geçiyor.",sayac);

        }
    }
}
