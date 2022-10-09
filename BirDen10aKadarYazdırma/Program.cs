using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirDen10aKadarYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
        yaz:
            Console.WriteLine(x);
            x = x + 1;
            if (x <= 10)
                goto yaz;
            Console.ReadKey();

        }
    }
}
