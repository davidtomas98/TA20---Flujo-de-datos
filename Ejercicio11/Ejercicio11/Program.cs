using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara dos variables numéricas
            int num1 = 10;
            int num2 = 20;

            // Compara los valores de las variables y muestra el resultado
            if (num1 > num2)
            {
                Console.WriteLine("El primer número es mayor.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El segundo número es mayor.");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
    }
}
