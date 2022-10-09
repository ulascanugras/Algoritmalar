using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkiyeninBaskenti
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Türkiyenin başkenti neresidir?");
            soru: 
            Console.Write("Cevap:");
            string cevap = Console.ReadLine();

            if (cevap.ToLower() != "ankara")
            {
                Console.WriteLine("Üzgünüm: ( Yanlış Cevap!");
                goto soru;

            }
         
                Console.WriteLine("tebrikler:) Doğru Cevap!");
           
            Console.ReadKey();
        }
    }
}