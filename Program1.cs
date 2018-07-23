using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque1
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c, r;
            l = 50;
            c = 51;
            r = l * c;
            Console.WriteLine("1. Guarde en una variable entera el numero 50, y en otra variable entera el numero 51. y muestre el reslutado de multiplicar ambos numeros.");
            Console.WriteLine("{0}*{1}={2}", l, c, r);
            Console.ReadKey();
        }
    }
}
