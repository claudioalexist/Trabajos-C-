using System;

namespace MuestranumeroMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            int numeroA = 3;
            
            string lineaA;

            lineaA = Console.ReadLine();
            numeroA = int.Parse(lineaA);

            Console.WriteLine("ingrese un numero");

            int numeroB;
            string lineaB;

            lineaB = Console.ReadLine();
            numeroB = int.Parse(lineaB);

            Console.WriteLine("ingrese un numero");

            int numeroC;
            string lineaC;

            lineaC = Console.ReadLine();
            numeroC = int.Parse(lineaC);

            if (numeroA > numeroB && numeroA > numeroC)

            {
                Console.WriteLine("El numero mayor es: " + numeroA);
            }
            else if (numeroB > numeroA && numeroB > numeroC)
            {
                Console.WriteLine("El numero Mayor ingresado es: " + numeroB);
            } else
            {
                Console.WriteLine("El numero Mayor es: " + numeroC);
            }

            if (numeroA < numeroB && numeroA < numeroC)

            {
                Console.WriteLine("El numero menor es: " + numeroA);
            }
            else if (numeroB < numeroA && numeroB < numeroC)
            {
                Console.WriteLine("El numero menor ingresado es: " + numeroB);
            }
            else
            {
                Console.WriteLine("El numero menor es: " + numeroC);
            }

            Console.ReadKey();

        }
    }
}
