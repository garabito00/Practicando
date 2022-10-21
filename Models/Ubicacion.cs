using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ubicacion
    {
        public int Ubicacion_Id { get; set; }
        public string Lugar { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }
    }
}
