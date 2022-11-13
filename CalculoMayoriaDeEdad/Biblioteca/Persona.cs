using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;
        #endregion

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

      
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;

        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToShortDateString();
        }

        public string GetDni()
        {
            return dni;    
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int años = fechaActual.Year - this.fechaDeNacimiento.Year;
            return años;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            
            datos.AppendLine("*************************** ");
            datos.AppendLine("Datos de la persona: \n");
            datos.AppendLine($"Nombre: {GetNombre()}");
            datos.AppendLine($"Fecha de Nacimiento: {GetFechaDeNacimiento()}");
            datos.AppendLine($"Dni: {GetDni()}");          
            datos.AppendLine($"Edad actual: {CalcularEdad()}");
            datos.AppendLine("*************************** ");

            return datos.ToString();
        }

        public string EsMayorDeEdad()
        {
            StringBuilder info = new StringBuilder();   

            if(CalcularEdad() > 17)
            {
                info.AppendLine("Es mayor de edad");

            }
            else
            {
                info.AppendLine("Es menor de edad.");
            }

            return info.ToString(); 
        }



    }
}
