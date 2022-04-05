using System;

namespace _7_Alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="";
            Console.Write("Bir cümle giriniz: ");
            a=Console.ReadLine();
            a= a.Replace(" ","");
            Console.WriteLine(a.Length);
        }
    }
}
