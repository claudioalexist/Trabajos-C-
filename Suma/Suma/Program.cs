using System;

namespace Suma
{
    public class Suma
    {
        static void Main(string[] args)
        {
            int num1; //declara el primero numero a sumar
            int num2; //declara el segundo numero a sumar
            int suma; //declara la suma de num1 y num2
            string entrada;

            //Messaje para el Usuario
            Console.WriteLine("Ingresa un numero");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            //Messaje para el Usuario
            Console.WriteLine("Escriba el segundo numero");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);

            //Suma los numeros

            suma = num1 + num2;

            //muestro la suma

            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, suma);
        }
    }
}
