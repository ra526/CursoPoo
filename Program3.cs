using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque3
{
    class Program
    {
        static void Main(string[] args)
        //Que solicite la edad del usuario y diga si es un niño, un adolescente, un juven, o un adulto.
        {
            int edad;
            Console.WriteLine("Que solicite la edad del usuario y diga si es un niño, un adolescente, un juven, o un adulto.");
            edad=Convert.ToInt32(Console.ReadLine());
            
            if((edad>=1)&&(edad<=10))
            {
                Console.WriteLine("Niñ@");
            }
            if((edad<=17)&&(edad>=11))
            {
                Console.WriteLine("Adolecente");
            }
            if ((edad <= 24) && (edad >= 18))
            {
                Console.WriteLine("Joven");
            }
            if ((edad <= 50) && (edad >= 25))
            {
                Console.WriteLine("Adulto");
            }
            Console.ReadKey();
        }
    }
}
