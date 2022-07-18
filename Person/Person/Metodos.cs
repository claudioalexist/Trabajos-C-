using System;


namespace enfocat.tests
{
    public class Person
    {
        public string nombre;
        public int edad;
        public int estadoAnimo = 5;
        private bool alimentar;
        public int contadorHambre = 5;
        private bool ejercio;
        public int contadorSalud = 5;
        private bool sueno;
        private bool enojado;
        private bool alegre;
        private bool feliz;

        //---------------------------Constructor-------------------------------

        public Person(string nombre)
        {
            this.nombre = nombre;
            this.alimentar = false;
            this.alegre = false;
            this.ejercio = false;
            this.enojado = false;
            this.sueno = false;
            this.feliz = false;

        }
        //-------------------GET(lectura) y SET(escritura)---------------------
        public Person()
        {
        }

        public bool Alimentar
        {
            get
            {
                return this.alimentar;
            }
            set
            {
                this.alimentar = value;
            }
        }
        public bool Alegre
        {
            get
            {
                return this.alegre;
            }
            set
            {
                this.alegre = value;
            }
        }
        public bool Ejercicio
        {
            get
            {
                return this.ejercio;
            }
            set
            {
                this.ejercio = value;
            }
        }
        public bool Enojado
        {
            get
            {
                return this.enojado;
            }
            set
            {
                this.enojado = value;
            }
        }
        public bool Sueno
        {
            get
            {
                return this.sueno;
            }
            set
            {
                this.sueno = value;
            }
        }

        public bool Feliz
        {
            get
            {
                return this.feliz;
            }
            set
            {
                this.feliz = value;
            }
        }

        //--------------------Funciones y Encapsulamiento---------------------------

        public void Comer()
        {
            Random comidaAlAzar = new Random();
            int comidas = comidaAlAzar.Next(1, 4);


            switch (comidas) // Comida al azar (Random) con 3 opciones con Switch case. 
            {
                case 1:

                    Console.WriteLine("Quiero comer Sushi y Tempuras");
                    break;

                case 2:
                    Console.WriteLine("Quiero Tomar Bebida");
                    break;

                case 3:
                    Console.WriteLine("Quiero comer Patatas fritas!");
                    break;
            }

            Console.WriteLine("--->(Presione 1 para alimentar o 0 para Omitir)");
            string comer = Console.ReadLine();
            int cHambre = int.Parse(comer);

            if (cHambre == 1)
            {
                this.alimentar = false;
                Console.WriteLine("Mmmm que bueno estaba! Gracias! :)\n");
                Registro();

            } else if (cHambre == 0) // Si le da a cero, su salud, animo y alimentación empeorarán y se restará 1
            {
                Console.WriteLine("\tEstaré desnutrido :,(\n");

                Console.WriteLine("| Mis defensas decaerán! |");
                Console.WriteLine(" ---------------------- ");
                contadorSalud--;
                contadorHambre--;
                estadoAnimo--;
                MuestrameEstadoAnimo();
                Registro();
            }

        }

        public void Correr()
        {
            Console.WriteLine("Quiero correr!! Necesito hacer ejercicios.");
            Console.WriteLine("--->(Presione 1 para correr o 0 para engordar)");

            string correr = Console.ReadLine();
            int cSalud = int.Parse(correr);

            if (cSalud == 1)
            {
                Console.WriteLine("\tUfff!! Ya estoy cansado!\n");
                Console.WriteLine("| Tu salud a aumentado! |");
                Console.WriteLine(" ----------------------");
                contadorSalud++;
                MuestrameEstadoAnimo();
                Registro();
            }
            else if (cSalud <= 0)
            {
                Console.WriteLine("ohh! q mal!\n");
                Console.WriteLine("| Tu salud empeorará |");
                Console.WriteLine(" --------------------");
                contadorSalud--;
                MuestrameEstadoAnimo();
                Registro();
            }
        }

