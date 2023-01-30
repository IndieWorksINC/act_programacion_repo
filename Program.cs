using System;
namespace ETS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int aux=0; //si vale 1 no es primo
            Console.WriteLine("Introduzca un numero entero para comprobar si es primo:");
            while(!int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine("Error, introduzca de nuevo");
            }
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)  //no es primo
                {
                    aux = 1;
                }
            }
            if (aux==1)
            {
                Console.WriteLine("El numero no es primo");
            }
            else
            {
                Console.WriteLine("El numero es primo");
            }

        }
    }

}