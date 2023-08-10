using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante del IVA
            const double IVA = 0.21;

            // Solicitar el precio del producto al usuario
            Console.Write("Ingresa el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Calcular el precio final con IVA
            double precioConIVA = precio * (1 + IVA);

            // Mostrar el precio final con IVA
            Console.WriteLine("El precio final con IVA es: " + precioConIVA);
        }
    }
}
