using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contraseña predefinida
            string contraseñaCorrecta = "Averiguala1";

            // Inicializar contador de intentos
            int intentos = 3;

            // Ciclo para solicitar la contraseña hasta que se acierten los intentos o se agoten
            while (intentos > 0)
            {
                Console.Write("Introduce la contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                if (contraseñaIngresada == contraseñaCorrecta)
                {
                    Console.WriteLine("¡Enhorabuena!");
                    break;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Contraseña incorrecta. Intentos restantes: " + intentos);
                }
            }

            if (intentos == 0)
            {
                Console.WriteLine("Se han agotado los intentos.");
            }
        }
    }
}
