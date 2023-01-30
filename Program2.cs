using System;
namespace ETS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int factorial=1;
            Console.WriteLine("Introduce un número entero para calcular su factorial");
            while(!int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine("Error, introduce de nuevo");
            }
            
            for(int i = num ; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de {0} es: {1}",num, factorial);
        }
    }

}