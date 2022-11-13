using System;
using Biblioteca;

namespace CalculadoraConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operacion;
            int primerOperando;
            int segundoOperando;

            Console.WriteLine("Ingrese el primer operando: ");
            primerOperando =int.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese el segundo operando: ");
            segundoOperando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion deseada + - * /: ");
            operacion = Console.ReadLine();

            Console.WriteLine("El resultado es: " + Calculadora.Calcular(primerOperando, segundoOperando, operacion));

            Console.ReadKey();  
        }
    }
}
