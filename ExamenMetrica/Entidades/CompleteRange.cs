using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenMetrica.Entidades
{
    public class CompleteRange
    {
        public List<int> build(List<int> numeros) {
            List<int> salida = new List<int>();

            //calculando mayor y menor
            int mayor = numeros[0];
            int menor = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                if (numeros[i]>mayor)
                {
                    mayor = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            for (int j = menor; j <= mayor; j++)
            {
                salida.Add(j);
            }
           

            return salida;
        }
    }
}