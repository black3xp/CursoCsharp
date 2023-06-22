using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite su edad");
            var edadUsuarioString = Console.ReadLine();

            string mensaje = int.TryParse(edadUsuarioString, out int edadUsuario) ? "Calculando edad" : "Ingreso un caracter incorrecto";

            Console.WriteLine(mensaje);
            if (mensaje == "Ingreso un caracter incorrecto") return;

            if ( edadUsuario >= 18)
            {
                Console.WriteLine($"El usuario es mayor de edad");
            }
            else
            {
                Console.WriteLine($"El usuario es menor de edad");
            }
        }
    }
}
