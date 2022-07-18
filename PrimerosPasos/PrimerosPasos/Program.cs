using System;

namespace PrimerosPasos
{
   public class PrimeraClase
    {
        public static void Main(string[] args)
        {
            int edad;
            string linea;

            Console.Write("Introduce tu edad por favor:");

            linea = Console.ReadLine();
            edad = int.Parse(linea);

            if (edad < 18)
            {
                Console.WriteLine("Eres un adolecente");
            }
            else if (edad < 40)
            {
                Console.WriteLine("Eres Joven");
            }
            else if (edad < 65)
            {
                Console.WriteLine("Eres maduro");
            }
            else
            {
                Console.WriteLine("Cuidate");
            }

            Console.ReadKey();
        } 
    } 
}
