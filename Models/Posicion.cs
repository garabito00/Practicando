using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Posicion
    {
        public int Posicion_Id { get; set; }
        public string Titulo { get; set; }
        public int Proyecto_Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }
    }
}
