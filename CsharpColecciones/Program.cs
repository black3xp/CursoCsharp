using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Colecciones
                int[] listaDeNumeros = new int[5] {1, 2, 3, 4, 5};

                for (int i = 0; i < listaDeNumeros.Length; i++)
                {
                    Console.WriteLine(listaDeNumeros[i]);
                }
            #endregion

            #region Diccionarios
                // en los diccionarios no se pueden repetir los datos de la clave o key
                var dict = new Dictionary<string, int>();
                string valorDigitado = "";
                while (valorDigitado != ".")
                {
                    Console.WriteLine("Ingrese numero o . para terminar");
                    valorDigitado = Console.ReadLine();

                    if(valorDigitado != ".")
                    {
                        dict.Add(Guid.NewGuid().ToString(), int.Parse(valorDigitado));
                    }
                }

                foreach (var item in dict)
                {
                    Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value}");
                }
            #endregion

            #region Listas
                var lista = new List<short>();
                lista.Add(50);
                lista.Add(70);
                lista.Add(30);

                foreach (var item in lista)
                {
                    Console.WriteLine($"Lista: {item}");
                }
            #endregion
        }
    }
}
