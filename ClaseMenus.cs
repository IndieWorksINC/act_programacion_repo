using programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEntornos
{
    class Menus
    {
        //Menú entero
        public static void menu_entero()
        {
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

            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");
            Console.WriteLine("Introduzca 1 para Calcular si es primo o no");
            Console.WriteLine("Introduzca 2 para Calcular el factorial");
            Console.WriteLine("Introduzca 3 para devolver el número en minutos y horas");
            Console.WriteLine("Introduzca 4 para devolver los primeros 15 números de la serie de Pell");
            Console.WriteLine("Introduzca 5 para devolver si es un número de Armstrong o no");
            Console.WriteLine("Introduzca 6 para comprobar si tiene todos sus dígitos diferentes");

            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 6 || selector < 1)
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
                    FuncionesEntero.EsPrimo(numero_entero);
                    break;

                case 2:
                    FuncionesEntero.CalcFactorial(numero_entero);
                    break;

                case 3:
                    FuncionesEntero.HorasMinutos(numero_entero);
                    break;
                case 4:
                    FuncionesEntero.SeriePell(numero_entero);
                    break;
                case 5:
                    FuncionesEntero.NumeroArmstrong(numero_entero);
                    break;
                case 6:
                    FuncionesEntero.DigitoDiferente(numero_entero);
                    break;

            }




        }

        //Menú decimal
        public static void menu_decimal()
        {


            bool token = false;

            int selector = 0;

            decimal numero_decimal = 0;



            Console.WriteLine("Has seleccionado las operaciones con decimales");
            Console.WriteLine("");
            Console.WriteLine("Introduzca un número decimal: ");
            do
            {
                if (!(Decimal.TryParse(Console.ReadLine(), out numero_decimal)))
                {
                    Console.WriteLine("Valor introducido no válido, Vuelva a intentarlo: ");
                }

                else
                {
                    token = true;
                }
            }
            while (!token);

            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");
            Console.WriteLine("Introduzca 1 para Redondear el número al alza");
            Console.WriteLine("Introduzca 2 para eliminar los decimales");
            Console.WriteLine("Introduzca 3 introducir valores para una ecuación de segundo grado");//te doy un parametro, comprueba los otros

            token = false;

            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 3 || selector < 1)
                {
                    Console.WriteLine("Valor entero fuera de rango. Vuelva a intentarlo: ");
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
                    FuncionesDecimal.Redondear(numero_decimal);
                    break;
                case 2:
                    FuncionesDecimal.Truncar(numero_decimal);
                    break;
                case 3:
                    FuncionesDecimal.EcuacionSegundGrado(numero_decimal);
                    break;
                

            }

        }

        //Menú array
        public static void menu_array()
        {
            bool token = false;

            int selector = 0;

            int index = 0;

            decimal numero_array = 0;

            decimal[] array; 



            Console.WriteLine("Has seleccionado las operaciones con arrays");
            Console.WriteLine("");
            Console.WriteLine("Introduzca el número de contenido que desea en el Array: ");
            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out index)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }

                else
                {
                    token = true;
                }
            }

            while (!token);

            token = false;

            array = new decimal[index];

            Console.WriteLine("Introduce todos los valores de su array");

            for (int i = 0; i < array.Length; i++)
            {
                while(!Decimal.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Valor incorrecto");
                    Console.WriteLine("Vuelva a intentarlo: ");
                }
            }

            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");
            Console.WriteLine("Introduzca 1 para Calcular el máximo del array");
            Console.WriteLine("Introduzca 2 para Calcular el mínimo del array");
            Console.WriteLine("Introduzca 3 para Calcular la mediana del array");
            Console.WriteLine("Introduzca 4 para Calcular la media del array");
            Console.WriteLine("Introduzca 5 para Ordernar del array de menor a mayor");
            Console.WriteLine("Introduzca 6 para Calcular la desviación típica del array");
            Console.WriteLine("Introduzca 7 para Binarizar el array en base a un número N");

            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 7 || selector < 1)
                {
                    Console.WriteLine("Valor entero fuera de rango. Vuelva a intentarlo: ");
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
                    FuncionesArray.MaxValor(array);
                    break;

                case 2:
                    FuncionesArray.MinValor(array);
                    break;

                case 3:
                    FuncionesArray.CalcMediana(array);
                    break;
                case 4:
                    FuncionesArray.CalcAvg(array);
                    break;
                case 5:
                    FuncionesArray.MenorMayor(array);
                    break;
                case 6:
                    FuncionesArray.Desviacion(array);
                    break;
                case 7:
                    FuncionesArray.Binarizar(array);
                    break;

            }
        }

        //Menú strings
        public static void menu_string()
        {
            bool token = false;

            int selector = 0;

            string? cadena = "";

            Console.WriteLine("Has seleccionado las operaciones con strings");
            Console.WriteLine("");
            Console.WriteLine("Introduce la cadena que desea: ");

            cadena = Console.ReadLine();
            

            Console.WriteLine("Introduzca un número para elegir el tipo de operación que desea:  ");
            Console.WriteLine("Introduzca 1 para Calcular si el string es palíndromo");
            Console.WriteLine("Introduzca 2 para devolver el string en uppercase y en lowercase");
            Console.WriteLine("Introduzca 3 para devolver el número de ocurrencias de una letra");
            Console.WriteLine("Introduzca 4 para introducir otro string y hacer que se repita varias veces"); //te doy un parámetro, comprueba los otros 
            Console.WriteLine("Introduzca 5 para repetir cada ocurrencia de la letra");
            Console.WriteLine("Introduzca 6 para introducir otro string y borrar las ocurrencias del segundo");



            do
            {
                if (!(Int32.TryParse(Console.ReadLine(), out selector)))
                {
                    Console.WriteLine("Valor introducido no entero, Vuelva a intentarlo: ");
                }
                else if (selector > 6 || selector < 1)
                {
                    Console.WriteLine("Valor entero fuera de rango. Vuelva a intentarlo: ");
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
                    FuncionesString.Palindromo(cadena);
                    break;

                case 2:
                    FuncionesString.MayusMinus(cadena);
                    break;

                case 3:
                    FuncionesString.NumLetras(cadena);
                    break;
                case 4:
                    FuncionesString.RepetirCadena(cadena);
                    break;
                case 5:
                    FuncionesString.RepetirLetra(cadena);
                    break;
                case 6:
                    FuncionesString.BorrarCadena(cadena);
                    break;
            }
        }





    }
}
