using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        public enum Tipo { Terrozo, Arenoso};

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public Tipo TipoSuelo
        {
            set { suelo = value; }  
        }

        //constructor estatico
        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        //inicializar lista en constructor privado 
        private Jardin()
        {
            this.plantas = new List<Planta>();  
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal = espacioTotal;   
        }

        private int EspacioOcupado()
        {
            int espacioTotal = 0;
            foreach(Planta item in this.plantas)
            {
                espacioTotal += item.Tamanio;
            }
            return espacioTotal;

        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin j , Planta p)
        {
            if(j is not null && p is not null && j.espacioTotal >= j.EspacioOcupado(p))
            {
                j.plantas.Add(p);
                return true;    
            }
            return false;     
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Composicion del Jardin {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");

            foreach(Planta item in this.plantas)
            {
                sb.AppendLine(item.ResumenDeDatos());
            }

            return sb.ToString();
        }




            

    }
}
