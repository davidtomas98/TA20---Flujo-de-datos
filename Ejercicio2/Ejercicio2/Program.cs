using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar nombre y ciudad al usuario
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa el nombre de una ciudad: ");
            string ciudad = Console.ReadLine();

            // Mostrar mensaje de bienvenida
            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }
    }
}
