using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dos números al usuario
            Console.Write("Ingresa el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Comparar y mostrar el número mayor
            if (numero1 > numero2)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
    }
}
