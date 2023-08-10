using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar números pares o divisibles entre 3 del 1 al 100
            Console.WriteLine("Números pares o divisibles entre 3 del 1 al 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
