using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lee un número por teclado
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica si es divisible entre 2
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es divisible entre 2.");
            }
            else
            {
                Console.WriteLine("El número no es divisible entre 2.");
            }
        }
    }
}
