using System;

namespace programa
{
    class program
    {

        //Zona de definción de funciones


        int abuelo = 0;



        //AQUÍ ESTÁN LOS MENÚS

        
        //Menú entero
        
        public void menu_entero()
        {
            program objeto = new program(); //NO TOCAR O LES REVIENTO CON UNA PALA
            bool token = false;

            int selector = 0;

            int numero_entero = 0;


            
            Console.WriteLine("Has seleccionado las operaciones con números enteros");
            Console.WriteLine("");
            Console.WriteLine("Introduzca un número entero: ");
            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out numero_entero)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                
                else
                {
                    token = true;
                }
            }
            while (!token);

            Console.WriteLine("Introduzca 1 para Calcular si es primo o no");
            Console.WriteLine("Introduzca 2 para Calcular el factorial");
            Console.WriteLine("Introduzca 3 para devolver el número en minutos y horas");
            Console.WriteLine("Introduzca 4 para devolver los primeros 15 números de la serie de Pell");
            Console.WriteLine("Introduzca 5 para devolver si es un número de Armstrong o no");
            Console.WriteLine("Introduzca 6 para comprobar si tiene todos sus dígitos diferentes");
            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");

            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 4 || selector < 1)
                {
                    Console.WriteLine("Valor entero fuera de reango. Vuelva a intentarlo: ");
                }
                else
                {
                    token = true;
                }
            }
            while (!token);
            switch (selector)
            {
                case 1:
                    objeto.menu_array();
                    break;

                case 2:
                    objeto.menu_entero();
                    break;

                case 3:
                    objeto.menu_string();
                    break;
                case 4:
                    objeto.menu_decimal();
                    break;

            }




        }

        //Menú decimal
        public void menu_decimal()
        {
           
            
            Console.WriteLine("Has seleccionado las operaciones con decimales");

        }

        //Menú array
        public void menu_array()
        {
            Console.WriteLine("Has seleccionado las operaciones con arrays");

        }

        //Menú strings
        public void menu_string()
        {
            Console.WriteLine("Has seleccionado las operaciones con strings");

        }


        
        
        
        
        
        
        
        
        
        
        
        //AQUÍ EMPIEZA EL MAIN

        static void Main(string[] args)
        {
            //Esta es la zona para declarar e inicializar variables

            bool token = false;
            program pr = new program();
            int selector = 0;




            //Presentación y comienzo de menú

            Console.WriteLine("Introduzca 1 para ARRAY");
            Console.WriteLine("Introduzca 2 para NUMERO");
            Console.WriteLine("Introduzca 3 para STRING");
            Console.WriteLine("Introduzca 4 para DECIMALES");
            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");

            do
            {
                if(!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 4 || selector < 1)
                {
                    Console.WriteLine("Valor entero fuera de reango. Vuelva a intentarlo: ");
                }
                else
                {
                    token = true;
                }
            }
            while (!token);

            token = false;

            switch (selector)
            {
                case 1:
                    pr.menu_array ();
                    break;

                case 2:
                    pr.menu_entero();
                    break;

                case 3:
                    pr.menu_string();
                    break;
                case 4:
                    pr.menu_decimal();
                    break;


            }

        }
    }
}
