using System;

namespace adivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // numero de oportunidades para desubrir el numero
            const int oportunidades = 10;
            int num, entrada;
            byte i, adivinado;
            string linea;

            // obtenemos un numero aleatorio entre 1 y 100
            Random ran = new Random();
            num = Convert.ToInt32(ran.Next(10)) + 1;

            i = 1; adivinado = 0;
            do
            {
                Console.Write("Piensa un numero entre 1 y 10:");
                linea = Console.ReadLine();
                entrada = int.Parse(linea);

                if (entrada == num)
                {
                    Console.WriteLine("Has adivinado el numero");
                    adivinado = 1;
                }
                else
                {
                    if (entrada > num)
                    {
                        Console.WriteLine("Estas alto");
                    }
                    else
                    {
                        Console.WriteLine("Estas bajo");
                    }
                }
                i++;
            } while ((i <= oportunidades) && (adivinado == 0));
            if (adivinado == 0)
            {
                Console.Write("Has agotado los intentos... El numero fue: " + num);
            }

            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}

