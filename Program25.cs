using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAProgramaque25
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 1, A = 1;
            string Usuario, pass;
            Console.WriteLine("Ingresar Usuario");
            Usuario = Console.ReadLine();
            while (Usuario != "Admin" && C <= 2)
            {
                Console.WriteLine("Usuario incorreto");
                Usuario = Console.ReadLine();
                Console.Clear();
                C++;
            }
            if (Usuario != "Admin" || Usuario != "admin" || Usuario != "ADMIN")
            {
                Console.WriteLine("Has introducido el usurio 3 veces incorrectamente, contacta al administrador");
            }
            else if(Usuario == "Admin" || Usuario == "admin" || Usuario == "ADMIN")
            {
                Console.WriteLine("Digite su contraseña");
                pass = Console.ReadLine();
                
                while (pass != "Admin" && A <= 2)
                {
                    Console.WriteLine("Contraseña incorreta");
                    pass = Console.ReadLine();
                    Console.Clear();
                    A++;
                }
                if (pass != "Admin")
                {
                    Console.WriteLine("Has introducido incorrectamente 3 veces la contraseña, contacta al administrador");
                }
                else if (pass == "Admin" || pass == "admin" || pass == "ADMIN")
                {
                    Console.WriteLine("Acabas de iniciar sesión");
                }

            }

            Console.ReadKey();
        }
        }
    }

