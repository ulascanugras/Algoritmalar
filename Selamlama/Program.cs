using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selamlama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adınız : ");// output tanımladık.

            string ad;// degisken tanımlama (variable declaration)
            ad = Console.ReadLine(); // değişkene ilk değerini atama (variable initialization)
           
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Selam" +" " + ad+"!");

            Console.ReadKey();

        }
    }
}
