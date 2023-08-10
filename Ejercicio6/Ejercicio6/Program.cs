using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar precio del producto al usuario
            Console.Write("Ingresa el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Solicitar forma de pago al usuario
            Console.Write("Forma de pago (efectivo o tarjeta): ");
            string formaPago = Console.ReadLine();

            // Verificar forma de pago y solicitar número de cuenta si es tarjeta
            if (formaPago.ToLower() == "tarjeta")
            {
                Console.Write("Número de cuenta: ");
                string numeroCuenta = Console.ReadLine();
            }

            // Mostrar resumen
            Console.WriteLine("Resumen de compra:");
            Console.WriteLine("Precio del producto: $" + precio);
            Console.WriteLine("Forma de pago: " + formaPago);
        }
    }
}
