using System;

namespace sumaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int suma;
            int producto;
            string linea;

            Console.Write("ingrese primer numero:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("ingrese tercer numero:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("ingrese cuarto numero:");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El producto es: " + producto);

            Console.ReadKey();
        }
    }
}
