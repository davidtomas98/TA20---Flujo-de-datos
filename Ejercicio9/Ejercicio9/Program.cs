using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar números pares del 1 al 100
            Console.WriteLine("Números pares del 1 al 100:");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
