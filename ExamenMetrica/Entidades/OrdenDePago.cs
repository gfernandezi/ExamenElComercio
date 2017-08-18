using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenMetrica.Entidades
{
    public class OrdenDePago
    {
        [Key]
        public int Codigo { get; set; }
        public double monto { get; set; }
        public double moneda { get; set; }
        public string estado { get; set; }
        public DateTime fechaPago { get; set; }
        public int codigoSucursal { get; set; }

    }
}