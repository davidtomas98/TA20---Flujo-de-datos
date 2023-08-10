using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar nombre y edad al usuario
            Console.Write("Ingresa tu nombre: ");
            string tuNombre = Console.ReadLine();
            Console.Write("Ingresa tu edad: ");
            int tuEdad = Convert.ToInt32(Console.ReadLine());

            // Mostrar mensaje con nombre y edad
            Console.WriteLine("Te llamas " + tuNombre + " y tienes " + tuEdad + " años");
        }
    }
}
