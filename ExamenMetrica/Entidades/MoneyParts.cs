using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenMetrica.Entidades
{
    public class MoneyParts
    {
        //public List<decimal> Agregar(List<decimal> listado, decimal item, decimal cantidad)
        //{
        //    List<decimal> lista = new List<decimal>();

        //    for (int j = 1; j <= cantidad; j++)
        //    {
        //        listado.Add(item);
        //    }
        //    return listado;

        //}
        public List<decimal> Agregar(decimal item, decimal cantidad,  List<decimal> lista) {
           
            for (int j = 1; j <= cantidad; j++)
            {
                lista.Add(item);
            }           
            return lista;
        }
        public void Evaluar(decimal[] denominaciones, decimal cociente, decimal dividendo, decimal divisor, List<decimal> listaPrevia, decimal resto, ref List<List<decimal>> resultado) {
            List<decimal> lista = new List<decimal>();
            List<decimal> resuPrevio = new List<decimal>();

            foreach (decimal item in denominaciones)
            {
               
                if (dividendo >= item)
                {
                    divisor = item;
                    resto = dividendo % divisor;
                    cociente = dividendo / (decimal)divisor;
                    if (resto == 0)
                    {
                        lista = Agregar(divisor, cociente, listaPrevia);
                        resultado.Add(lista);
                    }
                    else
                    {
                        lista = Agregar(divisor, cociente, listaPrevia);
                        dividendo = resto;
                        resultado.Add(lista);
                    }
                }
            }
        }
        public List<List<decimal>> build(decimal dividendoOriginal) {
            List<List<decimal>> resultado = new List<List<decimal>>();
            List<decimal> resuPrevio;
            //decimal[] denominaciones = new decimal[]{ 0.05M, 0.1M, 0.2M, 0.5M, 1, 2, 5, 10, 20, 50, 100, 200};
            decimal[] denominaciones = { 1,2,5 };
         
            decimal divisor = 0;
            decimal cociente = 0;
            decimal resto = 0;
            decimal dividendo = 0;
            
            foreach (decimal itm in denominaciones)
            {
                divisor = itm;
                dividendo = dividendoOriginal;
                resuPrevio = new List<decimal>();
                if (dividendo >= divisor)
                {
                    resto = dividendo % (decimal)divisor;                 
                    cociente = dividendo / (decimal)divisor;
                    if (resto==0)
                    {
                        resuPrevio = Agregar(divisor, cociente, resuPrevio);
                        resultado.Add(resuPrevio);
                    }
                    else {
                        resuPrevio = Agregar(divisor, cociente, resuPrevio);                        
                        dividendo = resto;

                        foreach (decimal item in denominaciones)
                        {
                           
                            if (dividendo >= item)
                            {
                                divisor = item;
                                resto = dividendo % divisor;
                                cociente = dividendo / (decimal)divisor;
                                if (resto == 0)
                                {
                                    resuPrevio = Agregar(divisor, cociente, resuPrevio);
                                    resultado.Add(resuPrevio);
                                }
                                else
                                {
                                    resuPrevio = Agregar( divisor, cociente, resuPrevio);
                                    //resultado.Add(resuPrevio);
                                    dividendo = resto;
                                    Evaluar(denominaciones, cociente, dividendo, divisor, resuPrevio, resto, ref resultado);
                                }
                            }                                    
                        }                       
                    }                       
                }                
            }
            return resultado;
        }
    }
}