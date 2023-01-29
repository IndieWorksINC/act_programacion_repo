using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;

namespace ProyectoEntornos
{
    
    class FuncionesUtiles
    {
        //public static decimal EsDecimal(string valor)
        //{

        //}
    }
    
    //
    //
    //
    // Como Modifiques algo date por muerto<3
    //
    //
    //
    
    
    class FuncionesEntero
    {
        public static void EsPrimo(int num)
        {
            Console.WriteLine("Esto es un test del github");
            //Calcular si el número es primo
        }
        public static void CalcFactorial(int num)
        {
            //Calcular el factorial
        }
        public static void HorasMinutos(int num)
        {
            //Dado un número en segundos, devolver horas y minutos (3680 segundos son 1 hora, 1 min, y 20 segundos).
        }
        public static void SeriePell(int num)
        {
            //Devolver los primeros 15 números de la serie de Pell
        }
        public static void NumeroArmstrong(int num)
        {
            //Devolver si un número es un número de Armstrong o no
        }
        public static void DigitoDiferente(int num)
        {
            //Devolver si un número tiene todos sus dígitos diferentes
        }
    }
    class FuncionesArray
    {
        public static decimal MaxValor(decimal[] lista)
        {
            decimal max = lista[0];
            for (int i = 1; i < lista.Length; i++)
            {
                if (lista[i] > max)
                {
                    max = lista[i];
                }
            }
            Console.WriteLine("El número máximo es: " + max);
            return max;
        }
        public static decimal MinValor(decimal[] lista)
        {
            decimal min = lista[0];
            for (int i = 1; i < lista.Length; i++)
            {
                if (lista[i] < min)
                {
                    min = lista[i];
                }
            }
            Console.WriteLine("El número mínimo es: " + min);
            return min;
        }
        public static decimal CalcMediana(decimal[] lista)
        {
            Array.Sort(lista);
            decimal mediana;
            int mid = lista.Length / 2;
            if (lista.Length % 2 != 0)
            {
                mediana = lista[mid];
            }
            else
            {
                mediana = (lista[mid - 1] + lista[mid]) / 2;
            }
            Console.WriteLine("La mediana es: " + mediana);
            return mediana;
        }
        public static decimal CalcAvg(decimal[] lista)
        {
            decimal suma = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                suma += lista[i];
            }
            decimal media = suma / lista.Length;
            Console.WriteLine("La media es: " + media);
            return media;
        }
        public static void MenorMayor(decimal[] lista)
        {
            //Ordenar un Array de menor a mayor
        }
        public static void Desviacion(decimal[] lista)
        {
            //Calcular la desviación típica de un array
        }
        public static void Binarizar(decimal[] lista)
        {
            //Binarizar un array en base a un número n. Esta función devolverá un nuevo array, cuyos elementos valdrán 0 o 1.Si el componente i del array original es menor que n, el componente i del array resultado será 0, y 1 en el caso contrario.
        }
    }
    class FuncionesDecimal
    {
        public static void Redondear(decimal num)
        {
            //Redondear el número al alza
        }
        public static void Truncar(decimal num)
        {
            //Eliminar los decimales del número
        }
        public static void EcuacionSegundGrado(decimal num)
        {
            //Dados tres coeficientes ejecutar la ecuación de segundo grado
            while (true)
            {

                double a = 0;
                double b = 0;
                double c = 0;

                double x1 = 0;
                double x2 = 0;


                Console.WriteLine("Esta función requiere de que introduzca 3 nuevos valores para ejecutar la ecuación: ");
                Console.WriteLine("Introduzca el valor A de la ecuación: ");

                while(!Double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Valor introducido no decimal. Vuelva a intentarlo: ");
                }
                Console.WriteLine("Introduzca el valor B de la ecuación: ");

                while (!Double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Valor introducido no decimal. Vuelva a intentarlo: ");
                }
                Console.WriteLine("Introduzca el valor C de la ecuación: ");

                while (!Double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Valor introducido no decimal. Vuelva a intentarlo: ");
                }

                Console.WriteLine($"La ecuación introducida es {a}x^2 + {b}x + {c}");

                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                if(Double.IsNaN(x1) || Double.IsNaN(x2))
                {
                    Console.WriteLine("La ecuación tiene un valor imaginario que no existe dentro del conjunto de los números reales.");
                }
                if(x1 == x2)
                {
                    Console.WriteLine($"La ecuación solo tiene una solución real: x={x1}");
                }
                else
                {
                    Console.WriteLine($"El valor de x es {x1} y {x2}");

                }
            }
                
                
            //if(a != 0 && b != 0 && c != 0)
            //{

            //}


        }
    }
    class FuncionesString
    {
        public static void Palindromo(string cadena)
        {
            //Devolver si el string es un palíndromo
        }
        public static void MayusMinus (string cadena)
        {
            //Escribir el nombre todo en mayúsculas y todo en minúsculas
        }
        public static void NumLetras(string cadena)
        {
            //Devolver el número de ocurrencias de una letra
        }
        public static void RepetirCadena(string cadena)
        {
            //Dados dos Strings distintos, hacer que se repitan las veces que informe el usuario.(Alejandro, crack, 2->Alejandro crack Alejandro crack)
        }
        public static void RepetirLetra(string cadena)
        {
            //Dado un String, repetir cada ocurrencia de su letra. Por ejemplo: NBA se convierte en NNBBAA, Madrid en MMaaddrriidd.
        }
        public static void BorrarCadena(string cadena)
        {
            //Dado dos Strings, borrar del primero las apariencias del segundo.Por ejemplo, dado Real Zaragoza es de la realeza y Real¸ la función devolverá Zaragoza es de la eza.
        }
    }
}