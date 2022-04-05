using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("°C cinsinden sıcaklığı giriniz : ");
            double c= Math.Round((double.Parse(Console.ReadLine())),2);
            double f = Math.Round(((c*(1.8))+32),2);            
            Console.WriteLine("{0}°C, {1}°F değerine denktir. ",c,f);
        }
    }
}
