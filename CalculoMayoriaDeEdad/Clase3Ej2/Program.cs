using System;
using Biblioteca;


namespace Clase3Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personita1 = new Persona("Ludmila",new DateTime(2015,2,20), "50.233.556");
            Persona personita2 = new Persona("Pilar", new DateTime(2000,8,25), "40.366.255");
            Persona personita3 = new Persona("Avril", new DateTime(2013, 6, 28), "48.322.455");

            Console.WriteLine(personita1.Mostrar());
            Console.WriteLine(personita1.EsMayorDeEdad());

            Console.WriteLine(personita2.Mostrar());
            Console.WriteLine(personita2.EsMayorDeEdad());

            Console.WriteLine(personita3.Mostrar());
            Console.WriteLine(personita3.EsMayorDeEdad());

            Console.ReadKey();  
        }
    }
}
