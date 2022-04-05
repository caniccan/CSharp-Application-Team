using System;
using System.Collections;
namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string aranan;
            var liste = new ArrayList()
            {
                "Emine", "Ayşe", "Fatma", "Hasan", "Cemal", "Kemal"
            };
            for (int i = 0; i <20; i++)
            {
                Console.WriteLine("Lütfen seçim yapınız.");
                Console.WriteLine("========================");
                Console.WriteLine("1-Listeye eleman ekleme");
                Console.WriteLine("2-Listeden arama yapma");
                Console.WriteLine("3-Listeyi yazdırma");
                Console.WriteLine("4-Çıkış");
                int a =int.Parse(Console.ReadLine().ToLower());
                if (a==1)
                {
                    Console.Write("Eklemek istediğiniz elemanı giriniz : ");
                    liste.Add(Console.ReadLine().ToLower());
                    Console.WriteLine("Ekleme işlemi yapılmıştır.");
                } 
                if (a==3)
                {
                    foreach (var item in liste)
                    {
                        Console.WriteLine(item+" ");
                    }                    
                }  
                if (a==2)
                {      
                    Console.WriteLine("Aranacak elemanı giriniz : ");
                    aranan= Console.ReadLine().ToLower();

                    if (liste.Contains(aranan)==true)
                    {
                        Console.WriteLine("{0} elemanı listede mevcut.",aranan);
                    }
                    else
                    {
                        Console.WriteLine("{0} elemanı listede mevcut değil.",aranan);
                    }                    
                }
                if (a==4)
                {
                    break;
                }
            }
            
        }
    }
}
