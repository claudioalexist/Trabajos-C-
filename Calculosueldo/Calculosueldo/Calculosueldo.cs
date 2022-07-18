using System;

namespace Calculosueldo
{
    public class Sueldo
    {
        public void Main(string[] args)
        {
            int horasTrabajadas; // declaro variable
            float costoHora;    
            float sueldo;
            string linea;
           
           Console.WriteLine("Ingrese horas trabajadas:"); // Muestro por consola.

            linea = Console.ReadLine(); // ingresa dato en consola y queda guadado Linea que es de tipo String.
            horasTrabajadas = int.Parse(linea); // parseo Horas trabajadas (int) a linea que es de tipo string.

            Console.WriteLine("Ingrese el pago por hora:"); //Muestra por consola.


            linea = Console.ReadLine(); // el mismo paso: ingresa dato en consola y lo guarda en linea que es de tipo estring.
            costoHora = float.Parse(linea); // Luego parseo costoHora(int) con Linea que es de tipo string.

            Console.WriteLine("Sueldo:"); // Muestra por consola.

            sueldo = horasTrabajadas * costoHora; // Resultado sueldo= horastrab.. x costo hora 

            Console.WriteLine(sueldo); // muestrame sueldo.
            Console.ReadKey(); // para que no se cierre la consola.
        }
    }
}
