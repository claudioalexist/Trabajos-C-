using System;

namespace Switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Elija un valor del 1 al 5:");

                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        Console.WriteLine("uno");
                        break;

                    case 2:
                        Console.WriteLine("dos");
                        break;

                    case 3:
                        Console.WriteLine("tres");
                        break;

                    case 4:
                        Console.WriteLine("cuatro");
                        break;
                    case 5:
                        Console.WriteLine("cinco");
                        break;

                    default:
                        Console.WriteLine("Numero fuera de rango.");
                        break;
                }

                Console.ReadKey();
            }
            
        }
    }
}
