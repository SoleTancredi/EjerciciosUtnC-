using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {
        public enum Color {Roja, Blanca, Amarilla, Rosa, Azul};

        private Color florColor;

        public Rosal(string nombre, int tamanio)
            :this(nombre, tamanio, Color.Rosa)
        {

        }

        public Rosal(string nombre, int tamanio, Color color)
            :base(nombre, tamanio)
        {
            this.florColor = color;
        }

        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        public override string ResumenDeDatos()
        {
            //Su ResumenDeDatos incorporará el concepto "Flores de color: XXXXX
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Tiene flor color {this.florColor}");

            return sb.ToString();
        }




    }
}
