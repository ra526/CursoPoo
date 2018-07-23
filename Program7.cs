using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque7
{
    class Program
    {
        static void Main(string[] args)
        {
            float dato1, dato2, resul;
            Console.WriteLine("Pida al usuario dos números reales (que se guardarán en las variables dato1 y dato2).Si dato2 es cero, deberá mostrar un mensaje de error, y en caso contrario mostrará en pantalla el resultado de dividir dato1 entre dato2. ");
            Console.WriteLine("Introduzca el Primer Dato:");
            dato1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduzca el Segundo Dato:");
            dato2 = Convert.ToInt16(Console.ReadLine());
            resul=dato1/dato2;
            if(dato2==0)
            {
                Console.WriteLine("No Se Puede divir entre 0");
            }
            else
            {
                Console.WriteLine("El Resultado = {0}", resul);
            }
            
                Console.ReadKey();
        }
    }
}
