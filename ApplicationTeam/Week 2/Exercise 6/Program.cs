using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Rastgele sayı atanıyor...");
            Random rastgele = new Random();
            int[] a = new int[10];
            int teksayac =0;
            int ciftsayac=0;
            for (int i = 0; i < 10; i++)
            {
                a[i] = rastgele.Next(1,100);
                if (a[i]% 2 ==0)
                {
                    ciftsayac++;
                }
                else
                {
                    teksayac++;
                }
            }
            Console.WriteLine($"tek sayı adedi: {teksayac} , çift sayı adedi: {ciftsayac}");

        }
    }
}
