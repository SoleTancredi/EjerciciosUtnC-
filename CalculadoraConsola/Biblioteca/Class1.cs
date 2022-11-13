using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static int Calcular(int primerOperando, int segundoOperando, string operacion)
        {
            int resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado=primerOperando * segundoOperando;
                    break;
                case "/": 
                    if(Calculadora.Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("No puede realizarse la división por 0. ");
                    }
                    break;
            }

            return resultado;

        }

        private static bool Validar(int segundoOperando)
        {
            if (segundoOperando == 0)
            {
                return false;
            }
            return true;
        }
    
    
    
    }

}
