using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenMetrica.Entidades
{
    public class Sucursal
    {
        [Key]
        public int Codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int codigoBanco { get; set; }
    }
}