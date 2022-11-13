using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Banano:Planta
    {
        private string codigo;

        public Banano(string nombre, int tamanio, string codigo)
            :base(nombre, tamanio)
        {
            this.codigo = codigo;   
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
                return true;
            }
        }

        public override string ResumenDeDatos()
        {
            //Su ResumenDeDatos incorporará el concepto "Codigo Internacional: XXXXX
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Codigo Internacional: {this.codigo}");

            return sb.ToString();
        }
    }
}
