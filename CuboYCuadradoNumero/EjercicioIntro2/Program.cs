using System;

namespace EjercicioIntro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            double resultOne;
            double resultTwo;

            Console.WriteLine("Ingrese un número: ");
            number = int.Parse(Console.ReadLine());

            if(number > 0)
            {
                resultOne = Math.Pow(number, 2);
                resultTwo = Math.Pow(number, 3);

                Console.WriteLine("Cuadrado del número ingresado: " + resultOne);
                Console.WriteLine("Cubo del número ingresado: " + resultTwo);
            }
            else
            {
                Console.WriteLine("ERROR. Ingrese un valor mayor a 0.");
            }

            Console.ReadKey();
        }
    }
}
