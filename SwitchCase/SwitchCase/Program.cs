using System;

namespace SwitchCase
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un mes:");

            string valor = Console.ReadLine();

             {
                switch (valor) //
                {
                    case "enero":
                        Console.WriteLine(1);
                        break;
                    case "Febrero":
                        Console.WriteLine(2);
                        break;

                    case "Marzo":
                        Console.WriteLine(3);
                        break;
                    case "Abril":
                        Console.WriteLine(4);
                        break;

                    /*case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;*/
                    default:
                        Console.WriteLine("Se ingreso un valor fuera de rango");
                        break;
                }

            }
                        Console.ReadKey();
        }
    }
}
