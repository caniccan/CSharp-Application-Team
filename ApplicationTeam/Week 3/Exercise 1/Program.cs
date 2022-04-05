using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz : ");
            string a = Console.ReadLine().Trim();
            string[] b = a.Split(" ");
            Console.WriteLine("Girdiğiniz metinde {0} kelime bulunmaktadır.",b.Length);
        }
    }
}
