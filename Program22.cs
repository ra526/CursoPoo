using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int grande;
            int pequeño;
            int mediano;
            Console.WriteLine("Reciba 3 números por teclado y los imprima de menor a mayor");
            Console.WriteLine("Digite el Primer valor");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el Segundo valor");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el Tercer valor");
            c = Convert.ToInt16(Console.ReadLine());
            if((a>b)&&(a>c))
            {grande = a;}
            else if((b>a)&&(b>c))
            {grande = b;}
            else
            {grande = c;}

            if ((a < b) && (a < c))
            { pequeño = a; }
            else if ((b < a) && (b < c))
            { pequeño = b; }
            else
            { pequeño = c; }

            if ((a > pequeño) && (a <grande ))
            { mediano = a; }
            else if ((b > pequeño) && (b < grande))
            { mediano = b; }
            else
            { mediano = c; }
            Console.WriteLine("{0} {1} {2}", pequeño, mediano, grande);
            Console.ReadKey();

        }
    }
}
