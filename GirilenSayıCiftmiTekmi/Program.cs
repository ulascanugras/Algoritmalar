using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayıCiftmiTekmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz:");
            string cevap = Console.ReadLine();

            int sayi = Convert.ToInt32(cevap);
            //string sonuc;
            //if (sayi % 2 == 0)

            //{

            //    sonuc = "çift";
            //    Console.WriteLine("cevabınız cift");

            //}
            //else
            //{
            //    sonuc = "tek";

            //    Console.WriteLine("cevabınız tek");
            //}
            //Console.WriteLine($"girdiginiz sayı bir {sonuc} sayıdır.");
            //Console.ReadKey();

            //////yöntem 2

            string sonuc2 = sayi % 2 == 0 ? "çift" : "Tek";
            Console.WriteLine("girdiginiz sayı bir {0} sayıdır.", sonuc2);
            Console.ReadLine();


        }
    }
}
