using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        #region atributos

        private string titular;
        private decimal cantidad;

        #endregion

        /// <summary>
        /// 
        /// constructor con parametros
        /// </summary>
        /// <param name="titular"> se le asigna lo ingresado</param>
        /// <param name="cantidad"></param>
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// devuelve info de la razon social de la cuenta
        /// </summary>
        /// <returns></returns>
        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        //
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            string retorno;

            datos.AppendLine(GetTitular());
            datos.AppendLine(GetCantidad().ToString());
            retorno = datos.ToString();

            return retorno;
        }

        //Ingresar
        public void Ingresar(decimal monto)
        {
            if(monto > 0)
            {
                this.cantidad += monto;  
            }
        }

        //Retirar
        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }





    }

}
