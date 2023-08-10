using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un día de la semana al usuario
            Console.Write("Ingresa un día de la semana: ");
            string dia = Console.ReadLine();

            // Verificar si es un día laboral o no
            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un día laboral.");
                    break;
                case "sábado":
                case "domingo":
                    Console.WriteLine("No es un día laboral.");
                    break;
                default:
                    Console.WriteLine("Día no válido.");
                    break;
            }
        }
    }
}
