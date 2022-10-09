using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtma
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Console.WriteLine("Bu programda 6 gelinceye kadar zar atarsınız.");

        zarAt:

            Console.WriteLine("Zar atmak için Bir tuşa basınız...");
            Console.ReadKey(true);
            int zar = rnd.Next(1, 7); // 1-6 aralığında sayı üretir.
            Console.WriteLine("gelen zar:" + " " + zar);
            if (zar != 6)
                goto zarAt;
            Console.WriteLine("Zar 6 oldu programı kapatabilirsiniz");

            Console.WriteLine("Programdan çıkmak için bir tuşa basınız");
            Console.ReadKey();

        }
    }
}
