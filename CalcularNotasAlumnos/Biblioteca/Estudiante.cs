using System;
using System.Text;


namespace Biblioteca
{
    public class Estudiante
    {
        //en c# todos los miembros son declarados privados implicitamente
        #region Atributos
        private string apellido; 
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        #endregion

        /// <summary>
        /// Constructor estático : Instancia el objeto random
        /// </summary>
        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        /// <summary>
        /// Constructor de instancia: inicializa tres atributos, pasados por parámetro
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="legajo"></param>
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
           
        }

        /// <summary>
        /// Setter : permite cambiar el valor del dato notaPrimerParcial
        /// </summary>
        /// <param name="notaPrimerParcial"></param>
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        /// <summary>
        /// Setter : permite cambiar el valor del dato notaSegundoParcial
        /// </summary>
        /// <param name="notaSegundoParcial"></param>
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        /// <summary>
        /// Retorna el promedio de ambas notas. Al ser un método privado
        /// puede usarse solamente desde dentro de su misma clase
        /// </summary>
        /// <returns></returns>
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        /// <summary>
        /// Retorna la nota final con un numero aleatorio entre 6 y 10 incluidos
        ///  siempre y cuando las notas del primer y segundo parcial sean mayores 
        ///  o iguales a 4,  caso contrario la inicializará con el valor -1.
        /// </summary>
        /// <returns></returns>
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Muestra todos los datos de alumnos 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            datos.AppendLine("*************************** ");
            datos.AppendLine("Datos del Alumno: \n");
            datos.AppendLine($"Apellido: {apellido}");
            datos.AppendLine($"Nombre: {nombre}"); 
            datos.AppendLine($"Legajo: {legajo}\n");
            datos.AppendLine("--------------------------- \n");
            datos.AppendLine($"Nota Primer Parcial: {notaPrimerParcial}");
            datos.AppendLine($"Nota Segundo Parcial: {notaSegundoParcial}");
            datos.AppendLine($"Promedio: {CalcularPromedio()}");
            
            if(notaFinal > -1)
            {
                datos.AppendLine($"Nota Final: {notaFinal}\n");
                datos.AppendLine("*************************** ");
            }
            else
            {
                datos.AppendLine("Nota Final: Alumno Desaprobado \n");
                datos.AppendLine("*************************** ");
            }
 
            return datos.ToString();
        }

    }
}
