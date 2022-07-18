using System;

namespace problemaWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 1; // Contador "X" que nos sirve para contar las veltas que debe repetir el while.
            int n; // Varieble "N" para guardar el dato ingresado desde consola.
            int suma = 0;
            //int prom; 
            string linea;

            Console.Write("Ingrese un valor:"); 

            linea = Console.ReadLine();
            n = int.Parse(linea);
            suma = n + n;


            while (x <= n) // Mientras (While) que "X" sea menos o igual a "N"...
            {
                Console.Write(suma); // Muestrame en valor de "X".
                Console.Write(" - ");
                x = x + 1; // "X" ve sumandomelo cada 4.
            }

            Console.ReadKey();
        }
    }
}
