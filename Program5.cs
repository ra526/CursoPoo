using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque5
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, var3, var4, var5, resultado;
            Console.WriteLine("Genere el promedio de los valores almacenados en 5 variables enteras");
            Console.WriteLine("Ingrese los 5 valores seguidos de la tecla ENTER");
            var1 = Convert.ToInt16(Console.ReadLine());
            var2 = Convert.ToInt16(Console.ReadLine());
            var3 = Convert.ToInt16(Console.ReadLine());
            var4 = Convert.ToInt16(Console.ReadLine());
            var5 = Convert.ToInt16(Console.ReadLine());
            resultado = var1 + var2 + var3 + var4 + var5;
            resultado = resultado / 5;
            Console.WriteLine("Promedio = {0}", resultado);
            Console.ReadKey();
        }
    }
}
