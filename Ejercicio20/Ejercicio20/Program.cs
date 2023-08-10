using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el número de ventas al usuario
            Console.Write("Ingresa el número de ventas: ");
            int numVentas = Convert.ToInt32(Console.ReadLine());

            // Inicializar la suma de ventas
            double sumaVentas = 0;

            // Pedir ventas y sumarlas
            for (int i = 1; i <= numVentas; i++)
            {
                Console.Write("Venta " + i + ": ");
                double venta = Convert.ToDouble(Console.ReadLine());
                sumaVentas += venta;
            }

            // Mostrar la suma de ventas
            Console.WriteLine("La suma de las ventas es: " + sumaVentas);
        }
    }
}
