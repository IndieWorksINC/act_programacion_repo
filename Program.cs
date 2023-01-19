using ProyectoEntornos;
using System;

namespace programa
{
    class program
    {

        //EL MAIN NO SE TOCA SI NO HACE FALTA ARREGLAR ALGO. EN ESE CASO PREGUNTAR.

        //AQUÍ EMPIEZA EL MAIN

        static void Main(string[] args)
        {
            //Esta es la zona para declarar e inicializar variables

            bool token = false;
            int selector = 0;




            //Presentación y comienzo de menú

            Console.WriteLine("Introduzca 1 para ARRAY");
            Console.WriteLine("Introduzca 2 para NUMERO");
            Console.WriteLine("Introduzca 3 para STRING");
            Console.WriteLine("Introduzca 4 para DECIMALES");
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

            token = false;

            switch (selector)
            {
                case 1:
                    Menus.menu_array();
                    break;

                case 2:
                    Menus.menu_entero();
                    break;

                case 3:
                    Menus.menu_string();
                    break;
                case 4:
                    Menus.menu_decimal();
                    break;


            }

        }
    }
}