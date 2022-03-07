using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz : ");
            string[] a = Console.ReadLine().Split(" ");
            Console.WriteLine(a[0]);
        }
    }
}
