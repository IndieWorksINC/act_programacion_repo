using System;
namespace ETS
{
    class Program
    {
        static void Main(string[] args)
        {
            int seg;
            int min;
            int h;
            Console.WriteLine("Introduce los segundos");
            while (!int.TryParse(Console.ReadLine(), out seg))
            {
                Console.WriteLine("Error, introduce de nuevo los segundos");
            }
            h = seg / 3600;
            min = (seg - h * 3600) / 60;
            seg = seg - ((h * 3600) + (min * 60));
            

            Console.WriteLine("{0} horas, {1} minutos, {2} segundos",h,min,seg);
        }
    }
}