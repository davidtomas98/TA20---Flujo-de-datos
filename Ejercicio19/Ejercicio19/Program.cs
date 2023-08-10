using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números del 1 al 100 divisibles entre 2 y 3
            Console.WriteLine("Números del 1 al 100 divisibles entre 2 y 3:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
