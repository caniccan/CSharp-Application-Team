using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int a = int.Parse(Console.ReadLine().Trim());
            if (a%2==0)
                a/=2;
            else
                a*=2;
            Console.WriteLine(a);
            


        }
    }
}
