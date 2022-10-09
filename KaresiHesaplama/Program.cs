using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaresiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz:");
            

            int sayi = Convert.ToInt32(Console.ReadLine());
          
            int karesi = sayi * sayi;
            Console.WriteLine("karesi:"+" "+karesi);
            Console.ReadKey();
        }
    }
}
