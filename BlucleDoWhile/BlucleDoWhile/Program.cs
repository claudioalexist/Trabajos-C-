using System;

namespace BlucleDoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int valor;
            string linea;
            do //blucle Do While: nos hace ingresar un valor. una vez ingresado el valor, vuelve a preguntar.
            {
                Console.Write("Ingrese un valor entre 0 al 999:"); // Muestra que ingresemos un valor.

                linea = Console.ReadLine(); // Hacemos la transformacion de String a int. 
                valor = int.Parse(linea);

                if (valor >= 100) // Le damos una condicion: SI valor es Mayor o igual a 100...
                {
                    Console.WriteLine("El valor ingresado tiene 3 digitos."); // Dime si el valor es de 3 digitos.
                }
                else // En lo contrario...
                {
                    if (valor >= 10) // siiii el valor es mayor o igual a 10...

                    {
                        Console.WriteLine("El valor ingresado tiene 2 digitos.");// muestrame que tiene 2 digitos.
                    }
                    else
                    {
                        Console.WriteLine("Tiene un 1 dígito."); // En lo contrario dime que tiene 1 digito.
                    }

                }

            } while (valor != 0); // Fin. 
        } 
    }
}

