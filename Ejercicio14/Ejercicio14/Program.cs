using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita el radio del círculo al usuario
            Console.Write("Ingresa el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Calcula el área del círculo
            double area = Math.PI * Math.Pow(radio, 2);

            // Muestra el resultado
            Console.WriteLine("El área del círculo es: " + area);
        }
    }
}
