using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;

namespace ProyectoEntornos
{
    
    class FuncionesUtiles
    {

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
        public static void MaxValor(decimal[] lista)
        {
            //Calcular máximo
            Console.WriteLine("Maldito idiota");
        }
        public static void MinValor(decimal[] lista)
        {
            //Calcular mínimo
        }
        public static void CalcMediana(decimal[] lista)
        {
            //Calcular la mediana
        }
        public static void CalcAvg(decimal[] lista)
        {
            //Calcular la media
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
            num = Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine("El número redondeado al alza es: {0} ",num);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
        public static void Truncar(decimal num)
        {
            //Eliminar los decimales del número
            num = Math.Truncate(num);
            Console.WriteLine("El número truncado es: {0} ", num);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();

        }
        public static void EcuacionSegundGrado(decimal num)
        {
            //Dados tres coeficientes ejecutar la ecuación de segundo grado
            double a;
            double b;
            double c;
            Console.WriteLine("Introduce un numero para la variable a");
            if (double.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Introduce un numero para la variable b");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Introduce un numero para la variable c");
                    if (double.TryParse(Console.ReadLine(), out c))
                    {
                        double calculo = b * b - 4 * a * c;
                        if (calculo > 0)
                        {
                            double resultado1 = (-b + Math.Sqrt(calculo)) / (2 * a);
                            double resultado2 = (-b - Math.Sqrt(calculo)) / (2 * a);
                            Console.WriteLine("Las raíces son: x1 = {0}, x2 = {1}", resultado1, resultado2);
                        }
                        else if (calculo == 0)
                        {
                            double x = -b / (2 * a);
                            Console.WriteLine("La raíz es: x = {0}", x);
                        }
                        else
                        {
                            Console.WriteLine("La ecuación no tiene raíces reales.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La el valor introducido en la variable c no es un número");
                    }
                }
                else
                {
                    Console.WriteLine("La el valor introducido en la variable b no es un número");
                }
            }
            else
            {
                Console.WriteLine("La el valor introducido en la variable a no es un número");
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
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