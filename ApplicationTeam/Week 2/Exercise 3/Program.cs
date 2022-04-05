using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen seçim yapınız");
            Console.WriteLine("1- Cümle girdisi");
            Console.WriteLine("2- Kelime girdisi");
            int secim = int.Parse(Console.ReadLine());
            string[] b = new string[50];
            if (secim == 1)
            {
                Console.WriteLine("Cümleyi giriniz : ");
                string cumle = Console.ReadLine();
                b = cumle.Split(" ");
                Array.Sort(b);
                foreach (var item in b)
                {
                    Console.WriteLine(item); 
                }
            }            
            else if (secim== 2)
            {
                Console.WriteLine("Kaç adet kelime girmek istersiniz? : ");
                int n = int.Parse(Console.ReadLine());
                String[] a = new String[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. kelimeyi giriniz: ", i+1);
                    a[i]=Console.ReadLine();
                }
                Array.Sort(a);
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }                               
            }
        }
    }
}
