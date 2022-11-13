using System;

namespace EjercicioIntro7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombre;
            int añosAntiguedad;
            int horasTrabajadas;
            int seguir;
            float importeBruto;
            double importeNeto;
            

            do
            {
                Console.WriteLine("Ingrese el valor hora: ");
                valorHora = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad en años: ");
                añosAntiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
                horasTrabajadas = int.Parse(Console.ReadLine());

                importeBruto = (float)(valorHora * horasTrabajadas) + (float)(añosAntiguedad * 150);
                importeNeto = importeBruto - (importeBruto * 0.13);

                Console.WriteLine("     <<< LOS DATOS INGRESADOS SON >>>");

                Console.WriteLine("Nombre del empleado: " + nombre);
                Console.WriteLine("Años de antigüedad: " + añosAntiguedad);
                Console.WriteLine("Valor por hora: " + valorHora);
                Console.WriteLine("Importe Bruto: " + importeBruto);
                Console.WriteLine("Importe Neto: " + importeNeto);


                Console.WriteLine("DESEA CONTINUAR INGRESANDO DATOS? Indique con 1) SI o 2) NO");
                seguir = int.Parse(Console.ReadLine());

                

            }while(seguir == 1);

           

            
            




            
              






            Console.ReadKey();
        }
    }
}
