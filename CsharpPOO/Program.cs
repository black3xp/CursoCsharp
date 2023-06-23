using CsharpPOO.Models;
using CsharpPOO.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new AppManager();
            Console.WriteLine($"Bienvenido a {app.AppTitle}");

            foreach (var item in app.SocialNetworks)
            {
                Console.WriteLine($"{item.Name}");
            }

            foreach (var item in app.SocialNetworkWithGroups)
            {
                Console.WriteLine($"{item.Name}");
            }

            return;

            Console.WriteLine($"Ingrese su nombre");
            string name = Console.ReadLine();

            Console.WriteLine($"Ingrese su email");
            string email = Console.ReadLine();

            Console.WriteLine("Ingrese la edad");
            short age = short.Parse(Console.ReadLine());

            var user = new User();
            user.Email = email;
            user.Name = name;
            user.Age = age;

            bool emailValid = HelperValidator.IsValidEmail(user.Email);

            if(!emailValid)
            {
                Console.WriteLine($"Correo no valido");
                return;
            }

            if (user.IsValid())
            {
                Console.WriteLine($"Su nombre es {user.Name} y su correo es {user.Email}, su edad es {user.Age}");
                Console.WriteLine($"El usuario esta activo: {user.IsActive} y su fecha de creacion es {user.DateCreated.ToString("MM/dd/yyyy")}");
            }
            else
            {
                Console.WriteLine("Hay algunos errores");
            }
        }
    }
}
