using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        //Aqui se agregan las formulas de conversion para las temperaturas usando "Static Double"
        //para definir las variables

        //La palabra reservada "return" nos ayuda a devolver el valor del codigo que se esta colocando
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escoje cualquier opcion:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            int opcion = int.Parse(Console.ReadLine());

            double temperatura;

            switch (opcion)
            {
                case 1:
                    Console.Write("Coloca la temperatura en grados Celsius:");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La temperatura en Fahrenheit es: {CelsiusToFahrenheit(temperatura)}");
                    break;

                case 2:
                    Console.Write("Coloca la temperatura en grados Fahrenheit:");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La temperatura en Celsius es: {FahrenheitToCelsius(temperatura)}");
                    break;

                case 3:
                    Console.Write("Coloca la temperatura en grados Celsius:");
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La temperatura en Kelvin es: {CelsiusToKelvin(temperatura)}");
                    break;

                default:
                    Console.WriteLine("Opcion no aceptable");
                    break;
            }
        }
    }
}
