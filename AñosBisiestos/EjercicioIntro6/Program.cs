using System;

namespace EjercicioIntro6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from;
            int to;

            Console.WriteLine("Ingrese un año de inicio: ");
            from = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año final del rango: ");
            to = int.Parse(Console.ReadLine());

            for(int i = from; i <= to; i++)
            {
                if(i % 4 == 0)
                {
                    if(i % 100 == 0)
                    {
                        if(i % 400 == 0)
                        {
                            Console.WriteLine("Año Bisiesto: " + i);
                        }
                        else
                        {
                            Console.WriteLine("NO es bisiesto: " + i);
                        }    
                    }
                    else
                    {
                        Console.WriteLine("Año Bisiesto: " + i);    
                    }

                    
                }
                
            }
            Console.ReadKey();  
        }
    }
}
