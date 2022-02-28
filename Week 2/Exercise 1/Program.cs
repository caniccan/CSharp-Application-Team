using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int max_deger =1000000;
            int sayac = 0;
            for (int sayi = 2; sayi <= max_deger; sayi++)
            {
                int kontrol = 0;
 
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0) 
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    Console.WriteLine("{0} asaldır.",sayi);
                    sayac++;
                }                
            }
            Console.WriteLine("============================");
            Console.WriteLine($"{sayac} adet asal sayı var");
            
        }
    }
}
