using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un texto");
            string texto = Console.ReadLine();

            Console.WriteLine($"numero de palabras: {ContarPalabras(texto)}");
            Console.WriteLine($"numero de vocales: {ContarVocales(texto)}");
            Console.WriteLine($"texto invertido: {InvertirTexto(texto)}");
        }

        static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(' ');
            return palabras.Length;
        }

        static int ContarVocales(string texto)
        {
            int contador = 0;
            foreach (char c in texto.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        static string InvertirTexto(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}

