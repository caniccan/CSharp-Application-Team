using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string a = Console.ReadLine();
            string b = ("aeıioöuü");

            Console.Write("Girdiğiniz metindeki sesli harflar : ");
            for (int i = 0; i < 8; i++)
            {
                if (a.Contains(b[i]))
                {
                    Console.Write(b[i]+" ");
                }
            }
        }
    }
}
