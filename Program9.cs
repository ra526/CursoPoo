using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAprogramaque9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do{
                Console.WriteLine("Usuario, Ingrese un Numero, le voy a decir si es Par o Impar:");
                numero = Convert.ToInt16(Console.ReadLine());
                if ((numero == 0))
                {
                    Console.WriteLine("El valor introducido es 0, fin del programa");
                }
                if ((numero % 2 == 0))
                {
                    Console.WriteLine(" El Numero es Par");
                }
                else
                {
                    Console.WriteLine("El Numero es Impar");
                }
                Console.ReadLine();
               }
                while (numero != 0);
                Console.ReadKey();
         }
    }
}
