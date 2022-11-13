using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get { return tamanio; } 
        }

        public abstract bool TieneFlores
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre.ToUpper()} tiene un tamaño de {this.tamanio}");
            sb.AppendLine(string.Format("Tiene Flores {0}", this.TieneFlores? "SI" : "NO"));
            sb.AppendLine(string.Format("Tiene Fruto {0}", this.TieneFruto? "SI" : "NO"));

            return sb.ToString();             
        }





    }
}
