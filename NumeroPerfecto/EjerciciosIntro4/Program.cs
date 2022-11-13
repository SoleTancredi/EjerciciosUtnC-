using System;

namespace EjerciciosIntro4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double result;
               
           for(int i = 1; i < 8; i++)
           {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                   result = perfectNumber(i);
                   Console.WriteLine("Numero PERFECTO: " + result);
                }

           }

            Console.ReadKey();  
        }

        public static double perfectNumber(int number)
        {
            double result;
        
                result = Math.Pow(2, number - 1) * (Math.Pow(2, number) - 1);

                return result;
        }
    }
}
