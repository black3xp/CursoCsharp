using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // no se puede re-asignar
            const string nombre = "Vladimir";
            // no puede ser const porque es variable
            var apellido = "Nunez";
            apellido = "Nunez Calderon";
            short edad = 28;
            Int16 altura = 178;
            float alturaEnMetros = 1.78f;

            Console.WriteLine($"Hola {nombre} {apellido}");
            Console.WriteLine($"Mi nombre tiene {nombre.Length} letras");
            Console.WriteLine($"Mi apellido tiene {apellido.Trim().Replace(" ", "").Length} letras");
            Console.WriteLine($"Mi edad es {edad} años");
            Console.WriteLine($"Mi altura es de {altura} cm");
            Console.WriteLine($"Mi altura en metros es {alturaEnMetros}");

            DateTime fechaNacimiento = new DateTime(1994,4,1);
            var fechaActual = DateTime.Now;
            Console.WriteLine($"Mi fecha de nacimiento es {fechaNacimiento.Date.ToShortDateString()}");
            Console.WriteLine($"La fecha actual es {fechaActual.Date.ToShortDateString()}");
        }
    }
}
