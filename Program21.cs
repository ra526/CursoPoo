﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)	Reciba un numero de mes y muestre en pantalla el nombre del mes. 
            int i;
            Console.WriteLine("Digite un numero del 1 al 12 y le mostrare a que mes pertenece:");
            
            do{
                i = Convert.ToInt16(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("Enero"); break;
                case 2: Console.WriteLine("Febrero"); break;
                case 3: Console.WriteLine("Marzo"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Mayo"); break;
                case 6: Console.WriteLine("Junio"); break;
                case 7: Console.WriteLine("Julio"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Septiembre"); break;
                case 10: Console.WriteLine("Octubre"); break;
                case 11: Console.WriteLine("Noviembre"); break;
                case 12:Console.WriteLine("Diciembre"); break;
                default: Console.WriteLine("Fin del programa"); break;
            }
                }while(i!=0);
           
            Console.ReadKey();
        }
    }
}
