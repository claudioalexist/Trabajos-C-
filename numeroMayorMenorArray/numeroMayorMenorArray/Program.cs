using System;
using System.Linq;

namespace numeroMayorMenorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            int linea, max = numeros[0], min = numeros[0];

            int limitesuperior = 5;
            
            
                for (int i = 0; i < numeros.Length; i++) // IMPORTANTE: Nombrar atributo.LENGHT. Esto nos indica la cantidad de caracteres que tiene la cadena.
                {
                    Console.WriteLine("Ingrese numero: ");

                    linea = int.Parse(Console.ReadLine());
                    numeros[i] = linea;

                    if (max >= limitesuperior)
                    {
                    Console.WriteLine("fuera de rango ");
                    return;
                    }
                }

            Console.WriteLine("El numero mayor ingresado es: " + numeros.Max());
            Console.WriteLine("El numero menor ingresado es: " + numeros.Min());
            Console.ReadKey();
        }
    }
}
