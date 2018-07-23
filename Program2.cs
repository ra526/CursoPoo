using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque2
{
    class Program
    {
        static void Main(string[] args)
       // Que reciba un numero por teclado y diga si el numero es par o impar
        {
            int numero;
            numero=Convert.ToInt32(Console.ReadLine());
            if((numero %2)==0)
            {
                Console.WriteLine("Par {0}", numero);
            }
            if((numero %2)!=0)
            {
                Console.WriteLine("Impar{0}", numero);
            }
        }
    }
}
