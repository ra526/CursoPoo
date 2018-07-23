using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;
            Console.WriteLine("Pida al usuario dos números enteros (que se guardarán en las variables n1 y n2) y muestre su producto en pantalla. ");
            Console.WriteLine("Introduzca el primer valor:");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor:");
            n2 = Convert.ToInt16(Console.ReadLine());
            r = n1 * n2;
            Console.WriteLine("Resultado = {0}", r);
            Console.ReadKey();
        }
    }
}
