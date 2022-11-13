using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase6Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary

            Dictionary<string, string> comidasLatinoamericanas = new Dictionary<string, string>();

            comidasLatinoamericanas.Add("taco", "México"); //la kye no puede repetirse
            comidasLatinoamericanas.Add("mole poblano", "México");
            comidasLatinoamericanas.Add("ceviche", "Peru");

            foreach(KeyValuePair<string, string> item in comidasLatinoamericanas)
            {
                Console.WriteLine(item.Key + item.Value);
            }

            foreach(string item in comidasLatinoamericanas.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("INDEXACION EN BASE A LA KEY");
            Console.WriteLine($"mole pertenece a: {comidasLatinoamericanas["mole poblano"]}");

            Console.WriteLine($"contine empanadas? : {comidasLatinoamericanas.ContainsKey("empanadas")}");

            Console.WriteLine($"contiene argentina) : {comidasLatinoamericanas.ContainsValue("argentina")}");




            #endregion




            #region List
            List<string> mascotas = new List<string>();

            mascotas.Add("Firulais");
            mascotas.Add("Salem");
            mascotas.Add("Bola de Nieve");

            Console.WriteLine(mascotas[2]);

            foreach(string mascota in mascotas)
            {
                Console.WriteLine(mascota); 
            }
            #endregion


            #region ArrayList -NO GENERICA - Esta no la usamos
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add(false);
            #endregion
            
        }
    }
}
