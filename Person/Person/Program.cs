﻿using System;
namespace enfocat.tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("\t\tBienvenido!!!\n\n ¿Estas listo para conocer a " +
                              "tu nueva mascota?\n \tYa haz pensado en su Nombre?\n");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Ingresalo aqui:");

            Person p = new Person(); 
            p.nombre = Console.ReadLine();

            p.Registro(); // llama a la funciones desde la clase person
            p.Comer();
            p.Comer();
            p.Correr();
            p.Duerme();
            p.Discute();
            p.Canta();
            p.Baila();
            p.Registro();

            p.MuestrameEstadoAnimo();

            Console.ReadKey();

        }
    }
}
