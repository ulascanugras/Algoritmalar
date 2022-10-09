using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program sizin 1-100 arasında tuttuğunuz bi sayıyı en az tahmin ile bulmaya çalışır.\nTahmini kücükse y büyükse a  doğruysa d tuşlayınız");
            Console.WriteLine("Bir sayı tuttuysanız ve hazırsa bir tuşa basınız");
            Console.ReadKey();

            int min = 1, max = 100, tahminAdet = 0;
        tahminEt:

            int tahmin = (min + max) / 2;
            tahminAdet = tahminAdet + 1;
            Console.WriteLine($"Tuttuğun sayı {tahmin} mi? (a)şağı/ (y)ukarı/ (d)oğru");
            string cevap = Console.ReadLine();
            if (cevap == "a")
            {
                max = tahmin - 1;
                goto tahminEt;

            }
            if (cevap == "y")
            {
                min = tahmin + 1;
                goto tahminEt;
            }
            Console.WriteLine("Oleyy!!  {0} tahminde Bildim :)",tahminAdet);





            Console.ReadKey();

        }
    }
}
