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
        }
        public static void Truncar(decimal num)
        {
            //Eliminar los decimales del número
        }
        public static void EcuacionSegundGrado(decimal num)
        {
            //Dados tres coeficientes ejecutar la ecuación de segundo grado
        }
    }
    class FuncionesString
    {
        public static void Palindromo(string cadena)
        {
            //Devolver si el string es un palíndromo
            string prueba="";
            cadena = cadena.ToUpper();
            int cuenta = cadena.Length;
            for (int cont = cuenta - 1; cont >= 0; cont--)
            {
                prueba = prueba + cadena[cont];
            }
            if (prueba == cadena)
            {
                Console.WriteLine("Es palindrome");
            }
            else
            {
                Console.WriteLine("No es palindrome");
            }
        }
        public static void MayusMinus (string cadena)
        {
            //Escribir el nombre todo en mayúsculas y todo en minúsculas
            Console.WriteLine(cadena.ToUpper());
            Console.WriteLine(cadena.ToLower());
        }
        public static void NumLetras(string cadena)
        {
            //Devolver el número de ocurrencias de una letra
            bool puede = false;
            char letra;
            do
            {
                Console.WriteLine("Introduzca la letra a contar en la cadena: ");
                if (Char.TryParse(Console.ReadLine(), out letra))
                    puede = true;
                else
                    Console.WriteLine("Porfavor, vuelva a intentarlo.");
                
            } while (!puede);

            int cuenta =0;
            char[] prueba = cadena.ToCharArray();

            for (int cont = 0; cont < cadena.Length-1; cont++)
            {
                if (prueba[cont] == letra)
                    cuenta++;
            }
            Console.WriteLine("La letra " + letra + " aparece: {0}vez/veces.", cuenta);
          
        }
        public static void RepetirCadena(string cadena)
        {
            //Dados dos Strings distintos, hacer que se repitan las veces que informe el usuario.(Alejandro, crack, 2->Alejandro crack Alejandro crack)
            Console.WriteLine("Introduzca una segunda cadena: ");
            string cadena2= Console.ReadLine();
            int num=0;
            do
            {
                Console.WriteLine("Introduzca el número de veces a repetir: ");
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    for (int cont = 0; cont <=num; cont++)
                    {
                        Console.WriteLine(cadena+cadena2+"/");
                    }
                }
                else
                    Console.WriteLine("Porfavor, vuelta a intentarlo. ");
            }while(num != 0);
        
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