using System;

namespace EstructuraCondicional
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            int suma;
            string linea;

            Console.Write("Ingrese primer numero:");

            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese segundo numero:");

            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 >= num2) // ingresamos condicion if -- si num1 es mayor o igual a num2
            {
                suma = num1 + num2;
                Console.WriteLine("la suma es: " + suma);
            }

            else // En lo contrario muestrame num1 * num2
            {
                suma = num1 * num2;
                Console.WriteLine("El producto es: " + suma);

                suma = num1 / num2;
                Console.WriteLine("La division es: " + suma);
            }
            Console.ReadKey();


        }
    }
}
