using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque24
{
    class Program
    {
        static void Main(string[] args)
        {
            double sb, desisr1=0.15,desisr2=0.20,
            desisr3=0.25, desafp = 0.0287, dessfs = 0.0304, 
            isr, isrn,isrn1,isrn2, sfs, afp, sn;
            Console.WriteLine("Digite Sueldo:");
            sb = double.Parse(Console.ReadLine());
            Console.WriteLine("Sueldo Bruto: {0}",sb);
            sfs = sb * dessfs;
            afp = sb * desafp;
            sn = sb - (sfs + afp);
            isr = sn * 12;
            if((isr>=416220.00) && (isr<=624329.00))
            {
                isrn = (isr - 416220.01) * (desisr1/12);
                Console.WriteLine("ISR: {0}", isrn);
            }           
            else if ((isr >= 624329.01) && (isr <= 867123.00))
            {
                isrn1 = (isr - 624329.01) * (desisr2 / 12);
                Console.WriteLine("ISR: {0}", isrn1);
                
            }
             else if (isr >= 867123.01)
            {
                isrn2 = (isr - 867123.00) * (desisr3 / 12);
                Console.WriteLine("ISR: {0}", isrn2);
            }
            else
            {
                Console.WriteLine("ISR:Exento");
            }
            Console.WriteLine("SFS: {0}", sfs);
            Console.WriteLine("AFP: {0}", afp);
            Console.WriteLine("Salario Neto: {0}", sn);        
            Console.ReadKey();
        }
    }
}
