using System;

namespace condicionyy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.Write("Ingresa primer numero:");

            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresa segundo numero:");

            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingresa tercer número:");

            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 == num2 || num1 == num3) // SI num1 es mayor a num2 Y! si num1 es mayor a num3...
            {
                Console.WriteLine(num1); // Muestrame num1
            }
            {
                if (num2 > num3) // si num2 es mayor a num3...

                    Console.WriteLine(num3); // muestrame num3.

                else
                {
                    Console.WriteLine(num2); //En lo contrario muestrame num2.
                }

            }

            Console.ReadKey(); //fin del programa. 
        }
    }
}
