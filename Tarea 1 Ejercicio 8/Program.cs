using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) Diseñar un algoritmo y construir un programa que permita ingresar una cadena de caracteres por teclado y la imprima al revés.

            Console.WriteLine("Ingrese la palabra a reversar: ");

            string frase = Console.ReadLine();
            List<char> letras = new List<char>();
            foreach (char letra in frase)
            {
                //Console.WriteLine(letra);
                letras.Add(letra);
            }
            letras.Reverse();
            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();
        }
    }
}
