using System;

namespace WhileContrasena
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int correcto = 0;
            string usuario;
            string pass;


            while (correcto == 0)
            {
               //Console.Clear();
                Console.WriteLine("Escriba su nombre de usuario");
                usuario = Console.ReadLine();

                Console.WriteLine("Escriba su contraseña");
                pass = Console.ReadLine();

                if (usuario == "usuario correcto" && pass == "password correcto")
                {
                    correcto = 1;
                   
                }
            }

            Console.ReadKey();
        }
        }
        
        }

