using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Reciba 3 números y confirme si el tercero resulta de multiplicar los dos primeros");
            Console.WriteLine("Digite el primer numero:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero:");
            c = Convert.ToInt16(Console.ReadLine());
            if(a*b==c)
            {
                Console.WriteLine("El tercer numero es la multiplicacion de los dos Primeros");
            }
            else
            {
                Console.WriteLine("El tercer numero NO es la multiplicacion de los dos Primeros");
            }
            Console.ReadKey();

        }
    }
}
