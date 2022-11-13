using System;

namespace EjercicioIntro3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool result;
   
            Console.WriteLine("Ingrese un número: ");
            result = int.TryParse(Console.ReadLine(), out number);

            if (result)
            {
               for(int i = 0; i < number; i++)
                {
                    if (isPrimo(i) == true)
                    {
                        Console.WriteLine("Este número es primo: " + i);
                    }
                }    
            }
            else
            {
                Console.WriteLine("ERROR. Ingrese un numero");
            }

            Console.ReadKey();
        }
        public static bool isPrimo(int number)
        {  
            int contadorDiv = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    contadorDiv++;
                }
            }

            if (contadorDiv == 2)
            {
                return true;
            }
            return false;
        }
    }
}
