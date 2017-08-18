using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenMetrica.Entidades
{
    public class ChangeString
    {
        public string build(string entrada) {
            string resultado = String.Empty;
            string abecedario = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,ñ,o,p,q,r,s,t,u,v,w,,x,y,z";

            List<string> lista = new List<string>();
            foreach (var i in abecedario.Split(','))
            {           
                    lista.Add(i.ToString());                           
            }
            
            foreach (var item in entrada)
            {
                if (Char.IsLetter(item))
                {
                    for (int j = 0; j < lista.Count-1; j++)
                    {
                        if (Char.Equals(item.ToString(), lista[j].ToString()))
                        {
                            resultado = String.Concat(resultado, lista[j + 1]);
                        }
                    }             
                }
                else
                {
                    resultado = String.Concat(resultado, item);
                }
            }            
            return resultado;
        }
    }
}