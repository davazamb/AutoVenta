using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoVenta.Models
{
    public class Vehiculos
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
    }
}