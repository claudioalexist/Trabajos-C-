using System;
namespace Calculosueldo
{
    public class Suma
    {
        public Suma()
        {
            int num1;
            int num2;
            int suma;
            int producto;
            string linea;
           

            Console.WriteLine("Ingrese un Numero:");

            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el segundo Numero:");

            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;

            Console.Write("La suma de los dos valores es:");
            Console.WriteLine(suma);
            Console.Write("El producto de los dos valores es:");
            Console.WriteLine(producto);
            Console.ReadKey();
        }
    }
}
