using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, tabla;
            Console.WriteLine("Que reciba un numero y muestre su tabla de multiplicar");
            Console.Write("Introduzca la tabla: ");
            tabla = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 12; i++)
            {
                Console.WriteLine(" {0} x {1} = {2} ", tabla, i, tabla * i);
            }
            Console.ReadKey();
        }

    }
}
