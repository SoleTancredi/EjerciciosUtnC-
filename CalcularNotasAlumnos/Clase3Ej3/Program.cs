using System;
using Biblioteca;

namespace Clase3Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Estudiante estudiante1 = new Estudiante("Maldonado", "Martin", "12345");
            Estudiante estudiante2 = new Estudiante("Lopez", "Ludmila", "15896");
            Estudiante estudiante3 = new Estudiante("Gimenes", "Daniel", "13246");

            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(10);

            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(3);

            estudiante3.SetNotaPrimerParcial(4);
            estudiante3.SetNotaSegundoParcial(6);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());  



            Console.ReadKey();


        }
    }
}
