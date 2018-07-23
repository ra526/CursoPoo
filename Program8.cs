using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque8
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resul;
            Console.WriteLine("Pida al usuario dos números enteros (que se guardarán en las variables num1 y num2).Si num2 es cero, deberá mostrar un mensaje de error, y en caso contrario mostrará en pantalla el resto de la división de num1 entre num2. ");
            Console.WriteLine("Introduzca el Primer Numero:");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo Numero:");
            num2 = Convert.ToInt16(Console.ReadLine());
            resul=num1/num2;
            if(num2!=0)
            {
                Console.WriteLine("Resultado = {0}", resul);
            }
            else
            {
                Console.WriteLine("ERROR, NO SE PUEDE DIVIDIR ENTRE 0");
            }
                Console.ReadKey();
        }
    }
}
