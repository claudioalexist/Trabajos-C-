using System;

namespace Condicionalesanidadas
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            int prom;
            string linea;

            Console.Write("Ingrese primera nota:");

            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese segunda nota:");

            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese tercera nota:");

            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            prom = num1 + num2 + num3 / 3;
            Console.WriteLine("Promedio: " + prom);

            if (prom >= 7)
            {
                Console.WriteLine("Aprovado");
            }

            else 

                if (prom >= 4)
            { 
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }

            Console.ReadKey();
        }
    }
}
