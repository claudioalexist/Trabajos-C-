using System;

namespace Calculosueldo
{
    public class Cuadrado
    {
        static void Main(string[] args)
        {
            int lado;
            int superficie;
            string linea;

            Console.WriteLine("Ingrese el valor del lado del cuadrado:");

            linea = Console.ReadLine();
            lado = int.Parse(linea);

            superficie = lado * lado;

            Console.WriteLine("La superfice del cuadrado es: ");
            Console.WriteLine(superficie);

            Console.ReadKey();

        }
    }
}
