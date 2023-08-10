using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar operandos y operador al usuario
            Console.Write("Ingresa el primer operando: ");
            int operando1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo operando: ");
            int operando2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el signo aritmético (+, -, *, /, ^, %): ");
            string operador = Console.ReadLine();

            // Realizar la operación correspondiente y mostrar el resultado
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = (double)operando1 / operando2;
                    break;
                case "^":
                    resultado = Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    return;
            }

            // Mostrar el resultado en un cuadro de diálogo
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
