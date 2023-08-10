using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar nombre de la semana al usuario
            Console.Write("Ingresa el nombre de la semana: ");
            string nombreSemana = Console.ReadLine();

            // Verificar si es fin de semana o no
            if (nombreSemana.ToLower() == "sábado" || nombreSemana.ToLower() == "domingo")
            {
                Console.WriteLine("Es fin de semana.");
            }
            else
            {
                Console.WriteLine("No es fin de semana.");
            }
        }
    }
}
