using System;

namespace ReadLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string entrada;

            Console.WriteLine("Escribe tu nombre: ");
            entrada = Console.ReadLine();

            Console.WriteLine("Hola {0}, ¿Como te encuetras hoy?", entrada);

            entrada = Console.ReadLine();

            Console.WriteLine("Perfecto, que tengas un buen dia. :) ");

            Console.ReadKey();
        }   
    }
}