        public void Duerme()
        {
            Console.WriteLine("Tengo mucho sueeño, quiero dormir -.- ZZZzzZZz");
            Console.WriteLine("--->(Presione 1 para Dormir o 0 para Omitir)");
            string dormir = Console.ReadLine();
            int su = int.Parse(dormir);

            if (su == 1)
            {
                Console.WriteLine("Ya he dormido lo suficiente!\n");
                Console.WriteLine("| Tu estado de animo aumentado! Vamos!!!!! |");
                Console.WriteLine(" -----------------------------------------");
                estadoAnimo++;
                MuestrameEstadoAnimo();
                Registro();
            }
            else if (su <= 0)
            {
                Console.WriteLine("me siento cansado...\n ");
                Console.WriteLine("| Tu estado de animo decaerá |");
                Console.WriteLine(" ---------------------------");
                estadoAnimo--;
                MuestrameEstadoAnimo();
                Registro();
            } 
        }

        public void Discute()
        {   
            Console.WriteLine("HAAA!!! estoy con toda la wea!!!");
            Console.WriteLine("--->(Presione 1 para calmarlo o 0 para Enojar mas)");
            string discutir = Console.ReadLine();
            int eno = int.Parse(discutir);

            if (eno == 1)
            {
                Console.WriteLine("Ya estoy mejor de animo. Gracias por comprenderme :)\n");
                estadoAnimo++;
                MuestrameEstadoAnimo();
                Registro();
            }
            else if (eno <= 0)
            {
                Console.WriteLine("Tu estado de animo decaerá 2 veces mas!\n");
                Console.Beep();
                Console.Beep();
                Console.Beep();
                estadoAnimo--;
                estadoAnimo--;
                MuestrameEstadoAnimo();
                Registro();
            }
        }

        public void Canta()
        {
            Console.WriteLine("Tengo ganas de cantar!");
            Console.WriteLine("(Presione 1 para cantar o 0 para Omitir)");
            string cantar = Console.ReadLine();
            int ale = int.Parse(cantar);

            if (ale == 1)
            {
                Console.WriteLine("Me ha gustado, cantemos otraves? :)\n");
                Console.WriteLine("--->(presiona 1 para cantar o 0 para Omitir)");
                cantar = Console.ReadLine();
                ale = int.Parse(cantar);
                if (ale == 1)
                {

                    Console.WriteLine("Ahora estoy mucho mejor :D");
                    Console.WriteLine("Tu estado de animo a aumentado ;)");
                    estadoAnimo++;
                    MuestrameEstadoAnimo();
                    Registro();
                }

            }
            else if (ale <= 0)
            {
                Console.WriteLine("Ups! :,(\n");
                MuestrameEstadoAnimo();
            }
        }


        public void Baila()
        {
            Console.WriteLine("Estoy muy feliz! Tengo ganas de Bailar");
            Console.WriteLine("(Presiona 1 para Bailar o 0 para Omitir)");

            string bailar = Console.ReadLine();
            int fe = int.Parse(bailar);

            if (fe == 1)
            {
                Console.WriteLine("Ya he bailado mucho!\n");
                MuestrameEstadoAnimo();
            }
            else if (fe <= 0)
            {
                Console.WriteLine("Ups :,( solo queria bailar");
                Console.WriteLine("Tu estado de animo a decaido mucho mas.\n");
                estadoAnimo--;
                MuestrameEstadoAnimo();
            }
        }
        public void Registro()
        {
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("|  Nombre: " + this.nombre);
            Console.WriteLine("|  Salud: " + contadorSalud);
            Console.WriteLine("|  Animo: " + estadoAnimo);
            Console.WriteLine("|  Alimentacion: " + contadorHambre);
            Console.WriteLine(" ------------------------------");
        }

        public void MuestrameEstadoAnimo()
        {

            if (estadoAnimo == 0)
            {
                Console.WriteLine("| Me has matado!...|");
                Console.WriteLine(" ------------------");

            }
            return;
           }

    }
       
}

