using System;
using Biblioteca;

namespace Clase03Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int seguir;
            decimal monto;
            decimal monto2;

            //instanciar objeto
            Cuenta nuevaCuenta = new Cuenta("Soledad", 20000);

            do
            {
                Console.WriteLine("Bienvenido! Ingresa una opción: " +
               "\n 1.Mostrar" +
               "\n 2.Ingresar" +
               "\n 3.Retirar");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(nuevaCuenta.Mostrar());
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el monto que desea ingresar: ");   
                        monto = decimal.Parse(Console.ReadLine());
                        nuevaCuenta.Ingresar(monto);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        monto2 = decimal.Parse(Console.ReadLine());
                        nuevaCuenta.Retirar(monto2);
                        break;
                }

                Console.WriteLine("**Desea continuar?\n" +
                    "Ingrese: 1.Si 2.No");
                seguir = int.Parse(Console.ReadLine());

            } while (seguir == 1);

            Console.WriteLine("Vuelva pronto!");
  
            Console.ReadLine(); 
        }
    }
}
