using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccionea una figura del 1 al 3:");
            Console.WriteLine("1. triangulo");
            Console.WriteLine("2. rectangulo");
            Console.WriteLine("3. circulo");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularAreaTriangulo();
                    break;
                case 2:
                    CalcularAreaRectangulo();
                    break;
                case 3:
                    CalcularAreaCirculo();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        static void CalcularAreaTriangulo()
        {
            Console.Write("Enumera la base del triangulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Enumera la altura del triangulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            //el operador "*" se coloca para multiplicar las dos sentencias y asi
            //sacar el resultado de las dos

            double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
            Console.WriteLine($"El area del triangulo es:{areaTriangulo}");
        }

        static void CalcularAreaRectangulo()
        {
            Console.Write("Escriba la base del rectangulo:");
            double baseRectangulo = double.Parse(Console.ReadLine());

            Console.Write("Escriba la altura del rectangulo:");
            double alturaRectangulo = double.Parse(Console.ReadLine());

            double areaRectangulo = baseRectangulo * alturaRectangulo;
            Console.WriteLine($"El area del rectangulo es:{areaRectangulo}");
        }

        static void CalcularAreaCirculo()
        {
            Console.Write("Escriba el radio del circulo:");
            double radioCirculo = double.Parse(Console.ReadLine());

            //las constantes "Math.PI y Path.Pow"
            //nos ayudan a representa la relacion entre la longitud de la circunferencia 
            //de un circulo y su diametro

            double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
            Console.WriteLine($"El area del circulo es:{areaCirculo}");
        }
    }
}

