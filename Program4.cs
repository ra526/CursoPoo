using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque4
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int x = 23, y = 24, z = 25, suma;
            Console.WriteLine("Guarde en la variable x (entera) el número 23, en la variable y (entera) el número 24, en la variable z (entera) el número 25 y muestre en pantalla la suma de los valores de las tres variables. ");
            suma = x + y + z;
            Console.WriteLine("Resultado = {0}", suma);
            Console.ReadKey();
        }
    }
}
