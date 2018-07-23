using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque10
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int A = 0, B = 0, C = 0, Z = 0;
                do
                {
                    A = A + 1;
                    Console.Write("intraduscar un valor: ");
                    B = int.Parse(Console.ReadLine());
                    C = Z + B;
                    Z = C;
                    
                }
                while (B != 0);
                {
                    A = A - 1;
                    Console.Clear();
                    Console.WriteLine("has introducido {0} cantidad de numenros y suman {1}", A, Z);  
                }
                Console.ReadKey();

            }
        }
    }
}
    

