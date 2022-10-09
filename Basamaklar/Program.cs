using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basamaklar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            //while (sayi>0)
            //{
            //    toplam = toplam + sayi % 10;
            //    sayi = sayi / 10;

            //}
            gel:
            if(sayi>0)
            {
                toplam = toplam + sayi % 10;
                sayi = sayi / 10;
                goto gel;

            }
            Console.WriteLine("Giridğiniz sayıı basamaklarının sayı değerleri toplamı ="+ " "+ toplam);



            Console.ReadKey();
        }

       
    }
}
