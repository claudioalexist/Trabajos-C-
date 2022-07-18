using System;

namespace ventaArticulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio; // declaramos la Variable precio del articulos.
            int cantidad; // Declaramos la variable cantidad de los articulos. 
            int suma; // Declaramos la suma de estos (precio y cantidad)
            string linea; // Declaramos linea de tipo String. para guardar los datos ingresados en consola. 

            Console.Write("Ingrese precio del articulo:"); // muestra por pantalla.

            linea = Console.ReadLine(); // Dato ingreso por consola queda gaurdado en linea.
            precio = int.Parse(linea); // Luego parseamos precio con linea. 

            Console.Write("Ingrese cantidad:"); // muestra por pantalla.
            linea = Console.ReadLine(); // Dato ingreso por consola queda gaurdado en linea.
            cantidad = int.Parse(linea); // Luego parseamos cantidad con linea. 

            suma = cantidad * precio; // sumamos estos dos valores. 

            Console.WriteLine("Favor abonar monto indicado: " + suma); // muestra por pantalla. 
            Console.ReadKey();
        }
    }
}
