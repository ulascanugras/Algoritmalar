using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSayiDizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, toplam;
       
       
            while(a < 1000)
            { 
            Console.Write(a+" ");
            toplam = a + b;
            a = b;
            b = toplam;
    }

            Console.ReadKey();


        }
    }
}
