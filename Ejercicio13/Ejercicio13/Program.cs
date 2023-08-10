using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita el nombre al usuario
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // Muestra un mensaje de bienvenida con el nombre
            Console.WriteLine("Bienvenido " + nombre);
        }
    }
}
