using System;

namespace contadorFor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Lo primero, es definir como tipo INT
            a "F u X" para realizar el contador FOR, despues de la
            sistaxis (for), abro llaves para decir que es lo que va mostrar 
            y tantas cantidad de veces, 10 u 100 veces.*/

            int f;                  
            int sum = 0; // le doy valor a sum con cero
            string linea;
            int valor;
            int promedio;

            for (f = 1; f <= 2; f++) //--->> sintaxis del contador
            {
                Console.WriteLine("ingrese un valor:");

                linea = Console.ReadLine();
                valor = int.Parse(linea);
                sum = sum + valor;
                
            }

            Console.WriteLine("La suma es: " + sum);
            promedio = sum / 2; // La barra esta saca el promedio.
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();


        }
    }
}
